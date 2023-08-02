using System;
using System.Collections.Generic;
using System.Threading;

namespace KidsLearningSystem
{
    class Program
    {
        static List<string> days = new List<string>
        {
            "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
        };

        static List<string> months = new List<string>
        {
            "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
        };

        static Dictionary<string, string> wordsAndMeanings = new Dictionary<string, string>
        {
            { "Apple", "A round fruit with red or green skin and white flesh." },
            { "Banana", "A long curved fruit with yellow skin." },
            { "Orange", "A citrus fruit with a bright orange skin." },
            { "Grapes", "Small, round fruits that come in various colors." },
            { "Strawberry", "A small red fruit with tiny seeds on the outside." }
        };

        static void DisplayDays()
        {
            foreach (var day in days)
            {
                Console.WriteLine("Day: " + day);
                Thread.Sleep(100); 
            }
        }

        static void DisplayMonths()
        {
            foreach (var month in months)
            {
                Console.WriteLine("Month: " + month);
                Thread.Sleep(100);
            }
        }

        static void DisplayFruitsAndWords()
        {
            foreach (var fruit in wordsAndMeanings.Keys)
            {
                Console.WriteLine("Fruit: " + fruit);
                Console.WriteLine("Meaning: " + wordsAndMeanings[fruit]);
                Console.WriteLine();
                Thread.Sleep(100);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("----Welcome to Learning----\n");

           
            Thread daysThread = new Thread(DisplayDays);
            Thread monthsThread = new Thread(DisplayMonths);
            Thread fruitsAndWordsThread = new Thread(DisplayFruitsAndWords);

          
            daysThread.Start();
            Thread.Sleep(100); 
            daysThread.Join();

            monthsThread.Start();
            Thread.Sleep(100); 
            monthsThread.Join(); 
            fruitsAndWordsThread.Start();

            
            fruitsAndWordsThread.Join();

            Console.WriteLine("\n----Learning complete!----");
        }
    }
}


