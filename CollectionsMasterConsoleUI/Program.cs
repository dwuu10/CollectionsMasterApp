using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            var ints = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(ints);

            //TODO: Print the first number of the array
            Console.WriteLine(ints[0]);
            //TODO: Print the last number of the array            
            Console.WriteLine(ints[49]);
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(ints);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            ReverseArray(ints);
            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(ints);
            NumberPrinter(ints);
            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(ints);
            NumberPrinter(ints);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var intlist = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine(intlist.Count);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(intlist);

            //TODO: Print the new capacity
            Console.WriteLine(intlist.Count);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            var input = Console.ReadLine();
            bool parsable = int.TryParse(input, out var value);
            while (parsable == false)
            {
                Console.WriteLine("enter an integer");
                input = Console.ReadLine();
                parsable = int.TryParse(input, out value);
            }
            NumberChecker(intlist, value);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(intlist);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(intlist);
            NumberPrinter(intlist);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            intlist.Sort();
            NumberPrinter(intlist);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var intarray = intlist.ToArray();

            //TODO: Clear the list
            intlist.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            foreach (int i in numbers)
            {
                if (i % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for(int i = numberList.Count-1; i >= 0; i--)
            {
                if ((numberList[i] % 2) == 1)
                {
                    numberList.RemoveAt(i);
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {

            foreach (var number in numberList)
            {
                if (number == searchNumber)
                {
                    Console.Write($"{searchNumber} is present");
                }
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(1, 50));
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = (numbers.Length - 1); i >= 0; i--)
            {
                numbers[i] = rng.Next(1, 50);
            }
        }
            

        private static void ReverseArray(int[] array)
        {
            for (int i = (array.Length-1); i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
