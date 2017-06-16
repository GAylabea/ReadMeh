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
        public Book Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Books.ToList();
        }

        public void Delete(Book book)
        {
            throw new NotImplementedException();
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}