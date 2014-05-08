using System;
using System.Collections.Generic;

class h
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        List<int> arr = new List<int>();
        
        while( a != 0 )
        {
            arr.Add( a%2 );
            a /= 2;
        }
        
        for(int i = arr.Count-1; i >= 0; i--)
        {
            Console.Write(arr[i]);
        }
        Console.ReadKey(true);
        
    }
}

