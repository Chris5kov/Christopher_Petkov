using System;

class h
{
    public static int n = 9, // 1st matrix dimension
                      m = 9, // 2nd matrix dimension
                      N = n*m;
    public static int[,] a = new int[n,m]; // Th3 Ma3x ;
    public static int[,] g = new int[N+1,m+2]; // List of Neighbours
    public static int[] u = new int[N+1]; // array for used vertices
    public static int[] q = new int[N]; // the queue used for BFS
    public static int e,d;  //queue variables
    
    public static int t = 0; // # of trees
    public static int[] l = new int[N+1]; // l[i] - # of vertices of i-th tree
    public static int[,] forest = new int[N+1,N+1]; // forest[i,j] , j-th vertice of i-th forest
    
    public static int[,] color = new int[n+1,m+1];
    public static int biggest = 0; // biggest forest
    
    static void Main()
    {
        create_matrix();
    //    print_matrix();
        create_LN();
    //    print_LN();
        
        for(int i = 1; i <= N; i++)
        {
            if(u[i] == 0) 
                BFS(i);
        }
        
        find_biggest();
        print_biggest();
        
        Console.ReadKey(true);
    }
    
    static void BFS(int r) // Breath-first-search on r
    {
        int x,y;
        
        make_empty();
        enqueue(r);
        u[r] = 1;
        
        l[++t] = 1;
        forest[t,l[t]] = r;
        
        while(not_empty())
        {
            x = dequeue();
            for(int i = 1; i <= g[x,0]; i++)
                {
                y = g[x, i];
                int a_i = (x-1)/n;
                int a_j = (x-1)%n;
                int b_i = (y-1)/n;
                int b_j = (y-1)%n;
                if(a[ a_i,a_j ] == a[ b_i,b_j ])
                  {
                    if(u[y] == 0)
                    {
                        enqueue(y);
                        u[y] = 1;
                        forest[t, ++l[t]] = y;
                    }
                  }
                }
        }
        
        
    }
    
    static void find_biggest()
    {
        
        for(int i = 1; i <= t; i++)
        {
            if(l[i] > biggest)
                biggest = i;
        }
        
        for(int i = 1; i <= l[biggest]; i++)
        {
            int x = forest[biggest,i];
            int a_i = (x-1)/n;
            int a_j = (x-1)%n;
            
            color[a_i,a_j] = 1;
        }
    }
    static void print_biggest()
    {
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                if(color[i,j] == 1)
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("{0,2} ", a[i,j]);
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
    //The queue-------------------------------------
    static void make_empty()
    {
        e = -1;
        d = 0;
    }
    static void enqueue(int x)
    {
        q[++e] = x;
    }
    static int dequeue()
    {
        return q[d++];
    }
    static bool not_empty()
    {
        return e >= d;
    }
    //-----------------------------------------------END---
    
    static void create_matrix()
    {
        Random rand = new Random();
        int test = 1;
        for(int i = 0; i < a.GetLength(0); i++)
        {
            for(int j = 0; j < a.GetLength(1); j++)
            { 
                a[i,j] = rand.Next(1,5);
            }
        }
    }
    static void print_matrix()
    {
        for(int i = 0; i < a.GetLength(0); i++)
        {
            for(int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write("{0,2} ", a[i,j]);
            }
            Console.WriteLine();
        }
    }
    static void create_LN() // creates graph representation using 
    {                       // list of neighbours
        for(int i = 0; i < n; i++) // loops through all vertices
        {                          //
            for(int j = 0; j < m; j++)
            {
                if( ((i==0)||(i==n-1))^((j==0)||(j==m-1)) )
                {                 // if vertice is on edge of ma3x
                    g[1+m*i+j,0] = 3;  // it has 3 neighbours
                    if(i==0)
                    {
                        g[1+m*i+j,1] = m*i+j;
                        g[1+m*i+j,2] = 2+m*i+j;
                        g[1+m*i+j,3] = 1+m*(i+1)+j;
                    }
                    else if(i==n-1)
                    {
                        g[1+m*i+j,1] = 1+m*(i-1)+j;
                        g[1+m*i+j,2] = m*i+j;
                        g[1+m*i+j,3] = 2+m*i+j;
                    }
                    else if(j==0)
                    {
                        g[1+m*i+j,1] = 1+m*(i-1)+j;
                        g[1+m*i+j,2] = 2+m*i+j;
                        g[1+m*i+j,3] = 1+m*(i+1)+j;
                    }
                    else if(j==n-1)
                    {
                        g[1+m*i+j,1] = 1+m*(i-1)+j;
                        g[1+m*i+j,2] = m*i+j;
                        g[1+m*i+j,3] = 1+m*(i+1)+j;
                    }
                    
                }
                else if ( ((i==0)||(i==n-1))&&((j==0)||(j==m-1)) )
                {                  //if vertice is on corner of ma3x
                    g[1+m*i+j,0] = 2; // it has 2 neighbours
                    if(i==0)
                    {
                        if(j==0)
                        {
                            g[1+m*i+j,1] = 2+m*i+j;
                            g[1+m*i+j,2] = 1+m*(i+1)+j;
                        }
                        else
                        {
                            g[1+m*i+j,1] = m*i+j;
                            g[1+m*i+j,2] = 1+m*(i+1)+j;
                        }
                    }
                    else
                    {
                        if(j==0)
                        {
                            g[1+m*i+j,1] = 1+m*(i-1)+j;
                            g[1+m*i+j,2] = 2+m*i+j;
                        }
                        else
                        {
                            g[1+m*i+j,1] = 1+m*(i-1)+j;
                            g[1+m*i+j,2] = m*i+j;
                        }
                    }
                }
                else
                {       // if nothing else, vertice is in middle
                    g[1+m*i+j,0] = 4; // and has 4 neighboursr
                    g[1+m*i+j,1] = 1+m*(i-1)+j;
                    g[1+m*i+j,2] = m*i+j;
                    g[1+m*i+j,3] = 2+m*i+j;
                    g[1+m*i+j,4] = 1+m*(i+1)+j;
                }
            }
        }
    }
    static void print_LN()
    {
        for(int i = 1; i < g.GetLength(0); i++)
        {
            for(int j = 0; j < g.GetLength(1); j++)
            {
                if(j == 0)
                    Console.ForegroundColor = ConsoleColor.Red;
                else if(g[i,j] == 0)
                    Console.ResetColor();
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("{0,2} ", g[i,j]);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}