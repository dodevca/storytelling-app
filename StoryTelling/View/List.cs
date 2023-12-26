using StoryTelling.Controller;
using StoryTelling.Model.Entity;
using System;
using System.Collections;
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
    public partial class List : Form
    {
        private UserController controller = new UserController();

        public List()
        {
            InitializeComponent();
            InisialisasiListView();
            loadData();

            listPost.SelectedIndexChanged += listPost_SelectedIndexChanged;
        }
        
        private void InisialisasiListView()
        {
            listPost.View = System.Windows.Forms.View.Details;
            listPost.FullRowSelect = true;
            listPost.GridLines = true;

            listPost.Columns.Add("Judul", 210, HorizontalAlignment.Left);
            listPost.Columns.Add("Deskripsi", 250, HorizontalAlignment.Left);
            listPost.Columns.Add("Pembaca", 80, HorizontalAlignment.Center);
            listPost.Columns.Add("Tanggal", 100, HorizontalAlignment.Center);
            listPost.Columns.Add("", 0, HorizontalAlignment.Center);
        }

        public void loadData()
        {
            listPost.Items.Clear();
            
            List<Post> list = new List<Post>();
            list = controller.GetUserLatest();

            if (list != null)
            {
                foreach (var post in list)
                {
                    var item = new ListViewItem(post.Title);
                    item.SubItems.Add(post.Description);
                    item.SubItems.Add(post.View);
                    item.SubItems.Add(post.Date);
                    item.SubItems.Add(post.Id);

                    listPost.Items.Add(item);
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            listPost.Items.Clear();

            string q = query.Text;
            List<Post> list = new List<Post>();
            list = controller.SearchUserPost(q);

            if(list != null)
            {
                foreach(var post in list)
                {
                    var item = new ListViewItem(post.Title);
                    item.SubItems.Add(post.Description);
                    item.SubItems.Add(post.View);
                    item.SubItems.Add(post.Date);
                    item.SubItems.Add(post.Id);

                    listPost.Items.Add(item);
                }
            }
        }

        private void listPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listPost.SelectedItems.Count > 0)
            {
                string selectedPostId = listPost.SelectedItems[0].SubItems[4].Text;

                PostDetail postDetails = new PostDetail(selectedPostId);
                postDetails.ShowDialog();
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            query.Text = "";

            loadData();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            NewPost newPost = new NewPost();

            newPost.ShowDialog();
        }
    }
}
