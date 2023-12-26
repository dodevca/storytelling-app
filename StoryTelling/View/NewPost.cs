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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StoryTelling.View
{
    public partial class NewPost : Form
    {
        public NewPost()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();
            bool uploaded = controller.CreateUserPost(title.Text, description.Text, content.Text);

            if (uploaded)
            {
                this.Hide();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
