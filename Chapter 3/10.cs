using System;

class H
{
    static void Main()
    {
        string tmp = "";
        while(tmp.Length != 4)
        {
            Console.Write("Enter a 4-digit number:");
            tmp = Console.ReadLine();
        }
        
        int a = int.Parse(tmp);
        
        int a1 = a % 10;
        a /= 10;
        
        int a2 = a % 10;
        a /= 10;
        
        int a3 = a%10;
        a /= 10;
        
        int a4 = a;
        a /= 10;
        
        int sum = a1 + a2 + a3 + a4;
        
        Console.WriteLine(sum);
        Console.WriteLine(a1 +""+ a2 +""+ a3 +""+ a4);
        Console.WriteLine(a1 +""+ a3 +""+ a2 +""+ a4);
        Console.WriteLine(a4 +""+ a2 +""+ a3 +""+ a1);
        
        
        Console.ReadKey(true);
    }
}