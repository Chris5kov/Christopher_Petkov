using System;

class H
{
    static void Main()
    {
        int[] a = new int[20];
        
        for(int i = 0; i < a.Length; i++)
        {
            a[i] = i*5;
        }
        
        foreach (int b in a)
        {
            Console.Write(b + " ");
        }
        
        Console.ReadKey(true);
    }
}