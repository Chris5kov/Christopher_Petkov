using System;

class h
{
    static void  Main()
    {
        int[] a = new int[] {3, 2, 3, 4, 2, 2, 4, 5, 6, 7};
        
        int sqtmp = a[0];
        int ctmp = 1;
        int seq = 0;
        int count = 0;
        
        for(int i = 1; i < a.Length; i++)
        {
            if( sqtmp + ctmp == a[i] )
                ctmp++;
            else
            {
                if( ctmp > count )
                {
                    count = ctmp;
                    seq = sqtmp;
                }
                sqtmp = a[i];
                ctmp = 1;
            }
            if( ctmp > count )
            {
                count = ctmp;
                seq = sqtmp;
            }
        }
        
        Console.Write("{");
        for(int i = 0; i < count; i++)
        {
            if( i == count - 1 )
            {
                Console.Write(seq+i+"}" + Environment.NewLine);
            }
            else
                Console.Write(seq+i+", ");
        }
        
        Console.ReadKey(true);
    }
}

