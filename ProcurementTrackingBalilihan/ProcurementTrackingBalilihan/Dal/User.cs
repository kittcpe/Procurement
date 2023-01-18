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

        public static bool isaddedsuccesfully = false;
        public static string isaddederrormerssage;
        public static void adduser(string name, string username, string password)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO user (name, username, password,role) VALUES('" + name + "','" + username + "',PASSWORD('" + password + "'),'User')", con);
                    cmd.ExecuteNonQuery();
                    isaddedsuccesfully = true;
                    con.Close();
                }
                catch (Exception ex)
                {
                    isaddederrormerssage = ex.Message + "\n Function: Add User";
                }
            }
        }

        public static bool iseditedsuccesfully = false;
        public static string editerrormerssage;
        public static void edituser(string id, string name, string username, string password)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE user SET name = '" + name + "', username = '" + username + "', password = PASSWORD('" + password + "') WHERE id = '" + id + "'", con);
                    cmd.ExecuteNonQuery();
                    iseditedsuccesfully = true;
                    con.Close();
                }
                catch (Exception ex)
                {
                    editerrormerssage = ex.Message + "\n Function: Edit User";
                }
            }
        }

        public static bool isUserDeleted = false;
        public static string DeleteErrorMessage;
        public static void DeleteUser(string ID)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM user WHERE `id` = '" + ID + "'", con);
                    cmd.ExecuteNonQuery();
                    isUserDeleted = true;
                    con.Close();
                }
                catch (Exception ex)
                {
                    DeleteErrorMessage = ex.Message + "\n Function: Delete User";
                }
            }
        }
    }
}
