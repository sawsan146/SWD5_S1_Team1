using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sawsan.Tasks
{
    public class C_Task2
    {
        public static void RunTasks()
        {
            #region Question1
            ////Write a C# program that prints the first 10 multiples of 5 using a do-while loop.

            //int num = 5;
            //int Counter = 1;

            //do
            //{
            //    Console.WriteLine(num * Counter);
            //    Counter++;
            //} while (Counter <= 10);

            #endregion

            #region Question2

            //// Write a C# program that calculates the factorial of a given number.

            //Console.Write("Enter number to calculate the factorial : ");
            //int num; 
            //while(!int.TryParse(Console.ReadLine(),out num))
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.Write("Enter Valid Number : ");
            //    Console.ResetColor();
            //}

            //int fact = 1;
            //for(int i = 1; i <= num; i++){
            //    fact *= i;
            //}

            //Console.WriteLine($"Factorial = {fact}");

            #endregion

            #region Question3

            ////Write a C# program that calculates and prints the sum of all even numbers between 1 and 100 using a for loop.
            //int start = 1;
            //int end = 100;

            //int sum=0;
            //for (int i = start; i <= end; i++)
            //{

            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }

            //}

            //Console.WriteLine($"Sum = {sum}");
            #endregion

            #region Question4
            //// Write a C# program that prints the multiplication table for all numbers from 1 to 12.

            //int start = 1;
            //int end = 12;

            //for(int i = start; i <= end; i++)
            //{
            //    Console.WriteLine($"multiplication table for {i}");
            //    for(int j = 0; j <= 12; j++)
            //    {
            //        Console.WriteLine($"{i} * {j}\t= {i*j}");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region  Question5
            ////Write a C# program that prints all prime numbers between 1 and 500.

            //int start = 2;
            //int end = 500;


            //Console.WriteLine("Prime numbers between 1 and 500 are: ");

            //for (int i = start; i <= end; i++)
            //{
            //    bool prime = true;

            //    for (int j = 2; j <= Math.Sqrt(i); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            prime = false;
            //            break;
            //        }
            //    }

            //    if (prime)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region Question6

            ///*
            // * Write a C# program that prints the following pattern using a loop:
            // * a
            // * ab
            // * abc
            // * abcd
            // * abcde
            // */
            ////97=>101

            //for(char i = 'a'; i <= 'e'; i++)
            //{
            //    for(char j = 'a'; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Question7

            ////Write a C# program that creates an array of 10 integers and finds the maximum and minimum elements in the array using a for loop.
            //int Size = 10;
            //int[] arr = new int[Size];

            //Console.Write("Enter 10 numbers to the array: ");
            //for(int i = 0; i < Size; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int min=int.MaxValue;
            //int max=int.MinValue;

            //for(int i = 0; i < Size; i++)
            //{
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //    else if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //}

            //Console.WriteLine($"Max Value = {max}");
            //Console.WriteLine($"Min Value = {min}");

            #endregion

            #region Question8
            //// Write a C# program that reverses the elements of an array and prints the reversed array. Use a for loop.

            //int[] originalArray = { 3,57,2,0,81,2 };
            //int len = originalArray.Length;

            //int[] ReverserArray =new int[len];

            //for(int i = 0,j=len-1; j >=0; i++,j--)
            //{
            //    ReverserArray[i] = originalArray[j];
            //}

            //foreach(var num in ReverserArray)
            //{
            //    Console.Write(num+" ");
            //}
            //Console.WriteLine();
            #endregion

            #region Question9
            ////Write a C# program that prompts the user to enter 5 integers and stores them in an array. Then, the program should print the array elements in reverse order using a while loop.
            //int len = 5;
            //int[] arr = new int[len];
            //Console.Write("Enter 5 integers : ");

            //for(int i = 0; i < len; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //len -= 1;
            //while (len >= 0)
            //{
            //    Console.Write(arr[len]+" ");
            //    len--;

            //}
            #endregion

            #region Question10
            ////Write a C# program that prints all numbers from 1 to 100 but skips numbers that are multiples of 3 using a for loop.
            //int start = 1;
            //int end = 100;

            //for(int i = start; i <= end; i++)
            //{
            //    if (i % 3 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region Question11
            ////Write a C# program that checks if a given number is prime. If it is prime, print "Prime" otherwise, print "Not Prime".

            //Console.Write("Enter The Number To Check : ");
            //int num;

            //while(!int.TryParse(Console.ReadLine(),out num))
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Enter a valid number : ");
            //    Console.ResetColor();
            //}

            //if (num <= 1)
            //{
            //    Console.WriteLine("The number is NOT prime");
            //}
            //else
            //{
            //    bool isPrime = true;
            //    for (int i = 2; i <= Math.Sqrt(num); i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }

            //    if (isPrime)
            //    {
            //        Console.WriteLine("The number is prime");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number is NOT prime");

            //    }
            //}
            #endregion

            #region Question 12
            ////Write a C# program that finds and prints the first 20 prime numbers.

            //int counter = 0;

            //int[] arr = new int[20];

            //int num = 2;
            //while(counter < 20)
            //{

            //        bool prime = true;

            //        for (int j = 2; j <= Math.Sqrt(num); j++)
            //        {
            //            if (num % j == 0)
            //            {
            //                prime = false;
            //                break;
            //            }
            //        }

            //    if (prime)
            //    {
            //        arr[counter] = num;
            //        counter++;
            //    }

            //    num++;

            //}

            //foreach(var i in arr)
            //{
            //    Console.Write(i+" ");
            //}


            #endregion

            #region  Question13
            //// Write a C# program that prints the count of even/odd/positive/negative values in an given array.

            //int[] arr = { 1, 4, 6, 8, 3, 67, 13, -2, -3,2, -1, 5, 7, 11, 9, 34, 27 };

            //int evenCounter = 0;
            //int oddCounter = 0;
            //int positiveCounter = 0;
            //int negativeCounter = 0;

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] >= 0)
            //    {
            //        positiveCounter++;
            //    }
            //    else
            //    {
            //        negativeCounter++;
            //    }

            //    if (arr[i] % 2 == 0)
            //    {
            //        evenCounter++;
            //    }
            //    else
            //    {
            //        oddCounter++;
            //    }
            //}
            //Console.WriteLine($"Even     = {evenCounter}");
            //Console.WriteLine($"Odd      = {oddCounter}");
            //Console.WriteLine($"Positive = {positiveCounter}");
            //Console.WriteLine($"Negative = {negativeCounter}");


            #endregion

            #region Question14
            //// Write a C# program that generates the Fibonacci sequence up to a specified number of terms entered by the user.

            //Console.Write("Enter the number of terms for the Fibonacci sequence: ");
            //int Num;

            //while (!int.TryParse(Console.ReadLine(), out Num) || Num <= 0)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.Write("Please enter a valid positive integer : ");
            //    Console.ResetColor();
            //}

            //Console.WriteLine("Fibonacci Sequence:");
            //int first = 0, second = 1;

            //for (int i = 1; i <= Num; i++)
            //{
            //    Console.Write(first + " ");

            //    int next = first + second;
            //    first = second;
            //    second = next;
            //}
            #endregion

            #region Question 15
            ////Write a C# program that checks if an given array is palindrome or not.

            //int[] arr = { 2, 3, 4, 3, 2 };

            //bool isPalindrome = true;

            //for (int i = 0; i < arr.Length / 2; i++)
            //{

            //    if (arr[i] != arr[arr.Length - 1 - i])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}

            //if (isPalindrome)
            //{
            //    Console.WriteLine("The array is a palindrome.");
            //}
            //else
            //{
            //    Console.WriteLine("The array is NOT a palindrome.");
            //}
            #endregion

        }
    }
}
