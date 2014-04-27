using System;

class H
{
    static void Main()
    {
        int[] a = new int[5];
        Console.Write("Enter 5 numbers, each followed by ENTER:");
        
        for(int i = 0; i < 5; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        
        for(int i = 4; i > 0; i--)
        {
            for(int j = 0; j < i; j++)
            {
                if(a[j] > a[j+1])
                {
                    int tmp = a[j+1];
                    a[j+1] = a[j];
                    a[j] = tmp;
                }
            }
        }
        
        for(int i = 0; i < 5; i++)
        {
            Console.Write(a[i] + " ");
        }
        
        Console.ReadKey(true);
    }
}