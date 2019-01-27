using System;
using System.Collections.Generic;
using System.Linq;

namespace first_assignment_fourth_question
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Binary Number");//getting numbers from users
            string Number= Console.ReadLine();
            List<string> SplittedNumber = new List<string>(Number.Select(c=>c.ToString()) ); //splitting the string into list to separate 

            int numberlength = SplittedNumber.Count ; // finding the length of the entered binary number

            bool NumberValidity = true;
            int Counter = 0;
            int Result = 0;


            for (int i = 0; i < numberlength; i++)
            {
                if (Convert.ToInt32( SplittedNumber[i]) > 1) //checking if the entered number was a binary or not
                {
                    Console.WriteLine("The Entered Number is not Binary");
                    NumberValidity = false;
                }
            }

            if(NumberValidity==true)
            {
               while(Counter<numberlength)
                {
                    Result = Result+ ((Convert.ToInt32(SplittedNumber [numberlength-1- Counter])* TwoToThePowerN(Counter))); //converting the binary number to decimal calling the defined method
                    Counter += 1;
                }
            }

            Console.WriteLine(" The Converted Number Is" + "" + Result);
            Console.ReadLine();

        }

        static private int TwoToThePowerN(int n)// Defined method to calculate 2^n
        {
            if(n==0)
            {
                return 1;
            }
            else
            {
                return 2 * TwoToThePowerN(n - 1);
            }
           
        }
    }
}
