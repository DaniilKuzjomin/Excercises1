using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //the program and the user to enter their favorite color
            //the program displays the users personality traits
            // 'red' - romantic, 'blue' - reliable, 'yellow' - cheerful
            //if the user enters anything else, the programm displays
            //"You are a [userInput] unicorn."


            Console.WriteLine("Please, enter your favorite color: ");
            string userInput = Console.ReadLine();

            if ( userInput == "red" )
            {
                Console.WriteLine("You are a romantic unicorn. ");
            }
            else if ( userInput == "Blue" )
            {
                Console.WriteLine("You are a reliable unicorn. ");
            }
            else if ( userInput == "Yellow" )
            {
                Console.WriteLine("You are a cheerful unicorn. ");
            }
            else
            {
                Console.WriteLine($"Your are a {userInput} unicorn");
            }
        }
    }
}
