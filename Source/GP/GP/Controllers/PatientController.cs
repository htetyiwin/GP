using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using GP.DAO;
using GP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using OfficeOpenXml;

namespace GP.Controllers
{
    public class PatientController : AppBaseController
    {
        const string SessionFile = "_FileID";
        public IActionResult PatientList()
        {
            //if (!IsAllowed(1,2))
            //{
               
            //    return RedirectToAction("NoPermission", "AppBase");
            //}

            List<Patient> lstPatient = new PatientDao().GetAllPatient().ToList();
            ViewBag.patientList = lstPatient;
            return View();
        }
        public IActionResult Index()
        {
            //if (!IsAllowed(2,2))
            //{
            //    return RedirectToAction("NoPermission", "AppBase");
            //}

            List<Gender> lstGender = new GenderDao().GetAllGender().ToList();
            lstGender.Insert(0, new Gender() { GenderID = 0, GenderName = "Select Gender Name" });
            ViewBag.GenderList = new SelectList(lstGender, "GenderID", "GenderName");
            
            return View();
        }

        public IActionResult EditPatient(string patientId)
        {
            Patient patient = new PatientDao().GetAllPatient().Where(x => x.PatientID == Convert.ToInt32(patientId)).ToList()[0];
            List<Gender> lstGender = new GenderDao().GetAllGender().ToList();
            lstGender.Insert(0, new Gender() { GenderID = 0, GenderName = "Select Gender Name" });
            ViewBag.GenderList = new SelectList(lstGender, "GenderID", "GenderName");

            List<Attachments> lstAttachments = new AttachmentDao().GetAllTmpAttachmentsByIssueId(Convert.ToInt32(patientId)).ToList();
            ViewBag.AttachmentsList = lstAttachments;
            return View(patient);
        }

        [HttpPost, ActionName("editPatientSave")]
        public async Task<JsonResult> UpdatePatient(ImportClass tempData)
        {
            dynamic jsData = JsonConvert.DeserializeObject(tempData.receive);
            var fileID = HttpContext.Session.GetInt32(SessionFile);
            string DateOfBirth = jsData.DOB;

            Patient patient = new Patient();
            patient.PatientID = jsData.Patient_ID;
            patient.PatientCode = jsData.Patient_Code;
            patient.PatientName = jsData.Patient_Name;
            patient.Address = jsData.Address;
            patient.GenderID = jsData.GenderID;
            //patient.FileID = Convert.ToInt32(fileID);

            if (!string.IsNullOrEmpty(DateOfBirth))
            {
                string[] datePart = DateOfBirth.Split('/');
                patient.DOB = new DateTime(Convert.ToInt32(datePart[2]), Convert.ToInt32(datePart[1]), Convert.ToInt32(datePart[0]));
            }

            int message = new PatientDao().EditPatient(patient);

            return Json(new
            {
                status = message
            });

        }

        [HttpPost, ActionName("insertPatient")]
        public async Task<JsonResult> PostPatient(ImportClass tempData)
        {
            dynamic jsData = JsonConvert.DeserializeObject(tempData.receive);
            string DateOfBirth = jsData.DOB;
            var fileID = HttpContext.Session.GetInt32(SessionFile);

            Patient patient = new Patient();
            patient.PatientCode = jsData.Patient_Code;
            patient.PatientName = jsData.Patient_Name;
            patient.Address = jsData.Address;
            //patient.FileID = Convert.ToInt32(fileID);
            patient.GenderID = jsData.GenderID;
            
            if (!string.IsNullOrEmpty(DateOfBirth))
            {
                string[] datePart = DateOfBirth.Split('/');
                patient.DOB = new DateTime(Convert.ToInt32(datePart[2]), Convert.ToInt32(datePart[1]), Convert.ToInt32(datePart[0]));
            }

            int message = new PatientDao().Create(patient);

            return Json(new
            {
                status = message 
            });

        }
        
        public JsonResult GetPatient()
        {
            List<Patient> lstPatient = new PatientDao().GetAllPatient();
            return Json(lstPatient);
        }

        public IActionResult Import()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> FileUpload(List<IFormFile> files, string FileId)
        {
            int fileId = Convert.ToInt32(FileId);
            string folderName = "Upload/";
            foreach (IFormFile item in files)
            {
                if (item.Length > 0)
                {
                    string fileName = ContentDispositionHeaderValue.Parse(item.ContentDisposition).FileName.Trim('"');
                    string name = Path.GetFileNameWithoutExtension(fileName);
                    //string fullPath = Path.Combine(folderName, fileName + Guid.NewGuid());

                    string imgext = Path.GetExtension(fileName);
                    int fileCount = Directory.GetFiles("wwwroot/" + folderName, "*.*", SearchOption.AllDirectories).Length;
                    string fullPath = Path.Combine(folderName, "F0000" + fileCount + imgext);

                    //FileInfo fi = new FileInfo(fullPath);
                    if (System.IO.File.Exists(fullPath))
                    {
                        return Json(new
                        {
                            status = 1
                        });
                    }

                    if (imgext == ".jpg" || imgext == ".png")
                    {
                        using (var stream = new FileStream("wwwroot/" + fullPath, FileMode.Create))
                        {
                            item.CopyTo(stream);
                        }
                        if (fileId > 0)
                        {
                            ImageFile image = new ImageFile();
                            image.FileID = fileId;
                            image.FileName = fileName;
                            image.FilePath = fullPath;
                            int message = new ImageDao().EditFile(image);
                            HttpContext.Session.SetInt32(SessionFile, message);
                        }
                        else
                        {
                            ImageFile image = new ImageFile();
                            image.FileName = fileName;
                            image.FilePath = fullPath;
                            int message = new ImageDao().Create(image);
                            HttpContext.Session.SetInt32(SessionFile, message);
                        }

                    }
                }
            }

            return Json(new
            {
                status = 0
            });
        }

        [HttpPost]
        public async Task<JsonResult> ImportExcel(IFormFile files)
        {
            FindPatient fnPatient = new FindPatient();
            try
            {
                string folderName = "wwwroot/ExcleUpload/";
               
                    if (files.Length == 0)
                    {
                        fnPatient.RetCode = 0;
                        fnPatient.RetMessage = "Please select an excel file!";
                        return Json(fnPatient);
                    }
                    else
                    {
                        string fileName = ContentDispositionHeaderValue.Parse(files.ContentDisposition).FileName.Trim('"');
                        string name = Path.GetFileNameWithoutExtension(fileName);
                        string fileExt = Path.GetExtension(fileName);
                        string fullPath = Path.Combine(folderName, fileName);

                        if (fileExt != ".xls" && fileExt != ".xlsx")
                        {
                            fnPatient.RetCode = 0;
                            fnPatient.RetMessage = "Error in excel file importing!";
                            return Json(fnPatient);
                        }
                       
                        if (System.IO.File.Exists(fullPath))
                            System.IO.File.Delete(fullPath);

                        using (var stream = new FileStream(fullPath, FileMode.Create))
                        {
                        files.CopyTo(stream);
                        }
                        FileInfo fi = new FileInfo(fullPath);
                        using (ExcelPackage excelPackage = new ExcelPackage(fi))
                        {
                            ExcelWorksheets wkb = excelPackage.Workbook.Worksheets;
                            ExcelWorksheet wks = wkb["Sheet1"];
                            List<Patient> lstPatient = new List<Patient>();
                        for (int i = wks.Dimension.Start.Row; i <= wks.Dimension.End.Row; i++)
                        {
                            Patient patient = new Patient();
                            patient.PatientCode = (wks.Cells[i, 1]).Text;
                            patient.PatientName = (wks.Cells[i, 2]).Text;
                            patient.GenderName = (wks.Cells[i, 3]).Text;
                            patient.Address = (wks.Cells[i, 4]).Text;

                            lstPatient.Add(patient);
                        }
                        ViewBag.PatientList = lstPatient;

                            HttpContext.Session.SetObjectAsJson("patient", lstPatient);
                            System.IO.File.Delete(fullPath);


                            fnPatient.RetCode = 1;
                            fnPatient.RetMessage = "Success import an excel file!";
                            fnPatient.PatientList = lstPatient;

                            //string sJSONResponse = JsonConvert.SerializeObject(fnPatient);

                            return Json(fnPatient);

                        
                        }

                    }
                   

            }
            catch (Exception ex)
            {
                fnPatient.RetCode = 0;
                fnPatient.RetMessage = ex.Message;
                return Json(new { fnPatient });
            }

        }
       
        public JsonResult SaveExcelData()
        {
            
            List<Patient> lstPatient = new List<Patient>();
            List<Gender> lstGender = new GenderDao().GetAllGender().ToList();

            lstPatient = HttpContext.Session.GetObjectFromJson<List<Patient>>("patient");
            ReturnMessage returnMessage = new ReturnMessage();

            for (int i = 0; i < lstPatient.Count; i++)
            {

                lstPatient[i].GenderID = (from x in lstGender
                                          where x.GenderName == lstPatient[i].GenderName
                                          select x.GenderID).FirstOrDefault();

                lstPatient[i].Created_By = 1;
                lstPatient[i].Created_On = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                lstPatient[i].Modified_By = 1;
                lstPatient[i].Modified_On = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                lstPatient[i].Active = true;

            }

            returnMessage = new PatientDao().Import(lstPatient);

            return Json(lstPatient);
        }

        public JsonResult UploadFile(IFormFile attachFile)
        {
            ReturnMessage returnMessage = new ReturnMessage();

            FindPatient fnPatient = new FindPatient();
            if (attachFile == null)
            {
                fnPatient.RetCode = 0;
                fnPatient.RetMessage = "Please select one file!";
                return Json(fnPatient);
            }
            try
            {
                List<FtpServer> lstFtpServer = new FtpServerDao().GetAllFtpServerList().ToList();
                if (lstFtpServer == null || lstFtpServer.Count < 1)
                {
                    fnPatient.RetCode = 0;
                    fnPatient.RetMessage = "Can not connect FTP Server!";
                    return Json(fnPatient);
                }

                string serverAddress = lstFtpServer[0].ServerAddress;
                string userName = lstFtpServer[0].UserName;
                string password = lstFtpServer[0].Password;

                var ftpRequest = (FtpWebRequest)FtpWebRequest.Create(serverAddress + "FTPTEST.txt");
                
                ftpRequest.Credentials = new NetworkCredential(userName, password);
                ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                var ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                var ftpStream = ftpResponse.GetResponseStream();

                Attachments attachment = new Attachments();
                attachment.FileCode = "";
                attachment.FileName = attachFile.FileName;
                int dotIndex = attachFile.FileName.LastIndexOf('.');
                attachment.FileType = attachFile.FileName.Substring(dotIndex + 1);
                //User user = (User)Session["AppUser"];
                attachment.AttachedBy = 1;

                //List<Attachments> lstAttachments = (List<Attachments>)Session["lstAttachments"];
                List<Attachments> lstAttachments = new List<Attachments>();

                returnMessage = new AttachmentDao().Create(attachment);

             

                if (returnMessage.RetCode > 0)
                {
                    var attachFileName = returnMessage.RetMessage + "." + attachment.FileType;

                    //var reader = new StreamReader();

                    Stream streamObj = attachFile.OpenReadStream();
                    byte[] buffer = new byte[attachFile.Length];
                    streamObj.Read(buffer, 0, buffer.Length);
                    streamObj.Close();
                    streamObj = null;
                    string ftpurl = String.Format("{0}/{1}", serverAddress, attachFileName);
                    var requestObj = FtpWebRequest.Create(ftpurl) as FtpWebRequest;
                    
                    requestObj.Method = WebRequestMethods.Ftp.UploadFile;
                    requestObj.Credentials = new NetworkCredential(userName, password);
                    var requestStream = requestObj.GetRequestStream();
                    requestStream.Write(buffer, 0, buffer.Length);
                    requestStream.Flush();
                    requestStream.Close();
                    requestObj = null;

                    attachment.Id = returnMessage.RetCode;
                    attachment.FileCode = returnMessage.RetMessage;

                    fnPatient.RetCode = 1;
                    lstAttachments.Add(attachment);
                   
                }

                HttpContext.Session.SetObjectAsJson("lstAttachments", lstAttachments);
                fnPatient.AttachmentsList = lstAttachments;

                return Json(fnPatient);
            }
            catch (Exception ex)
            {
                fnPatient.RetCode = 0;
                fnPatient.RetMessage = "Error in file attachment";
                return Json(fnPatient);
            }

        }

        public ActionResult DownloadFile(string fileCode, string fileName, string fileType)
        {
            try
            {

                FtpServer ftpServer = new FtpServerDao().GetAllFtpServerList().ToList()[0];

                string host = ftpServer.ServerAddress;
                //string host = "ftp://localhost/";
                string remoteFile = fileCode + "." + fileType;
                var username = ftpServer.UserName;
                var password = ftpServer.Password;
                var ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host +"/" + remoteFile);
                ftpRequest.Credentials = new NetworkCredential(username, password);
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                var ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                var ftpStream = ftpResponse.GetResponseStream();
                string contentType = "application/" + fileType;
                return File(ftpStream, contentType, fileName);
            }

            catch (Exception ex)
            {
                ViewBag.Message = "File Download failed!!";
                return View();
            }
        }
    }
}