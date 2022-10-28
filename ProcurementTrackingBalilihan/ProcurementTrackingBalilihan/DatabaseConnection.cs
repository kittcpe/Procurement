using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProcurementTrackingBalilihan
{
    class DatabaseConnection
    {
        public virtual string UserName { get; set; }

        public MySqlConnection getConnection()
        {
            using (MySqlConnection con = new MySqlConnection("datasource=192.168.13.39;database=bisu_procurement_tracking;uid=bisu_procurement;pwd=bisu_procurement"))
            {
                try
                {
                    con.Open();
                    return con;
                }
                catch
                {
                    return null;
                }
            }
        }
        public MySqlDataReader getThatLogin(string user, string password)
        {
            using (getConnection())
            {
                try
                {
                    MySqlConnection con = getConnection();
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_user_login", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("_username", user));
                    cmd.Parameters.Add(new MySqlParameter("_password", password));

                    MySqlDataReader read = null;
                    read = cmd.ExecuteReader();
                    //UserName = read["name"].ToString();
                    if (read.Read()) { return read; }
                    else { return null; }
                    
                }
                catch { return null; }
            }
        }


    }
}
