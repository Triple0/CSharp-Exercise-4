using System;

namespace CSharp_Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and Welcome!");
            var fromUser = input();
            var parseBefore = parseSmileyBefore(fromUser);
            var parseAfter = parseSmileyAfter(parseBefore);
            outputValues(parseAfter);      
        }

        static string input(){
            Console.WriteLine("Enter your name!");
            string userInput = Console.ReadLine();
            return userInput;
        }

        static string parseSmileyBefore(string userInput){
            return ":( " + userInput;
        }

        static string parseSmileyAfter(string userInput){
            return userInput+ " :)";
        }

        static void outputValues(string userInput){
            Console.WriteLine(userInput);
        }
    }
}


