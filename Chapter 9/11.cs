using System;
using System.Collections.Generic;

class h
{
    static void Main()
    {
        char choice = '0';
        while(choice != 'Q' && choice != 'q')
        {
            Console.WriteLine("Choose one of the following:");
            Console.WriteLine("(1) Reverse digits of number.");
            Console.WriteLine("(2) Calculate mean value.");
            Console.WriteLine("(3) Solve linear expression.");
            Console.WriteLine("(Q) to quit.");
            
            choice = Convert.ToChar(Console.ReadLine());
            switch(choice)
            {
                case '1':
                    ReverseDigits();
                    break;
                case '2':
                    Mean();
                    break;
                case '3':
                    Linear();
                    break;
                default:
                    if(choice != 'Q' && choice != 'q')
                      Console.WriteLine("Invalid menu option.");
                    break;
            }
        }
        Console.ReadKey(true);
    }
    
    static void ReverseDigits()
    {
        int a = 0;
        do
        {
            Console.Write("Enter positive integer:");
            a = int.Parse(Console.ReadLine());
            if(a < 0)
                Console.WriteLine("Integer must be positive.");
        } while(a < 0);
        
        int b = 0;
        while( a != 0 )
        {
            b = b*10 + a%10;
            a /= 10;
        }
        
        Console.WriteLine("Reverse is: {0}", b);
        Console.WriteLine();
    }
    
    static void Mean()
    {
        List<int> arr = new List<int>();
        int a;
    Loop:
        a = -1;
        Console.Write("Enter integers, each followed by ENTER. Enter 0 to end the sequence:");
        while( a != 0 )
        {
            a = int.Parse(Console.ReadLine());
            if( a != 0 )
                arr.Add(a);
        }
        if(arr.Count == 0)
        {
            Console.WriteLine("Sequence is empty. Try again.");
            goto Loop;
        }
        
        int mean = 0;
        foreach( int elem in arr )
        {
            mean += elem;
        }
        mean /= arr.Count;
        
        Console.WriteLine("Mean is: {0}", mean);
        Console.WriteLine();
        
    }
    
    static void Linear()
    {
        int a = -1;
        do
        {
            if( a == 0 )
                Console.WriteLine("Parameter A can't be 0.");
            Console.Write("Enter A:");
            a = int.Parse(Console.ReadLine());
        }while( a == 0 );
        
        Console.Write("Enter B:");
        int b = int.Parse(Console.ReadLine());
        
        int x = -b/a;
        Console.WriteLine("Answer is: {0}", x);
        Console.WriteLine();
    }
    
    
}

