using System;
using System.Collections.Generic;

class Sorting
{
    static void Main()
    {
        List<int> arr = new List<int>();
        
        Console.Write("Enter sequence, 'q' to stop:");
        int a;
        char chk = 'a';
        while( chk != 'q')
        {
            chk = Convert.ToChar(Console.ReadLine());
            if(chk != 'q')
                arr.Add(int.Parse(Convert.ToString(chk)));
        }
        
        Console.Write("[0] for Ascending sort" + Environment.NewLine + "[1] for Descending sort : ");
        int c = int.Parse(Console.ReadLine());
        
        Sort(arr,c);
        
        foreach(int el in arr)
        {
            Console.Write("{0} ", el);
        }
        Console.ReadKey(true);
    }
    
    static void Sort(List<int> arr, int c)
    {
        int tmp;
        for(int i = 0; i < arr.Count; i++)
        {
            if(c == 1)
                tmp = Max(arr,i);
            else
                tmp = Min(arr,i);
            Swap(arr,i,tmp);
        }
    }
    
    static int Max(List<int> arr, int i)
    {
        int max = arr[i];
        int maxindx = i;
        for(int j = i+1; j < arr.Count; j++)
        {
            if( arr[j] > max )
            {
                max = arr[j];
                maxindx = j;
            }
        }
        return maxindx;
    }
    
    static int Min(List<int> arr, int i)
    {
        int min = arr[i];
        int minindx = i;
        for(int j = i+1; j < arr.Count; j++)
        {
            if( arr[j] < min )
            {
                min = arr[j];
                minindx = j;
            }
        }
        return minindx;
    }
    
    static void Swap(List<int> arr, int i, int j)
    {
        int tmp = arr[i];
        arr[i] = arr[j];
        arr[j] = tmp;
    }
}

