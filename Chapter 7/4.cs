using System;

class h
{
    static void Main()
    {
        int[] a = new int[] { 2, 1, 1, 2, 3, 3, 3, 2, 2, 2, 1 };
        
        int sqtmp = a[0],
            ctmp = 1,
            seq = 0,
            count = 0;
        
        for(int i = 1; i < a.Length; i++)
        {
            if( a[i] == sqtmp )
                ctmp++;
            else
            {
                if (ctmp > count)
                {
                    count = ctmp;
                    seq = sqtmp;
                }
                sqtmp = a[i];
                ctmp = 1;
            }
        }
        
        Console.Write("{");
        for(int i = 0; i < count; i++)
        {
            if(i == count-1)
                Console.Write(seq+"}" + Environment.NewLine);
            else
                Console.Write(seq+", ");
        }
        
        Console.ReadKey(true);
    }
}