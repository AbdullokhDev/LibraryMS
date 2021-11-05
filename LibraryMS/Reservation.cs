using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS
{
    // step 10
    public class Reservation
    {
        // step 11
        private int id;

        // step 12
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime ReservationDate { get; set; }
        // ??? we should write CLASS NAME and then proporty name you can see in UML diagramm
        public Book ReservedBook { get; set; }
        public User User { get; set; }
        public int ReservationDuration { get; set; }

        // step 19 we call enum then proporty name is Status
        public ReservationStatus ReservationStatus { get; set; }

        // method
        public bool IsActive()
        {
            if (this.ReservationStatus == ReservationStatus.Active)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void FullfillReservation()
        {
            this.ReservationStatus = ReservationStatus.Fullfilled;
        }
    }

    // step 18
    public enum ReservationStatus
    {
        // contantans
        Active,
        Expired,
        Fullfilled
    }
}
