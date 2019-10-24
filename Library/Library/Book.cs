using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{

    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; }
        public Book(string title, Author author, Genre genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
        }
    }
    public enum Genre
    {
        Action = 1,
        Novel,
        ScienceFiction,
        Philosophy,
        Fantasy,
        Horror,
        Thriller,
        Other
    }

}