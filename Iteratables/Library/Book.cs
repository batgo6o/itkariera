using System;
using System.Collections.Generic;

namespace Library
{
    public class Book : IComparable<Book>
    {
        public string Title { get; private set; }
        public int Year { get; private set; }
        public IReadOnlyList<string> Authors { get; private set; }
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = new List<string>(authors);
        }

        public int CompareTo(Book otherBook)
        {
            var result = Year.CompareTo(otherBook.Title);
            if (result == 0)
            {
                result = Title.CompareTo(otherBook.Title);
            }
            return result;
        }
        
        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
}