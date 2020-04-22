using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    //derives from Post and adds a property ImageURL and two constructors
    class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost(){}

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.ImageURL = imageURL;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} URL: {3} - by {2}", this.ID, this.Title, this.SendByUsername, this.ImageURL);
        }
    }
}
