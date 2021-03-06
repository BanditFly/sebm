﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Updater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                File.Delete("sebm.exe");
                downlaodFile("http://s.thatseliyt.de/", "sebm.exe", "sebm.exe");
                MessageBox.Show("Finished Update!", "Finished!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start("sebm.exe");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void downlaodFile(string url, string file, string filename)
        {
            string str = url;
            string address = null;
            WebClient client = new WebClient();
            address = str + file;
            client.DownloadFile(address, filename);
        }
    }
}
