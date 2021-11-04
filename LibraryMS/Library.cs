using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS
{
    // step 16 making public class {access modifier}
    public class Library
    {
        // it does not need id beacuse libray should have only one no more library
        
        // we are doing relationship between Book class and Library class <> inside this sign i should indicate class name
        // one to many relationship here GateWayClass

        // step 17
        public List<Book> Books { get; set; }
        public List<Reservation> Reservations { get; set; }
        public List<User> Users { get; set; }
        public List<Loan> Loans { get; set; }
    }
}
