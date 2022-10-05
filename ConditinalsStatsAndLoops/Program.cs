using System;

namespace ConditinalsStatsAndLoops
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());
			decimal avgGrade = decimal.Parse(Console.ReadLine());

			Console.WriteLine($"Name: {name}, Age: {age}, Grade: {avgGrade}");
		}
	}
}
