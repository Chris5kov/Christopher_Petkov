using System;

class h
{
    static void Main()
    {
        Console.Write("Enter N:");
        int n = int.Parse(Console.ReadLine());
        
        int[,] a = new int[n,n];
        int[,] b = new int[n,n];
        int[,] c = new int[n,n];
        int[,] d = new int[n,n];
        
        int x = 1;
        
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                a[j,i] = x++;
            }
        }
        x = 1;
        
        for(int i = 0; i < n; i = i+2)
        {
            for(int j = 0; j < n; j++)
            {
                b[j,i] = x++;
            }
            if(n%2 == 0 || i != n-1)
            {
                for(int h = n-1; h >= 0; h--)
                {
                    b[h,i+1] = x++;
                }
            }
        }
        x = 1;
        
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < i+1; j++)
            {
                c[n-1-i+j,j] = x++;
            }
        }
        for(int i = 1; i < n; i++)
        {
            for(int j = 0; j < n-i; j++)
            {
            c[j,i+j] = x++;
            }
        }
        x = 1;
        
        for(int i = 0; i < n/2+n%2; i++)
        {
            for(int j = i; j < n-i; j++)
            {
                d[j,i] = x++;
            }
            for(int j = i+1; j < n-i; j++)
            {
                d[n-1-i,j] = x++;
            }
            for(int j = n-2-i; j >= i; j--)
            {
                d[j,n-1-i] = x++;
            }
            for(int j = n-2-i; j > i; j--)
            {
                d[i,j] = x++;
            }
        }
        x = 1;
        
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                Console.Write("{0,2} ", a[i,j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                Console.Write("{0,2} ", b[i,j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                Console.Write("{0,2} ", c[i,j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                Console.Write("{0,2} ", d[i,j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        
        Console.ReadKey(true);
    }
}

