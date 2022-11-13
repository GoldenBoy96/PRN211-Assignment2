using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp.Admin.Product_Management
{
    public partial class frmAddProduct : Form
    {
        public string tmpEmail { get; set; }

        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tmpEmail != null)
            {
                frmProducts frmProducts = new()
                {
                    tmpEmail = tmpEmail
                };
                frmProducts.Show();
            }
            else
            {
                frmProducts frmProducts = new();
                frmProducts.Show();
            }
        }
    }
}
