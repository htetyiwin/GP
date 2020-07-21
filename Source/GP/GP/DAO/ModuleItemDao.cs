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
    public class ModuleItemDao
    {
        public List<ModuleItem> GetAllModuleItem()
        {
            try
            {
                SqlCommand scom = new SqlCommand("SELECT * FROM dbo.TblModuleItem", DbConnector.Connect());
                scom.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                List<ModuleItem> lstModuleItem = new List<ModuleItem>();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ModuleItem moduleItem = new ModuleItem();
                    moduleItem.Id = Convert.ToInt32(ds.Tables[0].Rows[i]["Id"]);
                    moduleItem.Code = Convert.ToString(ds.Tables[0].Rows[i]["Code"]);
                    moduleItem.Name = Convert.ToString(ds.Tables[0].Rows[i]["Name"]);
                    moduleItem.Active = Convert.ToBoolean(ds.Tables[0].Rows[i]["Active"]);
                    moduleItem.ModuleId = Convert.ToInt32(ds.Tables[0].Rows[i]["ModuleId"]);
                    lstModuleItem.Add(moduleItem);
                }
                return lstModuleItem;
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;

        }


        public List<ModuleItem> GetModuleItemByRoleId(int roleId)
        {
            try
            {
                //  SqlCommand scom = new SqlCommand("SELECT * FROM Common.TblModuleItem", DbConnector.Connect());
                SqlCommand scom = new SqlCommand(ProcedureConstants.Sp_GetModuleItemByRoleId, DbConnector.Connect());
                scom.CommandType = CommandType.StoredProcedure;
                scom.Parameters.AddWithValue("@RoleId", roleId);
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                List<ModuleItem> lstModuleItem = new List<ModuleItem>();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ModuleItem moduleItem = new ModuleItem();
                    moduleItem.Id = Convert.ToInt32(ds.Tables[0].Rows[i]["Id"]);
                    moduleItem.Code = Convert.ToString(ds.Tables[0].Rows[i]["Code"]);
                    moduleItem.Name = Convert.ToString(ds.Tables[0].Rows[i]["Name"]);
                    moduleItem.Active = Convert.ToBoolean(ds.Tables[0].Rows[i]["Active"]);
                    moduleItem.ModuleId = Convert.ToInt32(ds.Tables[0].Rows[i]["ModuleId"]);
                    moduleItem.Allowed = Convert.ToBoolean(ds.Tables[0].Rows[i]["Allowed"]);
                    moduleItem.ModuleName = Convert.ToString(ds.Tables[0].Rows[i]["ModuleName"]);
                    lstModuleItem.Add(moduleItem);
                }
                return lstModuleItem;
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;

        }


        public List<ModuleItem> GetAllModuleItemWithModuleName()
        {
            try
            {
                SqlCommand scom = new SqlCommand("SELECT * FROM Common.VW_ModuleItemWithModuleName", DbConnector.Connect());
                scom.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                List<ModuleItem> lstModuleItem = new List<ModuleItem>();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ModuleItem moduleItem = new ModuleItem();
                    moduleItem.Id = Convert.ToInt32(ds.Tables[0].Rows[i]["Id"]);
                    moduleItem.Code = Convert.ToString(ds.Tables[0].Rows[i]["Code"]);
                    moduleItem.Name = Convert.ToString(ds.Tables[0].Rows[i]["Name"]);
                    moduleItem.Active = Convert.ToBoolean(ds.Tables[0].Rows[i]["Active"]);
                    moduleItem.ModuleId = Convert.ToInt32(ds.Tables[0].Rows[i]["ModuleId"]);
                    moduleItem.ModuleName = Convert.ToString(ds.Tables[0].Rows[i]["ModuleName"]);
                    lstModuleItem.Add(moduleItem);
                }
                return lstModuleItem;
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;

        }
    }
}
