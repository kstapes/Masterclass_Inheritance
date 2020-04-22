using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Post
    {
        private static int currentPostId;

        //properties
        protected int ID { get; set; }
        public string Title { get; set; }
        public string SendByUsername { get; set; }
        public bool IsPublic { get; set; }

        //default constructor if a derived class does not invoke a base class-
        //constructor explicitly the default constructor is called implicitly

        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Kevin";
        }

        //Instance constructor that has 3 parameters

        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        protected int GetNextId()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}
