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

namespace StoryTelling.View
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();

            login.ShowDialog();
        }

        private void register_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();

            bool register = controller.Register(username.Text, email.Text, password.Text);

            if(register)
            {
                this.Hide();

                Beranda beranda = new Beranda();

                beranda.ShowDialog();
            }
        }
    }
}
