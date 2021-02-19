using System;

namespace Part_5___Decisions
{
    class Program
    {


        public static void Main(string[] args)
        {
            int userAge;
            int hurricaneCatergory;

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


            Console.WriteLine("Please enter the huricane category number: ");

            ///category integer check
            while (!Int32.TryParse(Console.ReadLine(), out hurricaneCatergory))
            {
                Console.WriteLine("Please enter a valid number according to the saffir-simpson scale. ");
            }
            while (hurricaneCatergory <= 0 && hurricaneCatergory >= 6)
            {
                Console.WriteLine("Please enter a valid number according to the saffir-simpson scale. ");
            }

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

            Console.ReadLine();
        }
    }
}
