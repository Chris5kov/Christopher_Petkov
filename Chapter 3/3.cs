using System;

class H
{
    static void Main()
    {
        Console.Write("Enter a 3 or more digit number:");
        int a = int.Parse(Console.ReadLine());
        
        a /= 100;
        
        if( a%10 == 7 )
            Console.WriteLine("3rd digit is 7.");
        else 
            Console.WriteLine("Not 7.");
        Console.ReadKey(true);
    }
}