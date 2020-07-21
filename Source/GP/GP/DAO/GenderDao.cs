using GP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GP.DAO
{
    public class GenderDao
    {
        public List<Gender> GetAllGender()
        {
            try
            {
                SqlCommand scom = new SqlCommand("SELECT * FROM tblGender", DbConnector.Connect());
                scom.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                List<Gender> lstGender = new List<Gender>();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Gender gender = new Gender();
                    gender.GenderID = Convert.ToInt32(ds.Tables[0].Rows[i]["Gender_Id"]);
                    gender.GenderCode = Convert.ToString(ds.Tables[0].Rows[i]["Gender_Code"]);
                    gender.GenderName = Convert.ToString(ds.Tables[0].Rows[i]["Gender_Name"]);

                    lstGender.Add(gender);
                }
                return lstGender;
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;

        }
    }
}
