using System;

namespace Lab03._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userContinue = null;
            do
            {
                // ask user to input number between 1 to 100
                Console.Write("Enter a number between 1 and 100: ");
                //read the number
                int inputNumber = Convert.ToInt32(Console.ReadLine());

                //conditional Checks we have whether it's even or odd
                if (inputNumber % 2 == 0)
                {
                    //If number is EVEN and ranges between 2 - 25 print (Even and less than 25)
                    if (inputNumber >= 2 && inputNumber <= 25)
                    {
                        Console.WriteLine("Even and less than 25");
                    }
                    // if number is EVEN and in the range of 26 - 60 print (Even)
                    else if (inputNumber >= 26 && inputNumber <= 60)
                    {
                        Console.WriteLine("Even");
                    }
                    //If number is EVEN and greater than 60 print ({InputNumber} and Even)
                    else if (inputNumber > 60)
                    {
                        Console.WriteLine($"{inputNumber} and Even");
                    }
                }
                else
                {
                    // If number ODD print ({InputNumber} and Odd)
                    //If number is Odd and greater than 60 print ({InputNumber} and Odd)
                    Console.WriteLine($"{inputNumber} and Odd");
                }

                Console.Write("\nContinue? (y/n) ");
                userContinue = Console.ReadLine().ToLower();
                Console.WriteLine();

            } while (userContinue == "y" || userContinue == "yes");

            Console.WriteLine("Bye!");
        }
    }
}
