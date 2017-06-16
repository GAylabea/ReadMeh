using ReadMeh.DAL;
using ReadMeh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            _bookRepository.Save(newBook);
        }

        [HttpGet]
        [Route("api/list")]
        public IEnumerable<Book>  GetAll()
        {
            return _bookRepository.GetAll();
        }
    }
}