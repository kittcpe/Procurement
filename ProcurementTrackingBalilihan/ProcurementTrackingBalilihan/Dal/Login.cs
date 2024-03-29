﻿using System;
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
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM `user` WHERE `username` = '"+ Username+"' && `password` = PASSWORD('"+Password+"');", con);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    GetUserDataSuccessful=true;
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        PublicVariables.UserPrivilege = dt.Tables[0].Rows[0]["role"].ToString();
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

        public static string TestConnectionError = string.Empty;
        public static bool TestConnectionSuccessful = false;
        public static void TestConnection(string server,string db, string uid, string password, string port)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection("Server = " + server +"; Database = "+ db +"; Uid = " + uid + "; Pwd = " + password + "; Port = " + port + ";"))
                {
                    con.Open();
                    TestConnectionSuccessful = true;
                }
            }
            catch (Exception ex)
            {
                TestConnectionError = ex.Message;
            }
        }

    }
}
