using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProcurementTrackingBalilihan.Core;
using System.Data;
using MySql.Data.MySqlClient;


namespace ProcurementTrackingBalilihan.Dal
{
    class User
    {

        private static string ConnectionString()
        {
            return PublicVariables.ServerConnectionString;
        }

        public static bool getuserlistsuccessful = false;
        public static string getuserlisterrormessage;
        public static DataTable GetUserList()
        {

            DataSet dt = new DataSet();
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM user", con);
                    //  cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    getuserlistsuccessful = true;
                    con.Close();
                    return dt.Tables[0];
                }
                catch (Exception ex)
                {
                    getuserlisterrormessage = ex.Message + "\n Function: Get User";
                    return null;
                }
            }


        }
    }
}
