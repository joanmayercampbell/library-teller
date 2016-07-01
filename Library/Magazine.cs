using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Magazine:Media
    {
        // set the rental length to 3 weeks
        public override int RentalLength
        {
            get
            {
                return 21;
            }
            set
            {
            }
        }


        public Magazine()
        {
            RentedDate = DateTime.Today;
        }

        // print out the magazine record in blue
        public override void PrintMediaDetails()
        {
            // print out length,rented date,rented date return date
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Magazine {0} ({1})", Title, Length);
            Console.WriteLine("Rented date : {0} ", RentedDate);
            Console.WriteLine("Due on : {0}", ReturnDueDate());
            Console.ForegroundColor = ConsoleColor.White;

        }

        // calculates the return date by adding the rental length
        public override DateTime ReturnDueDate()
        {

            return RentedDate.AddDays(RentalLength);
        }

    }
}
