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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public string txtEmail { get; set; }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnMemberManagement_Click(object sender, EventArgs e)
        {
            frmMembers frmMembers = new frmMembers();
            frmMembers.Show();
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (txtEmail != null)
            {
                frmLogin frmLogin = new()
                {
                    tmpEmail = txtEmail
                };
                this.Hide();
                frmLogin.Show();
            }
            else
            {
                frmLogin frmLogin = new();
                this.Hide();
                frmLogin.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
