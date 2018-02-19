using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{

    class DOB
    {
        //user's date of birth collection
        public int day;
        private int month;
        private int year;
        //Bank bn = new Bank();
        public void set(int d, int m, int y)
        {
            
                this.day = d;
                this.month = m;
                this.year = y;
            

        }
        public bool checkDate()
        {
            if (day > 31 || month > 12 || year > 2016)
            {
                Console.WriteLine("Invalid date ");
                return false;

            }
            else
                return true;

        }
        public bool printDate()
        {
         

                if (checkDate() == true)
                {
                    Console.WriteLine("Date is : " + day + "-" + month + "-" + year);
                return false;
                }
                else
                    Console.WriteLine("please enter date again");
            return true;
              
              
        }
    }
}
