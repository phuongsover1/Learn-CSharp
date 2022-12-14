using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_inheritance_and_more_about_oop
{
    internal class Post
    {
        private static int currentPostId;
         
        // properties
        protected int ID { get; set; }
        protected string Title { get; set; }

        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        // Default constructor. If a derived class does not invoke
        // a base-class constructor explicitly, the default constructor is called
        // implicitly.
        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Denis Panjuta";
        }

        // Instance constructor that has three parameters
        public Post(string title, bool isPublic, string sendByUsername)
        {
            ID = GetNextID();
            Title = title;
            IsPublic = isPublic;
            SendByUsername = sendByUsername;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername); 
        }

        public static void Run()
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Denis Panjuta");
            Console.WriteLine(post1.ToString());
            ImagePost imagePost1 = new ImagePost("Check out my new shoes",true ,"denis Panjuta", "https://images.com/shoes");
            Console.WriteLine(imagePost1.ToString());
        }
    }
}
