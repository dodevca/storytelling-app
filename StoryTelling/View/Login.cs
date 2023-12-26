using StoryTelling.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryTelling.View;

namespace StoryTelling.View
{
    public partial class Login : Form
    {
        private ListBox listBox1;
        private TextBox username;
        private TextBox password;
        private Button loginBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button signupBtn;

        public Login()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();

            bool isValidUser = controller.IsValidUser(username.Text, password.Text);
            if (isValidUser)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            Signup signup = new Signup();
            
            signup.ShowDialog();
        }
    }
}
