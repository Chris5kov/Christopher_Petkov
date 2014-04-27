using System;

class H
{
    static void Main()
    {
        Console.Write("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        
        int c = n - 1;
        
        while( c != 1 )
        {
            if( n%c == 0 )
            {
                Console.WriteLine("Not prime number.");
                break;
            }
            c--;
        }
        if( c == 1 )
            Console.WriteLine(n + " is a prime number.");
        Console.ReadKey(true);
    }
}