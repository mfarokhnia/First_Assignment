using System;

namespace First_Assignment_Fifth_Question
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many Rows Should be Printed?"); // reading the number of rows to be printed from user
            string NumberOfRows=Console.ReadLine();

            int IntRowNumber = Convert.ToInt32(NumberOfRows);

            string starsrow = "";
            string blankspaces = "";
            string stars = "";

            for (int i = 1; i <= IntRowNumber; i++) //creating a list of blank spaces and stars
            {
                stars = new string('*', (2 * i - 1));
                blankspaces = new string(' ', (IntRowNumber - i));
                starsrow = blankspaces + stars + blankspaces; // concatenating stars and blank spaces
                Console.WriteLine(starsrow);

            }
            Console.ReadLine();



        }


    }
}
