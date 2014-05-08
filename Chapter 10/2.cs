using System;

class h
{
    static int n;
    static int k;
    static int[] loops;
    
    static void Main()
    {
        Console.Write("N = ");
        n = int.Parse(Console.ReadLine());
        
        Console.Write("K = ");
        k = int.Parse(Console.ReadLine()); 
        
        loops = new int[k];
        
        Recursive(1);
        
        Console.ReadKey(true);
    }
    
    static void Recursive(int current)
    {
        if( current == 1 )
        {
            for(int i = 1; i <= n; i++)
            {
                loops[current-1] = i;
                Recursive(current+1);
            }
            return;
        }
        else if( current == k+1 )
        {
            PrintLoops();
            return;
        }
        for(int i = loops[current-2]; i <= n; i++)
        {
            loops[current-1] = i;
            Recursive(current+1);
        }
        Console.WriteLine();
    }
    
    static void PrintLoops()
    {
        for(int i = 0; i < k; i++)
        {
            Console.Write("{0} ", loops[i]);
        }
        Console.WriteLine();
    }
}