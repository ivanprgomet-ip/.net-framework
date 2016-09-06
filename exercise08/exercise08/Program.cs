﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            Searcher se = new Searcher();

            ////EXERCISE 8
            //Console.WriteLine("EXERCISE 08 | BRUTE FORCE SEARCH");
            //List<int> myCollection = new List<int>();//instantiate an empty list
            //PopulateCollection(myCollection);//fill the list with dummy values (0-1000)
            //se.BruteForceSearchHard(849, myCollection);//search inputted list for specific value
            //Console.WriteLine("------------");

            //List<int> numbers = new List<int>();
            //PopulateCollection(numbers);
            //se.BruteForceSearchSoft(numbers, 849);
            //Console.ReadKey();


            //BREAK A PASSWORD
            Console.ForegroundColor = ConsoleColor.Cyan;
            List<string> passwords = new List<string>() { "234", "361", "123", "842", "567" };
            Random rnd = new Random();
            int rndIndex = rnd.Next(0, passwords.Count);
            string rndPassword = passwords[rndIndex].ToString();
            Console.WriteLine("A password has been generated");
            Console.WriteLine("_____________________________");

            bool loginSucceded = false;
            int index = 0;
            while (!loginSucceded)
            {
                Console.WriteLine("[1] manual attempt");
                Console.WriteLine("[2] Use PasswordAnnihilator to crack password");
                string choice = Console.ReadLine();
                string passwordInput = string.Empty;
                switch (choice)
                {
                    case "1":
                        break;
                    case "2":
                        rndPassword = PasswordAnnihilator.SeedPasswordCombinations(index).ToString();
                        if (passwordInput.Equals(rndPassword))
                            loginSucceded = true;
                        break;
                    default:
                        Console.WriteLine("Enter legit input");
                        break;
                }

                if (loginSucceded)
                {
                    Console.WriteLine("Login successful!");
                    break;
                }
                else
                    Console.WriteLine("Login failed");
                index++;
            }
            
            Console.WriteLine(rndPassword);
            Console.WriteLine("_____________________________");
            Console.ResetColor();
            Console.ReadKey();


            ////EXERCISE 9
            //Console.WriteLine("EXERCISE 09 | BINARYSEARCH");
            //List<int> myCollection2 = new List<int>();
            //PopulateCollection(myCollection2);
            //myCollection2.Sort();//neccessary for binarysearch to work propperly
            //PrintList(myCollection2);
            //se.BruteForceSearchHard(500, myCollection2);
            //Console.WriteLine("------------");



            //Sorter s = new Sorter();

            ////EXERCISE 10
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.WriteLine("EXERCISE 10 | BUBBLESORT");
            //List<int> myCollection3 = new List<int>();
            //PopulateCollection(myCollection3);
            //s.BubbleSort(myCollection3);
            //PrintList(myCollection3);
            //Console.WriteLine("------------");
            //Console.ResetColor();
            ////EXERCISE 11
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("EXERCISE 10 | EXCHANGE SORT");
            //List<int> myCollection4 = new List<int>();
            //PopulateCollection(myCollection4);
            //s.ExchangeSort(myCollection4);
            //PrintList(myCollection4);
            //Console.WriteLine("------------");
            //Console.ResetColor();
        }

        public static void PopulateCollection(List<int> myCollection)
        {
            //foundation for searching or sorting on
            Random rnd = new Random();
            for (int i = 0; i < 200; i++)
            {
                int number = rnd.Next(1, 1000);
                while (myCollection.Contains(number))
                {
                    number = rnd.Next(1, 1000);
                }
                myCollection.Add(number);
            }
        }
        public static void PrintList(List<int> myCollection)
        {
            for (int i = 0; i < myCollection.Count; i++)
            {
                Console.WriteLine(i + ": " + myCollection[i]);
            }
            //foreach (int num in myCollection)
            //{
            //    Console.WriteLine(num);
            //}
        }
    }
}
