using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProcurementTrackingBalilihan.Core;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProcurementTrackingBalilihan.Dal
{
    public class Login
    {
        public static bool isConnection = false;
        public static void TryConnection()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    isConnection = true;
                }
            }
            catch (Exception ex)
            {
                errormessage = ex.Message;
            }
        }

         public static string errormessage = string.Empty;
        private static string ConnectionString()
        {
            return PublicVariables.ServerConnectionString;
        }

                public static string GetUserDataError = string.Empty;
        public static bool GetUserDataSuccessful = false;

        public static DataTable GetLogin(string Username, string Password)
        {
            //Thread.Sleep(2000);
            DataSet dt = new DataSet();
            try {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_user_login", con);//sakto ba ni?
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("_username", Username));
                    cmd.Parameters.Add(new MySqlParameter("_password", Password));
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    GetUserDataSuccessful=true;
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        return dt.Tables[0];
                    }
                    else
                    {
                        return null;
                    }
                }
            } 
            catch (Exception ex)

            {
                GetUserDataError = ex.Message + "\n Function:  Login";
                return null;
            }
        }

    }
}
