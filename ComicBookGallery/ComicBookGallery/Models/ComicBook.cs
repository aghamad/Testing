using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHTML { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }

        // Read Only / There's no setter
        public string DisplayText {
            get {
                return SeriesTitle + " #" + IssueNumber;
            }
        }

        // How an image file is: series-title-issuenumber.jpg
        public string CoverImageFileName {
            get {
                return SeriesTitle.Replace(" ", "-").ToLower() 
                    + "-" + IssueNumber + ".jpg";
            }
        }


    }
}