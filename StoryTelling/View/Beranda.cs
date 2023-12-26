using StoryTelling.Controller;
using StoryTelling.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

using static StoryTelling.Model.Entity.User;

namespace StoryTelling.View
{
    public partial class Beranda : Form
    {
        private UserDetail user             = new UserDetail();
        private UserBalance balances        = new UserBalance();
        private UserReport report           = new UserReport();
        private UserController controller   = new UserController();

        public Beranda()
        {
            InitializeComponent();

            loadData();
        }

        public void loadData()
        {
            payment.Clear();
            balance.Clear();
            total.Clear();
            post.Clear();
            view.Clear();

            user            = controller.GetUserDetails();
            balances        = controller.GetUserBalance();
            report          = controller.GetUserReport();
            greeting.Text   = "Hi, " + user.Username;
            payment.Text    = user.Payment;
            balance.Text    = balances.Now;
            total.Text      = balances.Total;
            post.Text       = report.Total;
            view.Text       = report.View;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string prevPayment = payment.Text;
            UserController controller = new UserController();
            string newPayment = controller.UpdatePayment(prevPayment);

            if (prevPayment != newPayment)
            {
                loadData();
            }
        }

        private void showListBtn_Click(object sender, EventArgs e)
        {
            List list = new List();

            list.ShowDialog();
        }

        private void Beranda_Load(object sender, EventArgs e)
        {

        }

        private void payout_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();
            bool payout = controller.Payout();

            if (payout)
            {
                loadData();
            }
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            ReportPayout report = new ReportPayout();

            report.ShowDialog();
        }
    }
}
