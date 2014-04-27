using System;
	
class H
{
	    
	
	static void Main()
    {
	    Console.Write("Enter an integer: ");
	    int a = int.Parse(Console.ReadLine());
	    
	    if( a%2 == 0 )
	        Console.WriteLine("Number is even.");
	    else 
	        Console.WriteLine("Number is odd.");
	    Console.ReadKey(true);
    }
	
}

