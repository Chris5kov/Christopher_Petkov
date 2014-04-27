using System;

class H
{
    static void Main()
    {
        Console.Write("Enter N:");
        int n = int.Parse(Console.ReadLine());
        
        int[,] a = new int[n,n];
        int k = n%2;
        int c = 1;
        
        for(int i = 0; i-k < n/2; i++)
        {
            for(int j = i; j < n-i; j++)
            {
                a[i,j] = c++;
            }
            for(int j = i+1; j < n-i; j++)
            {
                a[j,n-1-i] = c++;
            }
            for(int j = n-2-i; j >= i; j--)
            {
                a[n-1-i,j] = c++;
            }
            for(int j = n-2-i; j > i; j--)
            {
                a[j,i] = c++;
            }
        }
        
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                Console.Write("{0,3}" ,a[i,j]);
            }
            Console.WriteLine();
        }
        
        Console.ReadKey(true);
    }
}