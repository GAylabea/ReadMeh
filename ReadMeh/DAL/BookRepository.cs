using ReadMeh.Controllers;
using ReadMeh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadMeh.DAL
{
    public class BookRepository : IBookRepository
    {
        readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Save(Book newBook)
        {
            _context.Books.Add(newBook);
            _context.SaveChanges();
        }
        public Book GetById(int id)
        {
            return _context.Books.Find(id); // pass the id because it's more reliable than the js
        }

        public IEnumerable<Book> GetAllUsersBooks()
        {
            return _context.Books;
        }
        public IEnumerable<Book> GetAll(string userId)
        {
            return _context.Books.Where(x => userId == x.userId);
        }

        public Book Delete(int id)
        {
            var Book = _context.Books.Find(id);
            _context.Books.Remove(Book);
            _context.SaveChanges();
            return Book;
        }

        public Book Update(int id, Book book)
        {
            var Book = _context.Books.Find(id);
            Book.Author = book.Author;
            Book.Title = book.Title;
            Book.unReview = book.unReview;
            Book.Rating = book.Rating;
            _context.SaveChanges();
            return Book;
        }
    }
}