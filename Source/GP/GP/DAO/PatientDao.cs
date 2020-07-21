using GP.CONSTANT;
using GP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GP.DAO
{
    public class PatientDao
    {
        public int Create(Patient patient)
        {
            try
            {
                SqlCommand scom = new SqlCommand(ProcedureConstants.SP_AddNewPatientWithFTP, DbConnector.Connect());
                scom.CommandType = CommandType.StoredProcedure;
                scom.Parameters.AddWithValue("@Patient_Code", patient.PatientCode);
                scom.Parameters.AddWithValue("@Patient_Name", patient.PatientName);
                scom.Parameters.AddWithValue("@DOB", patient.DOB);
                scom.Parameters.AddWithValue("@GenderID", patient.GenderID);
                scom.Parameters.AddWithValue("@Address", patient.Address);
                //scom.Parameters.AddWithValue("@FileID", patient.FileID);

                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                if (ds == null || ds.Tables.Count != 1 || ds.Tables[0].Rows.Count != 1 || ds.Tables[0].Rows[0][0].ToString() == "1")
                {
                    return 1;
                }

                else if (ds.Tables[0].Rows[0][0].ToString() == "2")
                {
                    return 2;
                }

                else

                    return 0;

            }
            catch (Exception ex)
            {
                return 1;
            }
            return 1;

        }

        public int EditPatient(Patient patient)
        {
            try
            {
                SqlCommand scom = new SqlCommand(ProcedureConstants.Sp_EditPatient, DbConnector.Connect());
                scom.CommandType = CommandType.StoredProcedure;
                scom.Parameters.AddWithValue("@Patient_Id", patient.PatientID);
                scom.Parameters.AddWithValue("@Patient_Code", patient.PatientCode);
                scom.Parameters.AddWithValue("@Patient_Name", patient.PatientName);
                scom.Parameters.AddWithValue("@DOB", patient.DOB);
                scom.Parameters.AddWithValue("@GenderID", patient.GenderID);
                scom.Parameters.AddWithValue("@Address", patient.Address);
                scom.Parameters.AddWithValue("@FileID", patient.FileID);

                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                if (ds == null || ds.Tables.Count != 1 || ds.Tables[0].Rows.Count != 1 || ds.Tables[0].Rows[0][0].ToString() == "1")
                {
                    return 1;
                }

                else if (ds.Tables[0].Rows[0][0].ToString() == "2")
                {
                    return 2;
                }

                else

                    return 0;

            }
            catch (Exception ex)
            {
                return 1;
            }
            return 1;

        }

        public List<Patient> GetAllPatient()
        {
            try
            {
                SqlCommand scom = new SqlCommand("SELECT * FROM VW_GetAllPatient", DbConnector.Connect());
                scom.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                List<Patient> lstPatient = new List<Patient>();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Patient patient = new Patient();
                    patient.PatientID = Convert.ToInt32(ds.Tables[0].Rows[i]["Patient_Id"]);
                    patient.PatientCode = Convert.ToString(ds.Tables[0].Rows[i]["Patient_Code"]);
                    patient.PatientName = Convert.ToString(ds.Tables[0].Rows[i]["Patient_Name"]);
                    patient.GenderID = Convert.ToInt32(ds.Tables[0].Rows[i]["GenderID"]);
                    patient.GenderName = Convert.ToString(ds.Tables[0].Rows[i]["Gender_Name"]);
                    if (ds.Tables[0].Rows[i]["DateOfBirth"] != DBNull.Value)
                    {
                        patient.DOB = Convert.ToDateTime(ds.Tables[0].Rows[i]["DateOfBirth"]);
                    }
                    patient.Address = Convert.ToString(ds.Tables[0].Rows[i]["Address"]);
                    if (ds.Tables[0].Rows[i]["FileID"] != DBNull.Value)
                    {
                        patient.FileID = Convert.ToInt32(ds.Tables[0].Rows[i]["FileID"]);
                    }
                    patient.FileName = Convert.ToString(ds.Tables[0].Rows[i]["FileName"]);
                    patient.FilePath = Convert.ToString(ds.Tables[0].Rows[i]["FilePath"]);
                    lstPatient.Add(patient);
                }
                return lstPatient;
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;

        }

        public ReturnMessage Import(List<Patient> lstPatient)
        {
            try
            {
                SqlCommand scom = new SqlCommand("", DbConnector.Connect());
                scom.CommandType = CommandType.StoredProcedure;

                ListToDataTable lsttodt = new ListToDataTable();
                DataTable dtPatient = lsttodt.ToDataTable(lstPatient);
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(DbConnector.Connect()))
                {
                    bulkCopy.ColumnMappings.Add("PatientCode", "Patient_Code");
                    bulkCopy.ColumnMappings.Add("PatientName", "Patient_Name");
                    bulkCopy.ColumnMappings.Add("GenderID", "GenderID");
                    bulkCopy.ColumnMappings.Add("Address", "Address");
                    bulkCopy.ColumnMappings.Add("Created_By", "Created_By");
                    bulkCopy.ColumnMappings.Add("Created_On", "Created_On");
                    bulkCopy.ColumnMappings.Add("Modified_By", "Modified_By");
                    bulkCopy.ColumnMappings.Add("Modified_On", "Modified_On");
                    bulkCopy.ColumnMappings.Add("Active", "Active");
                    bulkCopy.DestinationTableName = "tblPatient";
                    bulkCopy.WriteToServer(dtPatient);
                }
                return new ReturnMessage() { RetCode = 1, RetMessage = "Success!" };

            }
            catch (Exception ex)
            {
                return new ReturnMessage() { RetCode = 0, RetMessage = ex.Message };
            }
            return new ReturnMessage() { RetCode = 0, RetMessage = "Unknown error in estimate plan creating!" };
        }
    }
}
