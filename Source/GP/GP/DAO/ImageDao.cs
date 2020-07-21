using GP.CONSTANT;
using GP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GP.DAO
{
    public class ImageDao
    {
        public int Create(ImageFile image)
        {
            try
            {
                SqlCommand scom = new SqlCommand(ProcedureConstants.Sp_AddImageFile, DbConnector.Connect());
                scom.CommandType = CommandType.StoredProcedure;
                scom.Parameters.AddWithValue("@FileName", image.FileName);
                scom.Parameters.AddWithValue("@FilePath", image.FilePath);

                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                if (ds == null || ds.Tables.Count != 1 || ds.Tables[0].Rows.Count != 1 || ds.Tables[0].Rows[0][0].ToString() == "1")
                {
                    return 1;
                }
               
                else

                    return Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());

            }
            catch (Exception ex)
            {
                return 1;
            }
            return 1;

        }


        public int EditFile(ImageFile image)
        {
            try
            {
                SqlCommand scom = new SqlCommand(ProcedureConstants.Sp_EditImageFile, DbConnector.Connect());
                scom.CommandType = CommandType.StoredProcedure;
                scom.Parameters.AddWithValue("@FileID", image.FileID);
                scom.Parameters.AddWithValue("@FileName", image.FileName);
                scom.Parameters.AddWithValue("@FilePath", image.FilePath);

                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                if (ds == null || ds.Tables.Count != 1 || ds.Tables[0].Rows.Count != 1 || ds.Tables[0].Rows[0][0].ToString() == "0")
                {
                    return 0;
                }

                else

                    return Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());

            }
            catch (Exception ex)
            {
                return 0;
            }
            return 0;

        }
        public int GetAllImageFile()
        {
            try
            {
                SqlCommand scom = new SqlCommand("SELECT TOP(1) * From tblImageFile Order By FileID DESC", DbConnector.Connect());
                scom.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
              
                int FileID = Convert.ToInt32(ds.Tables[0].Rows[0]["FileID"]);
                    
                return FileID;
            }
            catch (Exception ex)
            {
                return 0;
            }
         

        }
    }
}
