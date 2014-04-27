using System;

class h
{
    static void Main()
    {
        int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int sval;
        int m = a.Length/2;
        bool found = false;
        
        Console.Write("Enter search value <1-9>:");
        sval = int.Parse(Console.ReadLine());
        
        if( sval < m )
        {
            for(int i = m-1; i >= 0; i--)
            {
                if(a[i] == sval)
                {
                    Console.WriteLine("Found {0}!", sval);
                    found = true;
                }
            }
        }
        else
        {
            for(int i = m; i < a.Length; i++)
            {
                if(a[i] == sval)
                {
                    Console.WriteLine("Found {0}!", sval);
                    found = true;
                }
            }
        }
        if(!found)
            Console.WriteLine("Not found.");
        
        Console.ReadKey(true);
    }
}

