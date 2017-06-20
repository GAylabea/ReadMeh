using ReadMeh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadMeh.Controllers
{
    public interface IBookRepository
    {
        void Save(Book book);
        Book GetById(int id);
        Book Delete(int id);
        Book Update(int id, Book book);
        IEnumerable<Book> GetAll(string userId);

    }
}
