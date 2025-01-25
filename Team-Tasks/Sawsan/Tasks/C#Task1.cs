using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sawsan.Tasks
{
    public class C_Task1
    {

        public static void RunTasks()
        {
            #region Question1:
            ////  Write a C# program that prints your name, age, and favorite hobby on separate lines.


            //Console.WriteLine("\n\t\t\tYour Details -_-.");
            //Console.WriteLine("\t\t============================\n");
            //Console.WriteLine("\tMy name : Sawsan Abdelaziz");
            //Console.WriteLine("\tMy age : 20");
            //Console.WriteLine("\tFavorite Hobbies : Programming");
            //Console.WriteLine("\t\t\t   -Drawing");
            //Console.WriteLine("\t\t\t   -Reading");


            #endregion

            #region Question2:
            //// Write a C# program that declares variables of different data types (int, double, string, bool) and assigns them values. Then, print these values to the console.

            ////declaration
            //int Number;
            //double Fraction;
            //string Statement;
            //bool areYouOkey;

            ////assignment
            //Number = 6;
            //Fraction = 14.2;
            //Statement = "This is Q2's answer.";
            //areYouOkey = true;

            ////print
            //Console.WriteLine($"int         : {Number}");
            //Console.WriteLine($"double      : {Fraction}");
            //Console.WriteLine($"string      : {Statement}");
            //Console.WriteLine($"Are you okey: {areYouOkey}");
            #endregion

            #region  Question3:

            //// Write a C# program that converts a temperature value from Celsius to Fahrenheit. The Celsius temperature should be stored in a variable.
            //double Celsius;
            //double Fahrenheit;

            //Console.Write("Enter  temperature value as Celsius to convert to Fahrenheit : ");

            //while (!double.TryParse(Console.ReadLine(),out Celsius)){
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Enter a valid number.");
            //    Console.ResetColor();
            //}


            //Fahrenheit = (Celsius * 9 / 5) + 32;
            //Console.WriteLine($"Fahrenheit = {Fahrenheit}");

            #endregion

            #region Question4:
            //// Write a C# program that takes two numbers as input and performs the following operations: addition, subtraction, multiplication, and division. Print the results of each operation.
            //Console.WriteLine("\t\t\t\tCalculator");
            //Console.WriteLine("\t\t\t==============================\n");

            //Console.Write("\t\t\tEnter the first number : ");
            //double num1;

            //while(!double.TryParse(Console.ReadLine(),out num1)){

            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.Write("\t\t\tEnter a valid number : ");
            //    Console.ResetColor();

            //}

            // Console.Write("\t\t\tEnter the second number : ");
            //double num2;

            //while(!double.TryParse(Console.ReadLine(),out num2)){

            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.Write("\t\t\tEnter a valid number : ");
            //    Console.ResetColor();

            //}

            //Console.Write("\t\t\tChoose the operation [1]Add [2]Subtract [3] multiply  [4] divide [1:4] : ");
            //int option ;

            //while(!int.TryParse(Console.ReadLine(),out option))
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.Write("Enter a valid number.");
            //    Console.ResetColor();

            //}

            //double result = 0;
            //switch (option)
            //{
            //    case 1:
            //        result = num1 + num2;
            //        break;
            //    case 2:
            //        result = num1 - num2;
            //        break;
            //    case 3:
            //        result = num1 * num2;
            //        break;
            //    case 4:
            //        if (num2 == 0)
            //        {
            //            Console.WriteLine("\t\t\tYou can't divide at zero!!!");
            //        }
            //        else
            //        {
            //            result = num1 / num2;
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Operation number.");
            //        break;


            //}

            //Console.WriteLine($"\n\t\t\tResult = {result}");

            #endregion

            #region Question5:
            //// Write a C# program that calculates the area of a rectangle. The program should prompt the user to enter the length and width of the rectangle, and then calculate and display the area.

            //Console.WriteLine("\t\t\t\tCalculate area of rectangle ");
            //Console.WriteLine("\t\t\t========================================\n");

            //Console.Write("\t\t\tEnter the length : ");
            //double length;

            //while (!double.TryParse(Console.ReadLine(), out length))
            //{

            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.Write("\t\t\tEnter a valid number : ");
            //    Console.ResetColor();

            //}

            //Console.Write("\t\t\tEnter the width : ");
            //double width;

            //while (!double.TryParse(Console.ReadLine(), out width))
            //{

            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.Write("\t\t\tEnter a valid number : ");
            //    Console.ResetColor();

            //}

            //double Area = length * width;
            //Console.WriteLine($"\n\t\t\tArea = {Area}");


            #endregion

            #region Question6:
            //// Write a C# program that takes an integer as input and checks if it is even or odd. Print a message indicating whether the number is even or odd.

            //Console.Write("Enter Your Number : ");

            //int num;
            //while(!int.TryParse(Console.ReadLine(),out num))
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.Write("Enter a valid number :");
            //    Console.ResetColor();

            //}

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("Your number is EVEN.");
            //}
            //else
            //{
            //    Console.WriteLine("Your number is ODD");
            //}

            #endregion

            #region Question7:
            //// Write a C# program that prompts the user to enter their age. If the age is 18 or older, print "You are eligible to vote." If the age is less than 18, print "You are not eligible to vote."

            //Console.Write("Enter Your Age : ");
            //int Age;
            //if(int.TryParse(Console.ReadLine(),out Age))
            //{
            //    if (Age > 18)
            //    {
            //        Console.WriteLine("You are eligible to vote.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You are not eligible to vote.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input.");
            //}

            #endregion

            #region  Question8:
            ////            Write a C# program that simulates a simple grading system. The program should prompt the user to enter a score (0-100), and then print the corresponding grade based on the following criteria:
            ////90 - 100: A
            ////80 - 89: B
            ////70 - 79: C
            ////60 - 69: D
            ////Below 60: F



            //Console.Write("Enter a score (0-100): ");
            //int score;

            //while (!int.TryParse(Console.ReadLine(), out score) || score < 0 || score > 100)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Please enter a valid score between 0 and 100.");
            //    Console.ResetColor();
            //    Console.Write("Enter a score (0-100): ");
            //}

            //char grade;
            //if (score >= 90)
            //{
            //    grade = 'A';
            //}
            //else if (score >= 80)
            //{
            //    grade = 'B';
            //}
            //else if (score >= 70)
            //{
            //    grade = 'C';
            //}
            //else if (score >= 60)
            //{
            //    grade = 'D';
            //}
            //else
            //{
            //    grade = 'F';
            //}

            //Console.WriteLine($"The grade for a score of {score} is: {grade}");
            #endregion
        }

    }

}
