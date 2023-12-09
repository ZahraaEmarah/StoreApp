using Store.App.helpers;
using Store.Data;
using Store.Domain;
using System.Data.Entity;

namespace Store.App
{
    public partial class Login : Form
    {
        StoreContext context;
        PasswordHasher hasher;
        public Login()
        {
            hasher = new PasswordHasher();
            context = new StoreContext();
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            context.User.Load();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string Username = userNameTextBox.Text;
            string Password = passwordTextBox.Text;
            string hashedPassword = hasher.HashPassword(Password);
            if (!Password.Equals("") && !Username.Equals(""))
            {
                User user = context.User.FirstOrDefault(u => u.Name == Username);
                if (user != null && user.Password.Equals(hashedPassword))
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Wrong Credentials");
                }
            }
            else
            {
                MessageBox.Show("Fields cannot be empty");
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Register f = new Register();
            f.Show();
        }
    }
}