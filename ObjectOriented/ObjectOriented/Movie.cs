using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    internal class Movie
    {
        public String title;
        public String director;
        private String rating;

        public Movie (String atitle , String adirector , String arating)
        {
            title = atitle;
            director = adirector;
            Rating = arating;
        }

        public string Rating
        {
            get { return rating; }
            set { 
                if (value =="G" || value =="PG" || value =="PG-13" || value == "R")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
