using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{



    // امکان پیاده سازی خود IEnumerable<> نیز هست
	class Book
	{
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        
    }


    interface ICollectionIterator
    {
        bool HasNext();

        Book Next();
    }

    interface IBookCollection
    {
        ICollectionIterator GetIterator();
    }

    class BookCollection : IBookCollection
    {
        private List<Book> _books = new();

        public ICollectionIterator GetIterator()
        {
            return new BooksIterator(this);
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public int Count () => _books.Count;

        public Book this[int index] => _books[index];
    }

    class BooksIterator : ICollectionIterator
    {
        private BookCollection _collection;
        private int _currentIndex = 0;
        public BooksIterator(BookCollection bookCollection)
        {
            _collection = bookCollection;
        }

        public bool HasNext()
        {
            return _currentIndex < _collection.Count();
        }

        public Book Next()
        {
            return _collection[++_currentIndex];
        }
    }
}
