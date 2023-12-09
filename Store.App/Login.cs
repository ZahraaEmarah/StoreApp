namespace Store.App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Register f = new Register();
            f.Show();
        }
    }
}