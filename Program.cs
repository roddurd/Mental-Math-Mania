using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static Random rand = new Random();
        static int num1, num2;
        static int numCorrect;
        static void Main(string[] args)
        {
            menu();
        }

        static void menu()
        {
            Console.WriteLine("MENTAL MATH MANIA\n==================\n\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Squares\n\n");
            Console.Write("Which problem set do you want to do? [1-5]: ");
            String response = Console.ReadLine();
            String[] valid = { "1", "2", "3", "4", "5" };
            while (Array.IndexOf(valid, response) < 0)
            {
                Console.WriteLine("Your response did not make sense.");
                Console.Write("Which problem set do you want to do? [1-5]: ");
                response = Console.ReadLine();
            }
            switch (response.Trim())
            {
                case "1":
                    Addition();
                    break;
                case "2":
                    Subtraction();
                    break;
                case "3":
                    Multiplication();
                    break;
                case "4":
                    Division();
                    break;
                case "5":
                    Squares();
                    break;
                default:
                    Console.WriteLine("Your input did not make sense.");
                    break;
            }
        }

        static void Addition()
        {
            for (int i = 1; i <= 10; i++)
            {
                num1 = rand.Next(100, 500);
                num2 = rand.Next(100, 500);
                Console.WriteLine("What is " + num1 + " + " + num2 + "?");
                Console.Write("Your answer: ");
                String response = Console.ReadLine();
                if (Convert.ToString(num1 + num2).Equals(response))
                {
                    numCorrect++;
                    Console.WriteLine("Correct! [" + numCorrect + "/" + i + "]");
                }
                else
                    Console.WriteLine("Incorrect. The correct answer was: " + (num1 + num2) + ". [" + numCorrect + "/" + i + "]");                 
                
            }
            Console.WriteLine("Problem set completed. You scored " + numCorrect + " out of 10 correct.\n\n");
            numCorrect = 0;
            Console.WriteLine("Press enter to return to the home menu...");
            Console.ReadLine();
            Console.Clear();
            menu();
        }

        static void Subtraction()
        {
            for (int i = 1; i <= 10; i++)
            {
                num1 = rand.Next(100, 500);
                num2 = rand.Next(100, 500);
                int temp = num1;
                num1 = (num2 > num1) ? num2 : num1;
                num2 = (num2 > temp) ? temp : num2;
                Console.WriteLine("What is " + num1 + " - " + num2 + "?");
                Console.Write("Your answer: ");
                String response = Console.ReadLine();
                if (Convert.ToString(num1 - num2).Equals(response))
                {
                    numCorrect++;
                    Console.WriteLine("Correct! [" + numCorrect + "/" + i + "]");
                }
                else
                    Console.WriteLine("Incorrect. The correct answer was: " + (num1 - num2) + ". [" + numCorrect + "/" + i + "]");

            }
            Console.WriteLine("Problem set completed. You scored " + numCorrect + " out of 10 correct.\n\n");
            numCorrect = 0;
            Console.WriteLine("Press enter to return to the home menu...");
            Console.ReadLine();
            Console.Clear();
            menu();
        }

        static void Multiplication()
        {
            for (int i = 1; i <= 10; i++)
            {
                num1 = rand.Next(2, 50);
                num2 = rand.Next(2, 50);
                Console.WriteLine("What is " + num1 + " * " + num2 + "?");
                Console.Write("Your answer: ");
                String response = Console.ReadLine();
                if (Convert.ToString(num1 * num2).Equals(response))
                {
                    numCorrect++;
                    Console.WriteLine("Correct! [" + numCorrect + "/" + i + "]");
                }
                else
                    Console.WriteLine("Incorrect. The correct answer was: " + (num1 * num2) + ". [" + numCorrect + "/" + i + "]");

            }
            Console.WriteLine("Problem set completed. You scored " + numCorrect + " out of 10 correct.\n\n");
            numCorrect = 0;
            Console.WriteLine("Press enter to return to the home menu...");
            Console.ReadLine();
            Console.Clear();
            menu();
        }

        static void Division()
        {
            for (int i = 1; i <= 10; i++)
            {
                num1 = rand.Next(2, 50);
                num2 = rand.Next(2, 50);
                int product = num1 * num2;
                Console.WriteLine("What is " + product + " / " + num2 + "?");
                Console.Write("Your answer: ");
                String response = Console.ReadLine();
                if (Convert.ToString(num1).Equals(response))
                {
                    numCorrect++;
                    Console.WriteLine("Correct! [" + numCorrect + "/" + i + "]");
                }
                else
                    Console.WriteLine("Incorrect. The correct answer was: " + (num1) + ". [" + numCorrect + "/" + i + "]");

            }
            Console.WriteLine("Problem set completed. You scored " + numCorrect + " out of 10 correct.\n\n");
            numCorrect = 0;
            Console.WriteLine("Press enter to return to the home menu...");
            Console.ReadLine();
            Console.Clear();
            menu();
        }

        static void Squares()
        {
            for (int i = 1; i <= 10; i++)
            {
                num1 = rand.Next(10, 50);
                Console.WriteLine("What is " + num1 + "^2?");
                Console.Write("Your answer: ");
                String response = Console.ReadLine();
                if (Convert.ToString(num1*num1).Equals(response))
                {
                    numCorrect++;
                    Console.WriteLine("Correct! [" + numCorrect + "/" + i + "]");
                }
                else
                    Console.WriteLine("Incorrect. The correct answer was: " + (num1*num1) + ". [" + numCorrect + "/" + i + "]");

            }
            Console.WriteLine("Problem set completed. You scored " + numCorrect + " out of 10 correct.\n\n");
            numCorrect = 0;
            Console.WriteLine("Press enter to return to the home menu...");
            Console.ReadLine();
            Console.Clear();
            menu();
        }
    }
}
