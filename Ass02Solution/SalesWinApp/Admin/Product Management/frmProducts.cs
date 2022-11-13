using SalesWinApp.Admin.Product_Management;
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
    public partial class frmProducts : Form
    {
        public string tmpEmail { get; set; }

        public frmProducts()
        {
            InitializeComponent();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmReadProduct frmReadProduct = new()
                {
                    tmpEmail = tmpEmail
                };
                this.Hide();
                frmReadProduct.Show();
            }
            else
            {
                frmReadProduct frmReadProduct = new();
                this.Hide();
                frmReadProduct.Show();
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
                frmUpdateProduct frmUpdateProduct = new()
                {
                    tmpEmail = tmpEmail
                };
                this.Hide();
                frmUpdateProduct.Show();
            }
            else
            {
                frmUpdateProduct frmUpdateProduct = new();
                this.Hide();
                frmUpdateProduct.Show();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmAddProduct frmAddProduct = new()
                {
                    tmpEmail = tmpEmail
                };
                this.Hide();
                frmAddProduct.Show();
            }
            else
            {
                frmAddProduct frmAddProduct = new();
                this.Hide();
                frmAddProduct.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            txtSearchCatagory.SelectedIndex = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void frmProducts_FormClosing(object sender, FormClosingEventArgs e)
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
