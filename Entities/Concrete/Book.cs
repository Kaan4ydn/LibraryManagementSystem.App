using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ISBN { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public DateTime PublishedDate { get; set; }
        public Member BorrowedBy { get; set; }

        public DateTime BorrowDate { get; set; }

        private DateTime _dueDate;

        public DateTime DueDate
        {
            get { return _dueDate; }
            set { _dueDate = value; } // Teslim tarihinin, ödünç alma tarihine 14 gün eklenerek bu şekilde set edilmesi planlanmıştır.
        }

        public Status BookStatus { get; set; } = Status.Available;

        public enum Status
        {
            Available,
            OnLoan
        }
    }
}
