using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS
{
    // step 7 access modifier
    public class User
    {
        private int id;

        // step 8
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        // step 9
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DoB { get; set; }
        public string PassportNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        // step 19 adding BooksCurrentlyOnLoan list 
        public List<Loan> BooksCurrentlyOnLoan { get; set; }
    }
}
