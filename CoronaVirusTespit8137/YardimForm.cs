﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaVirusTespit8137
{
    public partial class YardimForm : Form
    {
        private object process;

        public YardimForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
                Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "https://saglik.gov.tr");
        }
    }
}
