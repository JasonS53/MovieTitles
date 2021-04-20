using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList
{
    class Movie
    {
        //fields
        private string _title;
        private string _category;
        
        //properties
        public string Title
        { 
        get { return _title; }
        set { this._title = value; }
        }

        public string Category
        {
            get { return _category; }
            set { this._title = value; }
        }

        //constructor
        public Movie (string title, string category)
        {
            this._title = title;
            this._category = category;
        }
    } 
}
