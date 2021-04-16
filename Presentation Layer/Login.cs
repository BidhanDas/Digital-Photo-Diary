using Digital_Photo_Diary.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Photo_Diary.Presentation_Layer
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

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            LoginService loginService = new LoginService();
            int result = loginService.LoginValidation(usernameTextBox.Text, passwordTextBox.Text);
            if (result == 1)
            {
                User1 u1 = new User1();
                this.Hide();
                u1.Show();
            }
            else if (result == 2)
            {
                Form2 manageProduct = new Form2();
                this.Hide();
                manageProduct.Show();
                ;
            }
            else if (result == 3)
            {
                Form3 manageCategory = new Form3();
                this.Hide();
                manageCategory.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
                usernameTextBox.Text = passwordTextBox.Text = string.Empty;
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
