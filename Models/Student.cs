using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
        public string Concentration { get; set; }
        public int Year { get; set; }
        public string FavoriteFood { get; set; }
        public string FavoriteSong { get; set; }
        public string Hometown { get; set; }
    }
}
