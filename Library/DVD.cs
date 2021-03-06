﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class DVD:Media
    {
        public override int RentalLength {
            get
            {
                return 7;
            }
            set
            {                    
            }
        }

      
        public DVD()
        {
            RentedDate = DateTime.Today;
        }

        public override void PrintMediaDetails()
        {
            // print out the DVD information in red
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("DVD {0} ({1})", Title, Length);
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
