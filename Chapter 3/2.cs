using System;

class H
{
    static void Main()
    {
        Console.Write("Enter a number:");
        int a = int.Parse(Console.ReadLine());
        
        if( (a%5 == 0) && (a%7 == 0) )
            Console.WriteLine("This number divides by 5 and 7.");
        else
            Console.WriteLine("This number does not divide by 5 and 7.");
        Console.ReadKey(true);
        
    }
}

