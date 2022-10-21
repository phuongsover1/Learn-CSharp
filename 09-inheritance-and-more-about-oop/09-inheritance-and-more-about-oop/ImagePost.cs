using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_inheritance_and_more_about_oop
{
    // ImagePost derives from Post and adds a property (ImageURL) and two constructors.
    class ImagePost : Post
    {
        public string ImageURL  { get;set; }

        public ImagePost()
        {
            ImageURL = "";
        }

        public ImagePost(string title, bool isPublic, string sendByUsername, string imageURL):base(title,isPublic,sendByUsername)
        {
            ID = GetNextID();
            ImageURL = imageURL;
        }
        public override string ToString()
        {
            return String.Format("{0}. More details in {1}", base.ToString(), ImageURL); ;
        }
    }
}
