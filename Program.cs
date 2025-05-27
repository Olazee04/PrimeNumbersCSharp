using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prime numbers between 1 and 100:");

        for (int num = 2; num <= 100; num++)
        {
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }

            if (count == 2)
            {
                Console.WriteLine(num);
            }
        }
    }
}