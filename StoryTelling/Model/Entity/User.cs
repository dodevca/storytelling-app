using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTelling.Model.Entity
{
    public class User
    {
        public static string Id { get; set; }

        public class ApiResponse
        {
            public int Status { get; set; }
            public string Message { get; set; }
            public UserResponse Response { get; set; }
        }

        public class UserResponse
        {
            public string Id { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
        }

        public class UserDetail
        {
            public string Id { get; set; }
            public string Username { get; set; }
            public string Payment { get; set; }
        }

        public class UserBalance
        {
            public string Now { get; set; }
            public string Total { get; set; }
        }

        public class UserReport
        {
            public string Total { get; set; }
            public string View { get; set; }
        }

        public class Post
        {
            public string Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Content { get; set; }
            public string View { get; set; }
            public string Date { get; set; }
        }

        public class PostResponse
        {
            public int Status { get; set; }
            public string Message { get; set; }
            public Post Response { get; set; }
        }

        public class Payout
        {
            public string Amount { get; set; }
            public string Date { get; set; }
        }
    }
}
