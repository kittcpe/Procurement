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
                    //MySqlCommand cmd = new MySqlCommand("SELECT pl.id,pl.description,pl.`amount`,pl.`added_on`,pl.`status`,sl.`name` FROM `procurement_list` pl INNER JOIN `supplier_list` sl WHERE pl.`supplier` = sl.`id`;", con);
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM procurement_status", con);
                    //  cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    gettrackitemsuccessfull = true;
                    con.Close();
                    return dt.Tables[0];
                }
                catch (Exception ex)
                {
                    gettrackitemerror = ex.Message + "\n Function: Get Procurement";
                    return null;
                }
            }


        }
        public static bool isSaveSuccessfully = false;
        public static string SaveErrorMessage;
        public static void AddSavePurchase(string PRno,string description, string enduser, string mode_of_pr,
                                            float amount, string status, string opening_of_bids, string detailed_bid_eval,
                                            string award, string po, string ntp, string delivery,string purpose, string mode)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {
                    try
                    {
                        con.Open();
                        //
                        if (mode == "Add")
                        {
                            if (status == "Pre-Proc")
                            {
                                MySqlCommand cmd = new MySqlCommand("INSERT INTO `procurement_status`(pr_no, description, end_user, mode_of_pr, abc, pre_proc, opening_of_bids, detailed_bid_eval, award, po, ntp, delivery, purpose) VALUES ('"
                                    + PRno + "','" //varchar
                                    + description + "','" //varchar
                                    + enduser + "','" //varchar
                                    + mode_of_pr + "',"//varchar
                                    + amount + "," //float
                                    + "CURRENT_TIMESTAMP" + ",STR_TO_DATE('" //mysqldate format 
                                    + opening_of_bids + "', '%m/%d/%Y'),STR_TO_DATE('" //date 
                                    + detailed_bid_eval + "', '%m/%d/%Y'),STR_TO_DATE('" //date 
                                    + award + "', '%m/%d/%Y'),STR_TO_DATE('" //date
                                    + po + "', '%m/%d/%Y'),STR_TO_DATE('" //date
                                    + ntp + "', '%m/%d/%Y'),STR_TO_DATE('" //date
                                    + delivery //date
                                    + "', '%m/%d/%Y'),'" + purpose + "')", con);
                                cmd.ExecuteNonQuery();
                                isSaveSuccessfully = true;
                                con.Close();
                            }
                        }
                       else
                        {
                            MySqlCommand cmd = new MySqlCommand("UPDATE `procurement_status` SET" + 
                            "description  = '" +  description + "'," + 
                            "end_user = '" + enduser + "'," + 
                            "mode_of_pr = '" +  mode_of_pr + "'," + 
                            "abc = '" + amount + "'," +
                            "opening_of_bids = STR_TO_DATE('" + opening_of_bids + "', '%m/%d/%Y')," +
                            "detailed_bid_eval = STR_TO_DATE('" + detailed_bid_eval + "', '%m/%d/%Y')," +
                            "award = STR_TO_DATE('" + award + "', '%m/%d/%Y'), " +
                            "po = STR_TO_DATE('" + po + "', '%m/%d/%Y')," +
                            "ntp = STR_TO_DATE('" + ntp + "', '%m/%d/%Y')," +
                            "delivery = STR_TO_DATE('" + delivery + "', '%m/%d/%Y')," +
                            "purpose = " + purpose +
                             "WHERE pr_no ='" + PRno + "' ", con);
                            isSaveSuccessfully = true;

                        }

                    }
           
                    catch (Exception ex)
                    {
                        SaveErrorMessage = ex.Message + "\n Function: Save Purchase";
                    }


            }

        }

        public static bool isUpdateSuccessfully = false;
        public static string UpdateErrorMessage;
        public static void UpdateStatus(string id,string status)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {
                try
                {
                    con.Open();
                    //
                    
                    if (status == "Posting")
                    {
                        MySqlCommand cmd = new MySqlCommand("UPDATE `procurement_status` SET posting = CURRENT_TIMESTAMP  WHERE id ='" + id + "' ", con);
                        cmd.ExecuteNonQuery();
                        isUpdateSuccessfully = true;
                        con.Close();
                    }
                    else
                    {
                        MySqlCommand cmd = new MySqlCommand("UPDATE `procurement_status` SET pre_bid = CURRENT_TIMESTAMP  WHERE id ='" + id + "' ", con);
                        cmd.ExecuteNonQuery();
                        isUpdateSuccessfully = true;
                        con.Close();

                    }
                }
                catch (Exception ex)
                {
                    UpdateErrorMessage = ex.Message + "\n Function: Update Purchase";
                }


            }

        }
        public static bool ItemSaveSuccessfuly = false;
        public static string ItemSaveErrorMessage;
        public static void AddSaveItem(string property_no, string unit, string description, float quantity, float unit_cost, string procurement_no, string mode)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {
                try
                {
                    con.Open();
                    //
                    if (mode == "Add")
                    {

                        MySqlCommand cmd = new MySqlCommand("INSERT INTO purchase_order(property_no,unit,description,quantity,unit_cost,total_cost,procurement_no) VALUES('"
                            + property_no + "','"
                            + unit + "','"
                            + description + "',"
                            + quantity + "," 
                            + unit_cost+ ","
                            + quantity* unit_cost + ",'"
                            + procurement_no + "')"
                            , con);
                            cmd.ExecuteNonQuery();
                            ItemSaveSuccessfuly = true;
                            con.Close();
                        
                    }

                }

                catch (Exception ex)
                {
                    ItemSaveErrorMessage = ex.Message + "\n Function: Save Procurement Item";
                }


            }

        }

        public static string getitemerror;
        public static bool getdetailssuccessfull = false;
        public static DataTable GetItemDetails(string proc_no)
        {

            DataSet dt = new DataSet();
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM purchase_order WHERE procurement_no = '" + proc_no + "';", con);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    getdetailssuccessfull = true;
                    con.Close();
                    return dt.Tables[0];
                }
                catch (Exception ex)
                {
                    getitemerror = ex.Message + "\nFunction: Get Item Details";
                    return null;
                }
            }


        }
        public static bool isDeletedSuccessfully = false;
        public static string DeleteErrorMessage;
        public static void DeleteItem(string id)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE `purchase_order` WHERE procurement_no ='" + id + "' ", con);
                    cmd.ExecuteNonQuery();
                    isUpdateSuccessfully = true;
                    con.Close();
                }
                catch (Exception ex)
                {
                    UpdateErrorMessage = ex.Message + "\n Function: Delete Item";
                }


            }

        }


        

    }
}
