using System;

namespace BackIn30Mins
{
	class Program
	{
		static void Main(string[] args)
		{
			int hour = int.Parse(Console.ReadLine());
			int mins = int.Parse(Console.ReadLine()) + 30;
			if (mins > 59)
			{
				hour+=1;
				mins -= 60;
			}
			if (hour > 23)
			{
				hour = 0;
			}

			Console.WriteLine($"{hour}:{mins:D2}");
		}
	}
}
