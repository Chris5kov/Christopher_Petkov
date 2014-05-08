using System;

class h
{
    static int n;
    static int[] loops;
    
    static void Main()
    {
        Console.Write("N = ");
        n = int.Parse(Console.ReadLine());
        
        loops = new int[n];
        
        Recursive(0);
        
        Console.ReadKey(true);
    }
    
    static void Recursive(int curn)
    {
        if( curn == n )
        {
            PrintLoops();
            return;
        }
        for(int i = 1; i <= n; i++)
        {
            loops[curn] = i;
            Recursive(curn+1);
        }
        Console.WriteLine();
    }
    
    static void PrintLoops()
    {
        for(int i = 0; i < n; i++)
        {
            Console.Write("{0} ", loops[i]);
        }
        Console.WriteLine();
    }
}