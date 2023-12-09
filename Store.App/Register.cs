using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Store.App.helpers;
using Store.Data;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.App
{
    public partial class Register : Form
    {
        StoreContext context;
        Encryptor encryptor;
        public Register()
        {
            encryptor= new Encryptor();
            context = new StoreContext();
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            context.User.Load();
        }

        private bool Validate_Password(string password, string confirm_password)
        {
            return !password.Equals("") && !confirm_password.Equals("") && confirm_password.Equals(password);
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (Validate_Password(passwordTextBox.Text, confirmPasswordTextBox.Text))
            {
                User NewUser = new()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = userNameTextBox.Text,
                    Email = emailTextBox.Text,
                    Password = encryptor.Hash_Password(passwordTextBox.Text),
                    IsActive = true
                };
                context.Add(NewUser);
                context.SaveChanges();
                MessageBox.Show("Registeration Success");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Password");
            }
        }
    }
}
