using System;
using System.Collections.Generic;
using System.Text;

namespace TinyCRM
{
    public class Customer
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string VatNumber{ get; set; }
        public string Phone { get; set; }
        public decimal TotalGross { get; set; }
        public DateTime Created { get; set; }
        public bool IsActive { get; set; }


        public Customer(string vatNumber)
        {
            if (!IsValidVatNumber(VatNumber))
            {
                throw new Exception("invalid vatnumber");

            }
            VatNumber = vatNumber;

        }



            public bool IsValidVatNumber(string vatNumber)
             {
            int numericafm;
            if(int.TryParse(vatNumber,out numericafm))
            {
                Console.WriteLine($"It is numeric {numericafm}");
                if (vatNumber.Length==9)
                { Console.WriteLine("success");
                    return true;

                }
                else
                { Console.WriteLine("wrong length,try again");
                }
            }
            Console.WriteLine("it is not numeric");
            return false;

                }
        
      


    }
}
