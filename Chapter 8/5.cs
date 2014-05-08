using System;

class h
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        
        int sum = 0;
        int tmp = 0;
        int b;
        
        while( a!=0 )
        {
            
            sum += (a%10) * Convert.ToInt32(Math.Pow(2,tmp)) ;
            tmp++;
            a /= 10;
        }
        
        Console.WriteLine(sum);
        
        Console.ReadKey(true);
    }
}

