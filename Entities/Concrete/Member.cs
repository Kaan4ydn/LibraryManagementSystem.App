using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Member : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public int MemberId { get; set; }

        private int _memberPoints = 100; // Üyelik oluşturulduğunda üyeye atanıcak sabit puan.

        public int MemberPoints
        {
            get { return _memberPoints; }
            set { _memberPoints = value; }
        }

        public Book BorrowedBook { get; set; }
        public DateTime BorrowDate { get; set; }
        public bool CanBorrowBook { get; set; } = true;
    }
}
