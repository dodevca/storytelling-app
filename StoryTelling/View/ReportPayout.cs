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
    public partial class ReportPayout : Form
    {
        private UserController controller = new UserController();

        public ReportPayout()
        {
            InitializeComponent();
            InisialisasiListView();
            loadData("DESC");
        }
        private void InisialisasiListView()
        {
            listPayout.View = System.Windows.Forms.View.Details;
            listPayout.FullRowSelect = true;
            listPayout.GridLines = true;

            listPayout.Columns.Add("Jumlah", 400, HorizontalAlignment.Left);
            listPayout.Columns.Add("Tanggal", 458, HorizontalAlignment.Left);
        }

        public void loadData(string sort)
        {
            listPayout.Items.Clear();

            List<Payout> list = new List<Payout>();
            list = controller.PayoutList(sort);

            if (list != null)
            {
                foreach (var payout in list)
                {
                    var item = new ListViewItem(payout.Amount);
                    item.SubItems.Add(payout.Date);

                    listPayout.Items.Add(item);
                }
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if (sortDesc.Checked || sortAsc.Checked)
            {
                string sort = sortDesc.Checked ? "DESC" : "ASC";
                loadData(sort);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            loadData("DESC");
        }
    }
}
