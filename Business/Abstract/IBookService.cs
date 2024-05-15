using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetAll();
        Book GetById(int id);
        List<Book> GetBooksByCategoryId(int categoryInt);
        List<Book> GetBooksByAuthorName(string authorName);
        void Add(Book book);
        void Delete(Book book);
        void Update(Book book);
    }
}
