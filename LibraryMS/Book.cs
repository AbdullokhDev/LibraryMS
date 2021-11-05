using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS
{
    public class Book
    {
        // step 2
        private int id;
        // encapsulated is started VARIABLE called "id" is started lower case while PROPORTY is started with upper case
        // now this is proporty is started with upper case

        // step 3
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        // step 4
        // this also proporty but we do not need variable because it does not have private variable!!!
        public string Title { get; set; }
        public DateTime YearPublished { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public string Category { get; set; }
 

        // step 6
        public BookStatus BookStatus { get; set; }

        // step 18 adding Authors list 
        public List<string> Authors { get; set; }
    }
    // step 5

    // creating enum this is collection of values

    public enum BookStatus
    {
        Available,
        Reserved,
        OnLoan
    }
}
