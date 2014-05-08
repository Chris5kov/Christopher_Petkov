using System;

class h
{
    static void Main()
    {
        string a = Console.ReadLine();
        string b = "";
        
        int n = a.Length;
        
        for (int i = 0; i < n; i++)
        {
            if( ( a[i] > 64 && a[i] < 91 )||( a[i] > 96 && a[i] < 123 ) )
            {
                switch(a[i])
                {
                case 'A':
                case 'a':
                    b += Convert.ToString(10,2);
                    break;
                case 'B':
                case 'b':
                    b += Convert.ToString(11,2);
                    break;
                case 'C':
                case 'c':
                    b += Convert.ToString(12,2);
                    break;
                case 'D':
                case 'd':
                    b += Convert.ToString(13,2);
                    break;
                case 'E':
                case 'e':
                    b += Convert.ToString(14,2);
                    break;
                case 'F':
                case 'f':
                    b += Convert.ToString(15,2);
                    break;
                default:
                    break;
                }
            }
            else
            {
                int tmp = int.Parse(Convert.ToString(a[i]));
                b += Convert.ToString(tmp,2);
            }
        }
        
        Console.WriteLine(b);
        Console.ReadKey(true);
    }
}

