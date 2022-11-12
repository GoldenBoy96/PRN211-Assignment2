﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp.Normal_User
{
    public partial class frmUserOrders : Form
    {
        public frmUserOrders()
        {
            InitializeComponent();
        }

        public string tmpEmail { get; set; }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserOrders_Load(object sender, EventArgs e)
        {

        }

        private void frmUserOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tmpEmail != null)
            {
                frmUserMain frmUserMain = new()
                {
                    tmpEmail = tmpEmail
                };
                frmUserMain.Show();
            }
            else
            {
                frmUserMain frmUserMain = new();
                frmUserMain.Show();
            }
        }
    }
}
