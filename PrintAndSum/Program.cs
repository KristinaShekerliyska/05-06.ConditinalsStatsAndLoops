using System;

namespace PrintAndSum
{
	class Program
	{
		static void Main(string[] args)
		{
			int startNumber = int.Parse(Console.ReadLine());
			int endNumber = int.Parse(Console.ReadLine());
			string sequence = string.Empty;
			int sum = 0;

			for (int i = startNumber; i <= endNumber; i++)
			{
				sum += i;
				sequence += i.ToString() + " ";
			}
			Console.WriteLine(sequence);
			Console.WriteLine($"Sum: {sum}");
		}
	}
}
