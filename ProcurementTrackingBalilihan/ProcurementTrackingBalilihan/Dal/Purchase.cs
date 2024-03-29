﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProcurementTrackingBalilihan.Core;
using System.Data;
using MySql.Data.MySqlClient;
using ProcurementTrackingBalilihan.Core;

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
                    //MySqlCommand cmd = new MySqlCommand("SELECT id, pr_no, description, end_user, mode_of_pr, abc, pre_proc, posting, pre_bid, DATE(opening_of_bids) AS opening_of_bids, DATE(detailed_bid_eval) AS detailed_bid_eval, DATE(award) AS award, DATE(po) AS po, DATE(ntp) AS ntp, DATE(delivery) AS delivery, purpose FROM procurement_status", con);
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM procurement_status ORDER BY id ASC", con);
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
                                    + opening_of_bids + "', '%d/%m/%Y'),STR_TO_DATE('" //date 
                                    + detailed_bid_eval + "', '%d/%m/%Y'),STR_TO_DATE('" //date 
                                    + award + "', '%d/%m/%Y'),STR_TO_DATE('" //date
                                    + po + "', '%d/%m/%Y'),STR_TO_DATE('" //date
                                    + ntp + "', '%d/%m/%Y'),STR_TO_DATE('" //date
                                    + delivery //date
                                    + "', '%d/%m/%Y'),'" + purpose + "')", con);
                                cmd.ExecuteNonQuery();
                                isSaveSuccessfully = true;
                                con.Close();
                            }
                            else if (status == "Posting")
                            {
                                MySqlCommand cmd = new MySqlCommand("INSERT INTO `procurement_status`(pr_no, description, end_user, mode_of_pr, abc, posting, opening_of_bids, detailed_bid_eval, award, po, ntp, delivery, purpose) VALUES ('"
                                   + PRno + "','" //varchar
                                   + description + "','" //varchar
                                   + enduser + "','" //varchar
                                   + mode_of_pr + "',"//varchar
                                   + amount + "," //float
                                   + "CURRENT_TIMESTAMP" + ",STR_TO_DATE('" //mysqldate format 
                                   + opening_of_bids + "', '%d/%m/%Y'),STR_TO_DATE('" //date 
                                   + detailed_bid_eval + "', '%d/%m/%Y'),STR_TO_DATE('" //date 
                                   + award + "', '%d/%m/%Y'),STR_TO_DATE('" //date
                                   + po + "', '%d/%m/%Y'),STR_TO_DATE('" //date
                                   + ntp + "', '%d/%m/%Y'),STR_TO_DATE('" //date
                                   + delivery //date
                                   + "', '%d/%m/%Y'),'" + purpose + "')", con);
                                cmd.ExecuteNonQuery();
                                isSaveSuccessfully = true;
                                con.Close();
                            }
                            else
                            {
                                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `procurement_status`(pr_no, description, end_user, mode_of_pr, abc, pre_bid, opening_of_bids, detailed_bid_eval, award, po, ntp, delivery, purpose) VALUES ('"
                                   + PRno + "','" //varchar
                                   + description + "','" //varchar
                                   + enduser + "','" //varchar
                                   + mode_of_pr + "',"//varchar
                                   + amount + "," //float
                                   + "CURRENT_TIMESTAMP" + ",STR_TO_DATE('" //mysqldate format 
                                   + opening_of_bids + "', '%d/%m/%Y'),STR_TO_DATE('" //date 
                                   + detailed_bid_eval + "', '%d/%m/%Y'),STR_TO_DATE('" //date 
                                   + award + "', '%d/%m/%Y'),STR_TO_DATE('" //date
                                   + po + "', '%d/%m/%Y'),STR_TO_DATE('" //date
                                   + ntp + "', '%d/%m/%Y'),STR_TO_DATE('" //date
                                   + delivery //date
                                   + "', '%d/%m/%Y'),'" + purpose + "')", con);
                                    cmd.ExecuteNonQuery();
                                    isSaveSuccessfully = true;
                                    con.Close();
                            
                            }
                        }
                       else
                        {
                            MySqlCommand cmd = new MySqlCommand("UPDATE `procurement_status` SET " + 
                            "description  = '" +  description + "'," + 
                            "end_user = '" + enduser + "'," + 
                            "mode_of_pr = '" +  mode_of_pr + "'," + 
                            "abc = '" + amount + "'," +
                            "opening_of_bids = STR_TO_DATE('" + opening_of_bids + "', '%d/%m/%Y')," +
                            "detailed_bid_eval = STR_TO_DATE('" + detailed_bid_eval + "', '%d/%m/%Y')," +
                            "award = STR_TO_DATE('" + award + "', '%d/%m/%Y'), " +
                            "po = STR_TO_DATE('" + po + "', '%d/%m/%Y')," +
                            "ntp = STR_TO_DATE('" + ntp + "', '%d/%m/%Y')," +
                            "delivery = STR_TO_DATE('" + delivery + "', '%d/%m/%Y')," +
                            "purpose = '" + purpose +
                             "' WHERE pr_no ='" + PRno + "'", con);
                            cmd.ExecuteNonQuery();
                            isSaveSuccessfully = true;
                            con.Close();

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
        public static void UpdateStatus(string id,string status, string date)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {
                try
                {
                    con.Open();
                    //
                    
                    if (status == "Posting")
                    {
                        MySqlCommand cmd = new MySqlCommand("UPDATE `procurement_status` SET posting = STR_TO_DATE('" + date + "', '%d/%m/%Y')  WHERE pr_no ='" + id + "' ", con);
                        cmd.ExecuteNonQuery();
                        isUpdateSuccessfully = true;
                        con.Close();
                    }
                    else if (status == "Pre-Bidding")
                    {
                        MySqlCommand cmd = new MySqlCommand("UPDATE `procurement_status` SET pre_bid = STR_TO_DATE('" + date + "', '%d/%m/%Y')  WHERE pr_no ='" + id + "' ", con);
                        cmd.ExecuteNonQuery();
                        isUpdateSuccessfully = true;
                        con.Close();

                    }
                    else
                    {
                        MySqlCommand cmd = new MySqlCommand("UPDATE `procurement_status` SET pre_proc = STR_TO_DATE('" + date + "', '%d/%m/%Y')  WHERE pr_no ='" + id + "' ", con);
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
        public static void AddSaveItem(string property_no, string unit, string description, float quantity, float unit_cost, string procurement_no,string supplier, string mode)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {
                try
                {
                    con.Open();
                    //
                    if (mode == "Add")
                    {

                        MySqlCommand cmd = new MySqlCommand("INSERT INTO purchase_order(property_no,unit,description,quantity,unit_cost,total_cost,procurement_no,supplier) VALUES('"
                            + property_no + "','"
                            + unit + "','"
                            + description + "',"
                            + quantity + "," 
                            + unit_cost+ ","
                            + quantity* unit_cost + ",'"
                            + procurement_no + "','"
                            + supplier +"')"
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
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM `purchase_order` WHERE property_no ='" + id + "';", con);
                    cmd.ExecuteNonQuery();
                    isDeletedSuccessfully = true;
                    con.Close();
                }
                catch (Exception ex)
                {
                    DeleteErrorMessage = ex.Message + "\n Function: Delete Item";
                }
            }
        }

        public static bool DeleteRecordSuccessful = false;
        public static string DeleteRecordErrorMessage;
        public static void DeleteRecord(string id)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString()))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM `procurement_status` WHERE pr_no ='" + id + "';", con);
                    cmd.ExecuteNonQuery();
                    MySqlCommand cmd1 = new MySqlCommand("DELETE FROM `purchase_order` WHERE procurement_no ='" + id + "';", con);
                    cmd1.ExecuteNonQuery();
                    DeleteRecordSuccessful = true;
                    con.Close();
                }
                catch (Exception ex)
                {
                    DeleteRecordErrorMessage = ex.Message + "\n Function: Delete Item";
                }
            }
        }
    }
}
