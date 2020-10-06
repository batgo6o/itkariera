using System;
using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> Books;
        public Library(params Book[] books)
        {
            Books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator() => new LibraryNumerator(Books);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public class LibraryNumerator : IEnumerator<Book>
        {
            private readonly List<Book> lib;
            int count;

            public LibraryNumerator(List<Book> Lib)
            {
                Reset();
                lib = Lib;
            }

            public Book Current => lib[count];

            object IEnumerator.Current => Current;

            public void Dispose(){}

            public bool MoveNext() => ++count < lib.Count;

            public void Reset() => count = -1;
        }
    }
}