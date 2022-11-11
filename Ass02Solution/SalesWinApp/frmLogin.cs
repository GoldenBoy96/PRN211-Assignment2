using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository _memberRepository;

        public frmLogin()
        {
            InitializeComponent();
            _memberRepository = new MemberRepository();
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == String.Empty || txtEmail.Text == "")
            {
                MessageBox.Show("Please input email!");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please input Password");
            }
            else
            {
                var member = _memberRepository.GetMembers()
                    .Where(x => x.Email == txtEmail.Text && x.Password == txtPassword.Text)
                    .FirstOrDefault();

                if (member is not null)
                {
                    if (member.Email.Equals("admin@fstore.com"))
                    {

                        frmMain frmMain = new();
                        this.Hide();
                        frmMain.Show();

                    }
                    else
                    {
                        MessageBox.Show("You are not allowed to access this function!");
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

        }
    }
}