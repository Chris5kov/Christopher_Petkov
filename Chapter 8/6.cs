using System;
using System.Collections.Generic;

class h
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        List<int> arr = new List<int>();
        
        while( a!= 0 )
        {
            arr.Add( a%16 );
            a /= 16;
        }
        
        for(int i = arr.Count-1; i >= 0; i--)
        {
            if(arr[i] > 9)
            {
                switch(arr[i])
                {
                    case 10:
                        Console.Write("A");
                        break;
                    case 11:
                        Console.Write("B");
                        break;
                    case 12:
                        Console.Write("C");
                        break;
                    case 13:
                        Console.Write("D");
                        break;
                    case 14:
                        Console.Write("E");
                        break;
                    case 15:
                        Console.Write("F");
                        break;
                    default:
                        break;
                }
            }
            else
                Console.Write(arr[i]);
        }
        
        
        Console.ReadKey(true);
    }
}