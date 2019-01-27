using System;

namespace first_assignment_second_question
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please Enter the Desired number"); // reading the series number from user
            int Number = Convert.ToInt32( Console.ReadLine());

            
            double ComputedSeries = 0; // creating the series sum


            for (int i=1; i<(Number+1); i++)
            {
                ComputedSeries = ComputedSeries+ ((Convert.ToDouble (Math.Pow(-1, i - 1))) * ((Convert.ToDouble ((Factorial(i))) / (Convert.ToDouble (i + 1))))); //calling the defined factorial method to compute the series
            }

            Console.WriteLine("the result is" +" "+ ComputedSeries);
            Console.ReadLine();

        }

        static private int Factorial( int num) // defining the factorial calculator method
        {
            if (num==1)
            {
                return 1;
            }
            else
            {
                return Factorial(num - 1) * num;
            }
        }
    }
}
