using System;
using System.Text;

namespace swich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vowel();
            //months();
            grads();
            days();



        }

        static void vowel()
        {
            Console.WriteLine("Enter the Character : ");
            char ch = char.Parse(Console.ReadLine());

            switch (ch)
            {

                case 'a':

                case 'e':

                case 'i':

                case 'o':

                case 'u':
                    Console.WriteLine("The character is Vowel. ");
                    break;
                default:
                    Console.WriteLine("The character is Constant. ");
                    break;
            }
        }
        static void months()
        {
            Console.WriteLine("Enter the month number : ");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                    //default : Console.WriteLine("Enter the month number : ");
                    //break;
            }

        }
        static void grads()
        {
            Console.WriteLine("Enter the Grad letter i cabital: ");
            char grade = char.Parse(Console.ReadLine());

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Very good");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Accepted");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
            }

        }


        static void days()
        {
            Console.WriteLine("Enter the day number : ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Saturday");
                    break;
                case 2:
                    Console.WriteLine("Sundy");
                    break;
                case 3:
                    Console.WriteLine("Monday");
                    break;
                case 4:
                    Console.WriteLine("Tusday");
                    break;
                case 5:
                    Console.WriteLine("Wednesday");
                    break;
                case 6:
                    Console.WriteLine("Thursday");
                    break;
                case 7:
                    Console.WriteLine("Friday");
                    break;
            }

        }
    }
}