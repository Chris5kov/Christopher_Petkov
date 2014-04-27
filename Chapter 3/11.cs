using System;

class H
{
    static void Main()
    {
        Console.Write("Enter number:");
        int a = int.Parse(Console.ReadLine());
        
        string n = Convert.ToString(a,2);
        
        
        Console.Write("Enter position:");
        int p = int.Parse(Console.ReadLine());
        
        Console.WriteLine(n[n.Length - p]);
        
        Console.ReadKey(true);
        
    }
}

