using System;
using System.Diagnostics;

namespace Array_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            var clock = new Stopwatch();
			clock.Start();
			
			int[] array = new int[2000000000];
			
			for(int i = 0; i < 10000000; i++)
			{
				firstElement(array);
			}
			clock.Stop();
			
			Console.WriteLine($"Tiempo Ejecución: "+ clock.ElapsedMilliseconds + "ms");
			
        }
		
		static public int[] firstElement(int[] array)
		{
			array[0] = 26;
			return array;
		}
		static public int[] secondElement(int[] array)
		{
			
			array[array.Length-1] = 26;
			return array;
		}	
    }
}
