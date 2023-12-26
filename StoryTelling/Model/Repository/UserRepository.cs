using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using RestSharp;

using StoryTelling.Model.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static StoryTelling.Model.Entity.User;

namespace StoryTelling.Model.Repository
{
    public class UserRepository
    {
        string baseUrl = "https://dodevca.com/storytelling/";

        private static string FormatToRupiah(decimal amount)
        {
            CultureInfo cultureInfo = new CultureInfo("id-ID");

            return amount.ToString("C", cultureInfo);
        }
        public bool IsValidUser(string username, string password)
        {
            string endpoint     = "auth";
            var client          = new RestClient(baseUrl);
            var request         = new RestRequest(endpoint, Method.POST);

            request.AddParameter("username", username);
            request.AddParameter("password", password);

            var response    = client.Execute<ApiResponse>(request);
            var apiResponse = response.Data;

            if (apiResponse.Status == 200)
            {
                User.Id = apiResponse.Response.Id;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Register(string username, string email, string password)
        {
            string endpoint = "register";
            var client      = new RestClient(baseUrl);
            var request     = new RestRequest(endpoint, Method.POST);

            request.AddParameter("username", username);
            request.AddParameter("email", email);
            request.AddParameter("password", password);

            var response = client.Execute<ApiResponse>(request);
            var apiResponse = response.Data;

            if (apiResponse.Status == 200)
            {
                User.Id = apiResponse.Response.Id;

                return true;
            }
            else
            {
                return false;
            }
        }

        public UserDetail GetUserDetail()
        {
            string endpoint = "user/" + User.Id;
            var client      = new RestClient(baseUrl);
            var request     = new RestRequest(endpoint, Method.GET);
            var response    = client.Execute<UserDetail>(request);
            var apiResponse = response.Data;

            return apiResponse;
        }

        public UserBalance GetUserBalance()
        {
            string endpoint     = "balance/" + User.Id;
            var client          = new RestClient(baseUrl);
            var request         = new RestRequest(endpoint, Method.GET);
            var response        = client.Execute<UserBalance>(request);
            var apiResponse     = response.Data;
            apiResponse.Now     = FormatToRupiah(decimal.Parse(apiResponse.Now));
            apiResponse.Total   = FormatToRupiah(decimal.Parse(apiResponse.Total));

            return apiResponse;
        }

        public UserReport GetUserReport()
        {
            string endpoint = "report/" + User.Id;
            var client      = new RestClient(baseUrl);
            var request     = new RestRequest(endpoint, Method.GET);
            var response    = client.Execute<UserReport>(request);
            var apiResponse = response.Data;

            return apiResponse;
        }

        public string UpdatePayment(string payment)
        {
            string endpoint = "newpayment/" + User.Id;
            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.POST);
            
            request.AddParameter("payment", payment);

            var response = client.Execute(request);
            var apiResponse = response.Content;

            return apiResponse;
        }

        public List<Post> GetUserList()
        {
            List<Post> list = new List<Post>();

            string endpoint = "latest/" + User.Id;
            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);
            var response = client.Execute<List<Post>>(request);
            list = response.Data;

            return list;
        }

        public List<Post> SearchUserPost(string query)
        {
            List<Post> list = new List<Post>();

            string endpoint = "search/" + User.Id;
            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);
            
            request.AddParameter("query", query);

            var response = client.Execute<List<Post>>(request);
            list = response.Data;

            return list;
        }
        public Post GetUserPost(string id)
        {
            string endpoint = "post/" + User.Id;
            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);

            request.AddParameter("id", id);

            var response = client.Execute<Post>(request);
            var apiResponse = response.Data;

            return apiResponse;
        }

        public bool CreateUserPost(string title, string description, string content)
        {
            string endpoint = "newpost/" + User.Id;
            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.POST);

            request.AddParameter("title", title);
            request.AddParameter("description", description);
            request.AddParameter("content", content);

            var response = client.Execute<PostResponse>(request);
            var apiResponse = response.Data;

            if (apiResponse.Status == 200)
                return true;
            else
                return false;
        }

        public bool Payout()
        {
            string endpoint = "payout/" + User.Id;
            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.POST);
            var response = client.Execute<UserBalance>(request);
            var apiResponse = response.Data;

            if (apiResponse.Total != "0")
                return true;
            else
                return false;
        }

        public List<Payout> PayoutList(string sort)
        {
            string endpoint = "payoutlist/" + User.Id;
            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);

            request.AddParameter("sort", sort);

            var response = client.Execute<List<Payout>>(request);
            var apiResponse = response.Data;
            
            for (int i = 0; i < apiResponse.Count; i++)
            {
                apiResponse[i].Amount = FormatToRupiah(decimal.Parse(apiResponse[i].Amount));
            }

            return apiResponse;
        }
    }
}
