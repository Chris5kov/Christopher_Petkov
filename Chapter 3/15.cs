using System;

class H
{
    static void Main()
    {
        Console.Write("Enter number:");
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n,2));
        
        long t1 = n & 0x1c;
        t1 = t1 << 21;
        
        long t2 = n & 0x3800000;
        t2 = t2 >> 21;
        
        n = n & 0xFC7FFFE3;
        n = n | t1;
        n = n | t2;
        Console.WriteLine(Convert.ToString(n,2));
        
        Console.ReadKey(true);
    }
}