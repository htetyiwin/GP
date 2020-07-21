using GP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GP.DAO
{
    public class FtpServerDao
    {
        public List<FtpServer> GetAllFtpServerList()
        {
            try
            {
                SqlCommand scom = new SqlCommand("SELECT * FROM [dbo].[TblFTPServer]", DbConnector.Connect());
                scom.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(scom);
                da.Fill(ds);
                List<FtpServer> lstFtpServer = new List<FtpServer>();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    FtpServer ftpServer = new FtpServer();
                    ftpServer.Id = Convert.ToInt32(ds.Tables[0].Rows[i]["Id"]);
                    ftpServer.ServerAddress = Convert.ToString(ds.Tables[0].Rows[i]["ServerAddress"]);
                    ftpServer.UserName = Convert.ToString(ds.Tables[0].Rows[i]["UserName"]);
                    ftpServer.Password = Convert.ToString(ds.Tables[0].Rows[i]["Password"]);
                    ftpServer.CreatedBy = Convert.ToInt32(ds.Tables[0].Rows[i]["CreatedBy"]);
                    ftpServer.CreatedOn = Convert.ToDateTime(ds.Tables[0].Rows[i]["CreatedOn"]);
                    ftpServer.ModifiedBy = Convert.ToInt32(ds.Tables[0].Rows[i]["ModifiedBy"]);
                    ftpServer.ModifiedOn = Convert.ToDateTime(ds.Tables[0].Rows[i]["ModifiedOn"]);
                    ftpServer.Active = Convert.ToBoolean(ds.Tables[0].Rows[i]["Active"]);
                    lstFtpServer.Add(ftpServer);

                }

                return lstFtpServer;
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;
        }

        public List<Attachments> GetAllTmpAttachmentsByIssueId(int issueId)
        {
            try
            {
                SqlCommand scom = new SqlCommand("SELECT * FROM Tmp.TblAttachments WHERE IssueId = " + issueId + " AND IsSaved =" + 1, DbConnector.Connect());
                scom.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                List<Attachments> lstAttachments = new List<Attachments>();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Attachments attachment = new Attachments();
                    attachment.Id = Convert.ToInt32(ds.Tables[0].Rows[i]["Id"]);
                    attachment.FileCode = Convert.ToString(ds.Tables[0].Rows[i]["FileCode"]);
                    attachment.FileName = Convert.ToString(ds.Tables[0].Rows[i]["FileName"]);
                    attachment.FileType = Convert.ToString(ds.Tables[0].Rows[i]["FileType"]);
                    attachment.IsSaved = Convert.ToBoolean(ds.Tables[0].Rows[i]["IsSaved"]);
                    attachment.IssueId = Convert.ToInt32(ds.Tables[0].Rows[i]["IssueId"]);
                    attachment.AttachedBy = Convert.ToInt32(ds.Tables[0].Rows[i]["AttachedBy"]);
                    attachment.AttachedOn = Convert.ToDateTime(ds.Tables[0].Rows[i]["AttachedOn"]);

                    lstAttachments.Add(attachment);
                }
                return lstAttachments;
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;

        }
    }
}
