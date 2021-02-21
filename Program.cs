using System;

namespace Part_5___Decisions
{
    class Program
    {


        public static void Main(string[] args)
        {
            int userAge;
            int hurricaneCatergory;
            int generatedNumber;
            int numberGuess;
            int numberGuess2;
            Random rng = new Random();

            ///age group decider
            Console.WriteLine("Please enter your age: ");
            ///numeric age check
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


            ///hurricane category reader
            Console.WriteLine("Please enter the huricane category number: ");
            ///category integer check
            while (!Int32.TryParse(Console.ReadLine(), out hurricaneCatergory) || hurricaneCatergory <= 0 || hurricaneCatergory >= 6)
            {
                Console.WriteLine("Please enter a valid number according to the saffir-simpson scale. ");
            }

            ///hurricane category decision maker
            switch (hurricaneCatergory)
            {
                case 1:
                    Console.WriteLine("the winds are currently within 74-95mph, 64-82kt, 119-153km/h");
                    break;
                case 2:
                    Console.WriteLine("the winds are currently within 96-110mph, 83-95kt, 154-177km/h");
                    break;
                case 3:
                    Console.WriteLine("the winds are currently within 110-130mph, 96-113kt, 178-209km/h");
                    break;
                case 4:
                    Console.WriteLine("the winds are currently within 131-155mph, 114-135kt, 210-249km/h");
                    break;
                case 5:
                    Console.WriteLine("the winds are currently greater than 155mph, 135kt, 249km/h");
                    break;

            }


            ///random divisible 
            generatedNumber = rng.Next(1, 7);
            Console.WriteLine(generatedNumber);
            Console.WriteLine(@"
I have generated a number from 2-6, please try to guess a higher number 
than I have chosen, and I will tell you if your number divides into my number.");
            ///non-numeric check
            while (!Int32.TryParse(Console.ReadLine(), out numberGuess))
            {
                Console.WriteLine("Please enter a numeric value: ");
            }
            ///smaller guess than generated number check
            while (numberGuess < generatedNumber)
            {
                Console.WriteLine(@"The number you have chosen is smaller than the number I chose.
Please try again: ");
                while (!Int32.TryParse(Console.ReadLine(), out numberGuess))
                {
                    Console.WriteLine("Please enter a numeric value: ");
                }
            }

            ///divisiblity check
            if (numberGuess % generatedNumber == 0)
            {
                Console.WriteLine("Our numbers are divisible by " + numberGuess / generatedNumber);

                Console.WriteLine("Can you guess the number I picked?: ");
                if (!Int32.TryParse(Console.ReadLine(), out numberGuess2) || numberGuess2 != generatedNumber)
                {
                    Console.WriteLine("incorrect :(");
                }
                else
                {
                    Console.WriteLine("Correct! very good.");
                }
            }
            else
            {
                Console.WriteLine("Our numbers are not divisible. :(");
            }

            Console.ReadLine();
        }
    }
}
