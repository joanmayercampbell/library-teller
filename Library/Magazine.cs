using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Magazine:Media
    {
        public override string Title { get; set; }
        public override string Length { get; set; }
        public override int RentalLength { get; set; }
        protected DateTime RentedDate { get; set; }


        public Magazine()
        {
            RentedDate = DateTime.Today;
            
        }

        public override void PrintMediaDetails();

        public override DateTime ReturnDueDate();

        public void SetRentedDate()
        {
            RentedDate = DateTime.Today;
        }
    }
}
