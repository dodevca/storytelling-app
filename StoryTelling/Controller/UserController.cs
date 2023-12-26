using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Web.UI.WebControls;
using System.Windows.Forms;

using StoryTelling.Model.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static StoryTelling.Model.Entity.User;

namespace StoryTelling.Controller
{
    internal class UserController
    {
        private UserRepository _repository;

        public bool IsValidUser(string username, string password)
        {
            if(string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username tidak boleh kosong!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if(string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password tidak boleh kosong!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            _repository = new UserRepository();
            bool valid  = _repository.IsValidUser(username, password);

            if(!valid)
            {
                MessageBox.Show("Username atau password tidak ditemukan!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }

        public bool Register(string username, string email, string password)
        {
            if(string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username tidak boleh kosong!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if(string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email tidak boleh kosong!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if(string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password tidak boleh kosong!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            _repository     = new UserRepository();
            bool register   = _repository.Register(username, email, password);
            
            if (!register)
            {
                MessageBox.Show("Gagal membuat akun!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }

        public UserDetail GetUserDetails()
        {
            _repository             = new UserRepository();
            UserDetail userDetail   = _repository.GetUserDetail();

            return userDetail;
        }

        public UserBalance GetUserBalance()
        {
            _repository             = new UserRepository();
            UserBalance userBalance = _repository.GetUserBalance();

            return userBalance;
        }

        public UserReport GetUserReport()
        {
            _repository             = new UserRepository();
            UserReport UserReport   = _repository.GetUserReport();

            return UserReport;
        }

        public string UpdatePayment(string payment)
        {
            if (string.IsNullOrEmpty(payment))
            {
                MessageBox.Show("Rekening tidak boleh kosong!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return payment;
            }

            _repository = new UserRepository();
            string newPayment = _repository.UpdatePayment(payment);

            if (newPayment == payment)
            {
                MessageBox.Show("Gagal mengubah rekening!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return payment;
            }
            else
            {
                MessageBox.Show("Berhasil mengubah rekening.", "Berhasil",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                return newPayment;
            }
        }

        public List<Post> GetUserLatest()
        {
            List<Post> list = new List<Post>();

            _repository = new UserRepository();
            list = _repository.GetUserList();

            return list;
        }

        public List<Post> SearchUserPost(string query)
        {
            List<Post> list = new List<Post>();
            _repository = new UserRepository();
            list = _repository.SearchUserPost(query);

            return list;
        }

        public Post GetUserPost(string id)
        {
            Post post = new Post();
            _repository = new UserRepository();
            post = _repository.GetUserPost(id);

            return post;
        }

        public bool CreateUserPost(string title, string description, string content)
        {
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Judul tidak boleh kosong!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Deskripsi tidak boleh kosong!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Isi artikel tidak boleh kosong!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            _repository = new UserRepository();
            bool uploaded = _repository.CreateUserPost(title, description, content);

            if (!uploaded)
            {
                MessageBox.Show("Gagal membuat artikel baru!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }
            else
            {
                MessageBox.Show("Berhasil membuat artikel baru.", "Berhasil",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
        }

        public bool Payout()
        {
            _repository = new UserRepository();
            UserBalance userBalance = _repository.GetUserBalance();

            if (userBalance.Now != "Rp0,00")
            {
                bool payout = _repository.Payout();

                if (!payout)
                {
                    MessageBox.Show("Gagal menarik saldo, pastikan saldo tidak kosong.", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return false;
                }
                else
                {
                    MessageBox.Show("Berhasil menarik saldo. Saldo akan segera dikirim ke rekening anda.", "Berhasil",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
            } 
            else
            {
                MessageBox.Show("Gagal menarik saldo, pastikan saldo tidak kosong.", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }
        }

        public List<Payout> PayoutList(string sort)
        {
            List<Payout> list = new List<Payout>();
            _repository = new UserRepository();
            list = _repository.PayoutList(sort);

            return list;
        }
    }
}
