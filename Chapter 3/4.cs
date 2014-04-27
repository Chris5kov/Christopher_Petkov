using System;

class H
{
    static void Main()
    {
        
        int a = int.Parse(Console.ReadLine());
        
        string b = Convert.ToString(a,2);

        if(b[b.Length-3] == 1)
            Console.WriteLine("3rd bit is 1.");
        else 
            Console.WriteLine("3rd bit is 0.");
        
        Console.ReadKey(true);
    }
}

