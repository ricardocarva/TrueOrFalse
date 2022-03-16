using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           True or False?
           This program contains a simple pre-defined array of questions and answers, and it will take the user responses to verify if they got the response right or wrong. The goal here was to practice ensuring the customer's input was valid.
           Author: Ricardo Carvalheira
                       */
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Type your code below
            string[] questions = { "2+2 is equals to 4", "3-2 is equals to 2" };
            bool[] answers = { true, false };
            bool[] responses = new bool[answers.Length];
            if (questions.Length != answers.Length)
            {
                Console.WriteLine("ALERT!\r\nThe number of questions and answers do not match!");
            }
            int askingIndex = 0;

            foreach (string question in questions)
            {
                string input;
                bool isBool = false;
                bool inputBool;
                Console.WriteLine($"{question}");
                Console.Write($"True or false?\r\nAnswer: ");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);
                while (!isBool)
                {
                    Console.WriteLine("Please respond with \'true\' or \'false\'.\r\n");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                Console.WriteLine("");
                responses[askingIndex] = inputBool;
                askingIndex++;

            }

            int scoringIndex = 0;
            int score = 0;
            foreach (bool answer in answers)
            {
                bool userResponse = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex + 1}. Input: {userResponse} | Answer: {answer}");
                if (userResponse == answer) score++;
                scoringIndex++;
            }
            Console.WriteLine($"\r\nYou got {score} out of {scoringIndex} correct!");

            Console.WriteLine("\r\n\r\nPress Enter to end program");
            Console.ReadLine();
        }
    }
}
