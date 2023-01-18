using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProcurementTrackingBalilihan.Core;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProcurementTrackingBalilihan.Dal
{
   public class Supplier
    {

        private static string ConnectionString()
        {
            return PublicVariables.ServerConnectionString;
        }

        public static bool getsupplierlistsuccessful = false;
        public static string errormessage;
        public static DataTable GetSupplierList()
        {

            DataSet dt = new DataSet();
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM supplier_list", con);
                  //  cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    getsupplierlistsuccessful = true;
                    con.Close();
                    return dt.Tables[0];
                }
                catch (Exception ex) {
                    errormessage = ex.Message + "\n Function: Get Supplier";
                    return null; }
            }


        }
        public static bool isSaveSuccessfully = false;
        public static string SaveErrorMessage;
        public static void AddSaveSupplier(string Name, string Address, int procs)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {
                if (procs == 0) // add new
                {
                    try
                    {
                        con.Open();
                        //
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO supplier_list (name, address) VALUES ('" + Name + "','" + Address + "')", con);    
                        cmd.ExecuteNonQuery();
                        isSaveSuccessfully = true;
                        con.Close();
                    }
                    catch (Exception ex) {
                        SaveErrorMessage = ex.Message + "\n Function: Save Supplier";
                    }
                }
                else
                {
                    try
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand("UPDATE supplier_list SET `name` = '" + Name + "', address = '" + Address + "' WHERE id  =" + procs, con);
                        cmd.ExecuteNonQuery();
                        isSaveSuccessfully = true;
                        con.Close();
                    }
                    catch (Exception ex) {SaveErrorMessage = ex.Message + "\n Function: Save Supplier"; }
                }
            }
        }
        public static bool isDeleted = false;
        public static string DeleteErrorMessage;
        public static void DeleteSupplier(string Name)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {

                    try
                    {
                        con.Open();
                        //
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM supplier_list WHERE `name` = '" + Name + "'", con);
                        cmd.ExecuteNonQuery();
                        isDeleted = true;
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        DeleteErrorMessage = ex.Message + "\n Function: Delete Supplier";
                    }
            }
        }

    }
}
