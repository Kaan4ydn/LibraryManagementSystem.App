using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILibraryService
    {
        public void BorrowBook(int memberId, int bookId); // Kitap ödünç alma işlemini yapıcak olan metot.
        public void GiveBackBook(int memberId, int bookId); // Ödünç alınan kitabı geri verme işlemini yapıcak metot.
        public List<Book> GetBorrowedBooks(); // Sistemdeki ödünç alınmış kitapları listeleme işlemini yapıcak metot.
        public List<Book> GetAvailableBooks(); // Sistemdeki ödünç alınmamış, ödünç almaya uygun kitapları listeleme işlemini yapıcak metot.
        public List<Member> GetBorrowers(); // Sistemdeki ödünç kitap almış kullanıcıları listeleme işlemini yapıcak metot.
    }
}
