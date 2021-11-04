using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS
{
    // step 13 access modifier
    public class Loan
    {
        // step 14
        private int id;

        // step 15
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        // ??? we should write CLASS NAME and then proporty name you can see in UML diagramm
        public User Borrower { get; set; }
        public Book BorrowedBook { get; set; }
        public DateTime DateTaken { get; set; }
        public DateTime ReturnedDate { get; set; }
    }
}
