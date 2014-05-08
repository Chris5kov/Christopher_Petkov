using System;

class h
{
    static void Main()
    {
        string a = Console.ReadLine();
        
        int n = a.Length;
        
        int sum = 0;
        
        for(int i = n-1; i >= 0; i--)
        {
            if( (a[i] > 64 && a[i] < 91) || ( a[i] > 96 && a[i] < 123 ) )
            {
                switch(a[i])
                {
                    case 'A':
                    case 'a':
                        sum += 10 * Convert.ToInt32(Math.Pow(16,n-i-1));
                        break;
                    case 'B':
                    case 'b':
                        sum += 11 * Convert.ToInt32(Math.Pow(16,n-i-1));
                        break;                      
                    case 'C':
                    case 'c':
                        sum += 12 * Convert.ToInt32(Math.Pow(16,n-i-1));
                        break;
                    case 'D':
                    case 'd':
                        sum += 13 * Convert.ToInt32(Math.Pow(16,n-i-1));
                        break;
                    case 'E':
                    case 'e':
                        sum += 14 * Convert.ToInt32(Math.Pow(16,n-i-1));
                        break;
                    case 'F':
                    case 'f':
                        sum += 15 * Convert.ToInt32(Math.Pow(16,n-i-1));
                        break;
                }
            }
            else
                sum += a[i] * Convert.ToInt32(Math.Pow(16,n-i+1));
        }
        
        Console.WriteLine(sum);
        Console.ReadKey();
    }
}

