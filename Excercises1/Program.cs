using System;

namespace ExcercisesPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that asks for users first and last name
            //the program greets the user by their name
            //the program asks the user to enter their year of birth and calculates the users age
            //*Convert.ToInt32(string(ToConvert))
            //is the user is 13 or older, then the program displays "Welcome to Instagram"
            //otherwise the program displays "Your are too young to have the Instagram account"


            String userFirstName, userLastName;
            int userYear;
            

            Console.WriteLine("Please enter your first name");
            userFirstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            userLastName = Console.ReadLine();
            Console.WriteLine("Hello " + userFirstName + "!");

            Console.WriteLine(userFirstName  + ", please tell me your year of birth");
            userYear = Convert.ToInt32(Console.ReadLine());

            int currentYear = Convert.ToInt32(DateTime.Now.Year.ToString());

            int age = currentYear - userYear;

            if (age >= 13)
            {
                Console.WriteLine("Welcome to Instagram");
            }
            else
            {
                Console.WriteLine("Your are too young to have the Instagram account");
            }


        }
    }
}
