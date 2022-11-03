﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ProcurementTrackingBalilihan.Dal;
using System.IO;

namespace ProcurementTrackingBalilihan
{
    public partial class ChangeConnectionForm : DevExpress.XtraEditors.XtraForm
    {
        public ChangeConnectionForm()
        {
            InitializeComponent();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Testbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(servertxt.Text) && string.IsNullOrEmpty(databasetxt.Text) && string.IsNullOrEmpty(usertxt.Text) && string.IsNullOrEmpty(passwordtxt.Text) && string.IsNullOrEmpty(porttxt.Text))
                MessageBox.Show("Please Complete The Form above!");
            else
            {
                Login.TestConnection(servertxt.Text, databasetxt.Text, usertxt.Text, passwordtxt.Text, porttxt.Text);
                if (Login.TestConnectionSuccessful)
                {
                    MessageBox.Show("Connection is valid.\nPlease save new connection!");
                }
                else
                    MessageBox.Show(Login.TestConnectionError);
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(servertxt.Text) && string.IsNullOrEmpty(databasetxt.Text) && string.IsNullOrEmpty(usertxt.Text) && string.IsNullOrEmpty(passwordtxt.Text) && string.IsNullOrEmpty(porttxt.Text))
                MessageBox.Show("Please Complete The Form above!");
            else {
                if (File.Exists(@"constring.txt"))
                {
                    File.Delete(@"constring.txt");
                }
                File.Create("constring.txt").Dispose();

                using (TextWriter tw = new StreamWriter("constring.txt"))
                {
                    tw.WriteLine("Server = "+servertxt.Text+"; Database= = "+databasetxt.Text+"; Uid="+usertxt.Text+"; Pwd="+passwordtxt.Text+"; Port="+porttxt.Text+"");
                }

                MessageBox.Show("Changes to Connection String Applied\nProgram will close.\n\nPlease Reopen the Program Again");
                Application.Exit();
            }
        }
    }
}