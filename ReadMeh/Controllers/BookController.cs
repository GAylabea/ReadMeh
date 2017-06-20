using Microsoft.AspNet.Identity;
using ReadMeh.DAL;
using ReadMeh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace ReadMeh.Controllers
{
    public class BookController : ApiController
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpPost]
        [Route("api/book")]

        public void AddBook(Book newBook)
        {
            newBook.userId = User.Identity.GetUserId();
            _bookRepository.Save(newBook);
        }

        [HttpGet]
        [Route("api/list")]
        public IEnumerable<Book> GetAll()
        {
            var userId = User.Identity.GetUserId();
            return _bookRepository.GetAll(userId);
        }

        [HttpGet]
        [Route("api/get/{id}")] // don't forget to set the parameter! we need to ask for a SPECIFIC id
        public Book GetById(int id)
        {
            return _bookRepository.GetById(id);        
        }

        [HttpPut]
        [Route("api/put/{id}")]
        public Book Update(int id, Book book)
        {
            return _bookRepository.Update(id, book);
        }

        [HttpDelete]
        [Route("api/delete/{id}")]
        public Book Delete(int id)
        {
            return _bookRepository.Delete(id);
        }
    }
}