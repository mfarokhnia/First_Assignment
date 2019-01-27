using System;
using System.Collections.Generic;

namespace first_assignment_third_question
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Number"); //asking the user for the desired number to be converted
            string Number= Console.ReadLine();

            int IntNumber = Convert.ToInt32(Number);

            List<int> MyList = new List<int>(); // creating a list to hold the results of sequential divisions
            int quotient= IntNumber;

            bool condition = true;

            while (condition==true)
            {
                if (quotient==0) //end of division
                {
                    
                    condition=false;
                }
                else if (quotient==1)
                {
                    MyList.Add(1);
                    
                    quotient = 0;
             
                }
                else
                {
                    MyList.Add(quotient % 2);
                    quotient = quotient/2; //sequential division
                }
            }
            MyList.Reverse(); // to put the binary results in the right order
            var result = string.Join("", MyList); // to concatenate the binary results together to make a string of numbers
            

            Console.WriteLine("The Binary Conversion of the Numer is");
            Console.WriteLine(result);
            Console.ReadLine();



        }


    }

  
}
