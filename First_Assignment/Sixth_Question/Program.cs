using System;
using System.Collections.Generic;
using System.Linq;

namespace First_Assignment_sixth_Question
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] MyArray = { "A", "B", "C", "D", "E", "F", "G", "I", "J", "K","A" }; //Arbitrary List
            List<String> ListOfArray = new List<string>(MyArray); //Converting the Array to a list 

            Dictionary<string, int> ReturnedDictionary = new Dictionary<string, int>(); // creating a dictionary to hold the objects along with their counts

            ReturnedDictionary = CountOfObjects(ListOfArray); //calling the defined method of counting the repetition of objects

            Console.WriteLine("Number"+"  "+ "Frequency");

            foreach (KeyValuePair<string, int> author in ReturnedDictionary)
            {
                Console.WriteLine(" {0},        {1}", author.Key, author.Value);
            }
            Console.ReadLine();



        }

        static private Dictionary<string,int> CountOfObjects (List<string> TheList)// list of the objects in the first array is passed to the method to count their repetition
        {
            Dictionary<string, int> DictionaryOfList = new Dictionary<string, int>();
            int Count = TheList.Count;
            

            for (int i=0; i<Count; i++)                       // checks if the key exists in the dictionary else adds to the dictionary and puts the value equal to the repetition count
            {
                if(DictionaryOfList.ContainsKey( TheList[i]))
                    {
                        DictionaryOfList[TheList[i]] += 1;
                    }
                else
                {
                    DictionaryOfList.Add(TheList[i], 1);
                }
                
            }
            return DictionaryOfList;
        }
    }
}
