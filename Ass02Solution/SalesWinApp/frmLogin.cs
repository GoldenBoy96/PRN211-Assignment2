using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository _memberRepository;

        public string tmpEmail { get; set; }

        public frmLogin()
        {
            InitializeComponent();
            _memberRepository = new MemberRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == String.Empty || txtEmail.Text == "")
            {
                MessageBox.Show("All fields are required!");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("All fields are required!");
            }
            else
            {
                var member = _memberRepository.GetMembers()
                    .Where(x => x.Email == txtEmail.Text && x.Password == txtPassword.Text)
                    .FirstOrDefault();

                if (member is not null)
                {
                    tmpEmail = txtEmail.Text;

                    if (member.Email.Equals("admin@fstore.com"))
                    {
                        if (tmpEmail != null)
                        {
                            frmMain frmMain = new()
                            {
                                txtEmail = tmpEmail
                            };
                            this.Hide();
                            frmMain.Show();
                        }
                        else {
                            frmMain frmMain = new();
                            this.Hide();
                            frmMain.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not available yet bruh!");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                txtEmail.Text = tmpEmail;
            }
        }
    }
}