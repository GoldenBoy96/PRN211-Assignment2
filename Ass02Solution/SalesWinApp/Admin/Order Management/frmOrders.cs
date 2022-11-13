using SalesWinApp.Admin.Order_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmOrders : Form
    {
        public string tmpEmail { get; set; }

        public frmOrders()
        {
            InitializeComponent();
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmReadOrder frmReadOrder = new()
                {
                    tmpEmail = tmpEmail
                };
                this.Hide();
                frmReadOrder.Show();
            }
            else
            {
                frmReadOrder frmReadOrder = new();
                this.Hide();
                frmReadOrder.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmUpdateOrder frmUpdateOrder = new()
                {
                    tmpEmail = tmpEmail
                };
                this.Hide();
                frmUpdateOrder.Show();
            }
            else
            {
                frmUpdateOrder frmUpdateOrder = new();
                this.Hide();
                frmUpdateOrder.Show();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmAddOrder frmAddOrder = new()
                {
                    tmpEmail = tmpEmail
                };
                this.Hide();
                frmAddOrder.Show();
            }
            else
            {
                frmAddOrder frmAddOrder = new();
                this.Hide();
                frmAddOrder.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmOrders_Load(object sender, EventArgs e)
        {

        }

        private void frmOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tmpEmail != null)
            {
                frmMain frmMain = new()
                {
                    tmpEmail = tmpEmail
                };
                frmMain.Show();
            }
            else
            {
                frmMain frmMain = new();
                frmMain.Show();
            }
        }
    }
}
