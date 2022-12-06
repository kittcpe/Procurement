using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProcurementTrackingBalilihan.Core;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProcurementTrackingBalilihan.Dal
{
    class Reports
    {
        private static string ConnectionString()
        {
            return PublicVariables.ServerConnectionString;
        }

        public static string loadreporterror;
        public static bool loadreportsuccessful = false;
        public static DataTable loadreport(string _pr_no)
        {
            DataSet dt = new DataSet();
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM `purchase_order` po INNER JOIN `procurement_status` ps ON ps.`pr_no` = po.`procurement_no`WHERE ps.`pr_no`='" + _pr_no + "'", con);
                    //  cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    loadreportsuccessful = true;
                    return dt.Tables[0];
                }
                catch (Exception ex)
                {
                    loadreporterror = ex.Message + "\n Function: Get Supplier";
                    return null;
                }
            }
        }

        public static string purposestringerror;
        public static bool purposestringsuccessful = false;
        public static DataTable purposestring(string _pr_no)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT purpose,end_user FROM `procurement_status` WHERE pr_no='"+_pr_no+"'", con);
                    //  cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    purposestringsuccessful = true;
                    return dt;
                }
                catch (Exception ex)
                {
                    purposestringerror = ex.Message + "\n Function: Get Supplier";
                    return null;
                }
            }
        }


    }
}
