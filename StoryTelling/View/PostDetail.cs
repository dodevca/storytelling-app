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

using static StoryTelling.Model.Entity.User;

namespace StoryTelling.View
{
    public partial class PostDetail : Form
    {
        private UserController controller = new UserController();
        Post post = new Post();

        public PostDetail(string postId)
        {
            InitializeComponent();
            loadData(postId);
        }

        public void loadData(string postId)
        {
            content.Clear();
            date.Clear();
            view.Clear();

            post = controller.GetUserPost(postId);
            title.Text = post.Title;
            content.Text = post.Content;
            view.Text = post.View + " pembaca";
            date.Text = post.Date;
        }
    }
}
