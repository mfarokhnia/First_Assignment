using System;
using System.Collections.Generic;

namespace Assignment1_S19
{
    class Program
    {
        public  static void Main()
        {

            Console.WriteLine("please Enter the Starting Number"); //getting the starting number from user
            string StartingNumber=Console.ReadLine();

            Console.WriteLine("please Enter the Ending Number"); //getting the ending number from user
            string EndingNumber = Console.ReadLine();

            double Starting = Convert.ToDouble(StartingNumber);
            double Ending = Convert.ToDouble(EndingNumber);

            List <int> PrimeList = new  List <int>(); // creating a list to hold all prime numbers in the interval

            int IntegerEnding = Convert.ToInt32(Ending);
            int IntegerStarting= Convert.ToInt32(Starting) ;
            int Counter = IntegerStarting;


            if (Starting<Ending) //to check if the interval is valid
            {
                if(Ending - (IntegerEnding = Convert.ToInt32(Math.Floor(Ending)))==0 && Starting - (IntegerStarting = Convert.ToInt32(Math.Floor(Starting))) == 0) //to check if the entered values are integers
                {
                    while (Counter <= IntegerEnding)
                    {
                        bool PrimeNumber= IsPrime(Counter); // calling the IsPrime method
                        if (PrimeNumber==true)
                        {
                            PrimeList.Add(Counter); // adding prime numbers to the prime list
                            Counter += 1;
                        }
                        else
                        {
                            Counter += 1;
                        }
                    }

                     foreach(int t in PrimeList) //printing prime numbers in the list
                    {
                        Console.WriteLine(t);
                        
                    }
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Numbers Must be Integer"); //inform the user that entered values are not integer
                    Console.ReadLine();
                }

            }
            else
            {
                Console.WriteLine("Ending Number Must be Greater than Starting Number"); //Inform the user that the interval is not valid
                Console.ReadLine();

            }

        }

        static private bool IsPrime( int TheNumber) // defining the method to check for the passed argument to be prime
        {
            if (TheNumber==1)
            {
                return true;
            }
            else if (TheNumber==2)
            {
                return  true;

            }
            else
            {
                for (int i =2; i<TheNumber; i++)
                {
                    int aa = TheNumber;
                    aa %= i;
                    if (aa==0)
                    {
                        return false;
                    }
                    else
                    {
                        aa = TheNumber;
                    }
                    
                }
                return true;
            }

        }
    }
}
