using System;

namespace MultiplicationTable2
{
	class Program
	{
		static void Main(string[] args)
		{
			int theNumber = int.Parse(Console.ReadLine());
			int times = int.Parse(Console.ReadLine());
			int product = 0;
			if (times > 10)
			{
				product = theNumber * times;
				Console.WriteLine($"{theNumber} X {times} = {product}");
			}
			else
			{
				while (times <= 10)
				{
					product = theNumber * times;
					Console.WriteLine($"{theNumber} X {times} = {product}");
					times++;
				}
			}
		}
	}
}
