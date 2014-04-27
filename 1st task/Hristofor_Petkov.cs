
using System;
using System.Collections.Generic;

class Hristofor_Petkov
{
	static void Main()
	{
		int[] set = { 6, 2, 4, 3, 5, 1 };
		
		Console.Write("Faculty number: ");
		foreach (int element in set)
		{
			Console.Write("{0} ", element);
		}
		Console.Write("\nPlease enter the sum: ");
		
		string line = Console.ReadLine();
		int W = int.Parse(line);
		
		int n = set.Length;
		
		List<int> subset = new List<int>();
		
		for(int i = 0; i < Math.Pow(2,n); i++)
		{
			int m = i;
			while(m > 1)
			{
				subset.Add(m%2);
				m = m / 2;
			}
			subset.Add(m);
			int sum = 0;
			for(int j = 0; j < subset.Count; j++)
			{
				if(subset[j] == 1)
				{
					sum += set[j];
				}
			}
			if(sum == W)
			{
				for(int k = 0; k < subset.Count; k++)
				{
					if(subset[k] == 1)
					{
						Console.Write(set[k]);
						Console.Write(" ");
					}
				}
				Console.WriteLine();
			}
			subset.Clear();
		}
		Console.ReadKey(true);
	}
}
