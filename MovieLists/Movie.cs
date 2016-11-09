using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLists
{
    class Movie
    {
        private string Title;
        private string Category;
        //properties of the class field
        public string TITLE
        {
            get
            {
                return Title;
            }

            set
            {
                Title = value;
            }
        }
        //properties of the class field
        public string CATEGORY
        {
            get
            {
                return Category;
            }

            set
            {
                Category = value;
            }
        }
        //Makes a class constructor for the field
        public Movie(string title, string category)
        {
            this.Title = title;
            this.Category = category;
        }
    }
}
