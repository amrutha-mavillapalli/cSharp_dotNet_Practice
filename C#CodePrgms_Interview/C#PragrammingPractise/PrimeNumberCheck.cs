using System;

public class PrimeChecker
{
    public static void PrimeNumChecker()
    {
        // prime number means it should have 1 and itself as factors.
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());

        bool isPrime = true; // defaultly it is true i.e prime

        if(num <=1)
        {
            isPrime = false;
        }
        else if(num ==2) // 2 is the only even prime number
        {
            isPrime = true;
        }
        else if (num % 2 ==0) //Even numbers greater than 2 are not prime and also they are divided by 2
        {
            isPrime = false;
        }
        else
        {
            // We only need to check divisibility up to the square root of the number.
            for ( int i=3; i*i <=num;i+=2)
            {
                if(num%i==0)
                {
                    isPrime = false; // because it has a factor
                    break;
                }
            }
        }

       //printing whether it's prime or not
       if(isPrime)
       {
            Console.WriteLine($"{num} is a prime number");
       }
       else
       {
            Console.WriteLine($"{num} is not a prime number");
       }
        Console.ReadKey();
    }
}

