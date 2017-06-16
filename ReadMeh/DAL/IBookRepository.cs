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
        Book Get(int id);
        void Delete(Book book);
        void Update(Book book);
        IEnumerable<Book> GetAll();

    }
}
