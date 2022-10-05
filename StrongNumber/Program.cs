
namespace StrongNumber
{
	using System;
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			int copy = number;
			int factSum = 0;
			while (copy > 0)
			{
				int lastDigit = copy % 10;
				copy /= 10;
				int factorial = 1;
				for (int i = 2; i <= lastDigit; i++)
				{
					factorial *= i;
				}
				factSum += factorial;
			}

			if (factSum == number)
			{
				Console.WriteLine("yes");
			}
			else {

				Console.WriteLine("no");
			}
		}
	}
}
