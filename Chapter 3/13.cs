using System;

class H
{
    static void Main()
    {
        Console.Write("Enter number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n,2));
        
        Console.Write("Enter position:");
        int p = int.Parse(Console.ReadLine());
        
        int v = 2;
        while( v != 0 && v != 1 )
        {
            Console.Write("Enter V(0 or1):");
            v = int.Parse(Console.ReadLine());
        }
        
        if( v == 1 )
            n = n | (1 << p-1);
        else
            n = n & ~(1 << p-1);
        Console.WriteLine(Convert.ToString(n,2));
        
                      
               
        Console.ReadKey(true);
            
    }
}

