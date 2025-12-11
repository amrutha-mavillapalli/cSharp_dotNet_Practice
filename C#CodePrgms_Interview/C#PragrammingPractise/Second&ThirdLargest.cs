using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace C_PragrammingPractise
{
    public class SecondAndThirdLargestInArray
    {
        public static void SecondLargest()
        {
            int[] arr = new int[] { 12, 35, 1, 10, 34, 1 };


            //int[] numbers = new int[3];

            //Console.WriteLine("Enter 3 numbers:");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Element {i}: ");
            //    // Read the line from the console and convert it to an integer
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            int n = arr.Length;

            int largest = -1, secondLargest = -1;

            // Finding the largest element
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > largest)
                    largest = arr[i];
            }

            // Finding the second largest element
            for (int i = 0; i < n; i++)
            {
                // Update second largest if the current element is greater
                // than second largest and not equal to the largest
                if (arr[i] > secondLargest && arr[i] != largest)
                {
                    secondLargest = arr[i];
                }
            }

            Console.WriteLine($"{secondLargest} is the second largest number");

            // METHOD 2: using Sorting
            Console.WriteLine($"{GetSecondLargestBySorting(arr)} is the second largest number (by sorting)");
        }

        // Fix: Move arr1 and n1 inside the method, not as fields
        // function to find the second largest element using sorting
        public static int GetSecondLargestBySorting(int[] arr)
        {
            int n = arr.Length;

            // Sort the array in non-decreasing order
            Array.Sort(arr);

            // start from second last element as last element is the largest
            for (int i = n - 2; i >= 0; i--)
            {
                // return the first element which is not equal to the largest element
                if (arr[i] != arr[n - 1])
                {
                    return arr[i];
                }
            }

            // If no second largest element was found, return -1
            return -1;
        }
        public static void ThirdLargest()
        {
            int[] nums = { 10,5,20, 25, 63, 96,7, 57 };
            Console.WriteLine($"The third largest is: {FindThirdLargestLinear(nums)}");
        }

            public static int FindThirdLargestLinear(int[] nums)
            {
            if (nums == null || nums.Length < 3)
            {
                // Handle edge case for arrays shorter than 3 elements
                throw new ArgumentException("Array must contain at least 3 elements.");
            }

            // Initialize variables to a very small number (or use nullable ints/flags)
            int first = int.MinValue;
            int second = int.MinValue;
            int third = int.MinValue;

            foreach (int num in nums)
            {
                if (num > first)
                {
                    third = second;
                    second = first;
                    first = num;
                }
                else if (num > second && num != first)
                {
                    third = second;
                    second = num;
                }
                else if (num > third && num != second && num != first)
                {
                    third = num;
                }
            }
            // This linear method correctly finds the third *distinct* maximum value.
            // If the array has fewer than 3 distinct elements, 'third' might remain MinValue, 
            // which may require additional logic depending on specific requirements.
            return third;
        }
            
        
    }
}
