using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp.Admin.Order_Management
{
    public partial class frmReadOrder : Form
    {
        public string tmpEmail { get; set; }

        public frmReadOrder()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReadOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tmpEmail != null)
            {
                frmOrders frmOrders = new()
                {
                    tmpEmail = tmpEmail
                };
                frmOrders.Show();
            }
            else
            {
                frmOrders frmOrders = new();
                frmOrders.Show();
            }
        }
    }
}
