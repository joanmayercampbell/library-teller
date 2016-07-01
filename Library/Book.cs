using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book: Media
    {
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


        public Book()
        {
            RentedDate = DateTime.Today;
        }

        public override void PrintMediaDetails()
        {
            // print out length,rented date,rented date return date
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Book {0} ({1})", Title, Length);
            Console.WriteLine("Rented date : {0} ", RentedDate);
            Console.WriteLine("Due on : {0}", ReturnDueDate());
            Console.ForegroundColor = ConsoleColor.White;

        }

        public override DateTime ReturnDueDate()
        {

            return RentedDate.AddDays(RentalLength);
        }
    }
}
