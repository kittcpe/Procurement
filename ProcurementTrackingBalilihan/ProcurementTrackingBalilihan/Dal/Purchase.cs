using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProcurementTrackingBalilihan.Core;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProcurementTrackingBalilihan.Dal
{
    class Purchase
    {
        private static string ConnectionString()
        {
            return PublicVariables.ServerConnectionString;
        }

        public static string gettrackitemerror = null;
        public static bool gettrackitemsuccessfull = false;
        public static DataTable GetTrackItem()
        {

            DataSet dt = new DataSet();
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT pl.description,pl.`amount`,pl.`added_on`,pl.`status`,sl.`name` FROM `procurement_list` pl INNER JOIN `supplier_list` sl WHERE pl.`supplier` = sl.`id`;", con);
                    //  cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    return dt.Tables[0];
                }
                catch (Exception ex)
                {
                    gettrackitemerror = ex.Message + "\n Function: Get Supplier";
                    return null;
                }
            }


        }
    }
}
