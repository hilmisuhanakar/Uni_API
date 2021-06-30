using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class UniSummary
    {

        public UniSummary(int Id, string UniName , string City , string Img , string Slug)
        {
            this.Id = Id;
            this.UniName = UniName;
            this.City = City;
            this.Img = Img;
            this.Slug = Slug;
        }


        public int Id { get; set; }
        public string UniName { get; set; }
        public string City { get; set; }
        public string Img { get; set; }
        public string Slug { get; set; }
    }
}
