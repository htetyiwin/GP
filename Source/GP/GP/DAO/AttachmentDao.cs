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
    public class AttachmentDao
    {
        public ReturnMessage Create(Attachments attachments)
        {
            try
            {
                SqlCommand scom = new SqlCommand(ProcedureConstants.SP_InsertAttachments, DbConnector.Connect());
                scom.CommandType = CommandType.StoredProcedure;

                scom.Parameters.AddWithValue("@FileCode", attachments.FileCode);
                scom.Parameters.AddWithValue("@FileName", attachments.FileName);
                scom.Parameters.AddWithValue("@FileType", attachments.FileType);
                scom.Parameters.AddWithValue("@UserId", attachments.AttachedBy);

                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                if (ds == null || ds.Tables.Count != 1 || ds.Tables[0].Rows.Count != 1 || Convert.ToInt32(ds.Tables[0].Rows[0][0]) < 0)
                {
                    return new ReturnMessage() { RetCode = 0, RetMessage = "Unknown error!" };
                }
                else if (Convert.ToInt32(ds.Tables[0].Rows[0][0]) < 0)
                {
                    return new ReturnMessage() { RetCode = 0, RetMessage = Convert.ToString(ds.Tables[0].Rows[0][1]) };
                }
                else
                {
                    return new ReturnMessage() { RetCode = Convert.ToInt32(ds.Tables[0].Rows[0][0]), RetMessage = Convert.ToString(ds.Tables[0].Rows[0][1]) };
                }
            }
            catch (Exception ex)
            {
                return new ReturnMessage() { RetCode = 0, RetMessage = ex.Message };
            }
            return new ReturnMessage() { RetCode = 0, RetMessage = "Unknown error in attachments inserting!" };
        }

        public void Delete(Attachments attachments)
        {
            SqlCommand scom = new SqlCommand("DELETE FROM Tmp.TblAttachments WHERE Id=" + attachments.Id + " AND FileCode='" + attachments.FileCode + "' AND AttachedBy =" + attachments.AttachedBy, DbConnector.Connect());
            scom.CommandType = CommandType.Text;
            scom.ExecuteNonQuery();
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
