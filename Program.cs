using System;

namespace Part_5___Decisions
{
    class Program
    {


        public static void Main(string[] args)
        {
            int userAge;


            ///numeric age check
            Console.WriteLine("Please enter your age: ");
            while (!Int32.TryParse(Console.ReadLine(), out userAge))
            {
                Console.WriteLine("Please enter a valid age");
            }

            ///age grouping
            if (userAge <= 5)
            {
                Console.WriteLine("you are a toddler. ");
            }
            else if (userAge <= 10)
            {
                Console.WriteLine("you are a child. ");
            }
            else if (userAge <= 12)
            {
                Console.WriteLine("you are a preteen. ");
            }
            else if (userAge > 18)
            {
                Console.WriteLine("you are an adult. ");
            }
            else if (userAge > 12)
            {
                Console.WriteLine("you are a teenager. ");
            }
               

            Console.ReadLine();
        }
    }
}
