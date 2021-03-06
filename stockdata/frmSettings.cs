﻿using stockdata.utils;
using System;
using System.Windows.Forms;

namespace stockdata
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();

            txtServer.Text = Configure.server;
            chkHttpEncrypt.Checked = Configure.httpEncrypt;
            txtApiVersion.Text = Configure.apiVersion;
            txtApiKey.Text = Configure.apiKey;
            txtApiSecret.Text = Configure.apiSecret;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // save settings
            Configure.server = txtServer.Text;
            Configure.httpEncrypt = chkHttpEncrypt.Checked;
            Configure.apiVersion = txtApiVersion.Text;
            Configure.apiKey = txtApiKey.Text;
            Configure.apiSecret = txtApiSecret.Text;

            MessageBox.Show("설정을 저장했습니다.", "Settings");
            this.Close();
        }
    }
}
