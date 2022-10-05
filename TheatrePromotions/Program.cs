using System;

namespace TheatrePromotions
{
	class Program
	{
		static void Main(string[] args)
		{
			string typeOfDay = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());
			switch (typeOfDay)
			{
				case "Weekday":
					{
						if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
						{
							Console.Write("12$");
						}
						else if (age > 18 && age <= 64)
						{
							Console.Write("18$");
						}
						else
						{
							Console.Write("Error!");
						}
					}
					break;
				case "Weekend":
					{
						if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
						{
							Console.Write("15$");
						}
						else if (age > 18 && age <= 64)
						{
							Console.Write("20$");
						}
						else
						{
							Console.Write("Error!");
						}
					}
					break;
				case "Holiday":
					{
						if ((age >= 0 && age <= 18))
						{
							Console.Write("5$");
						}
						else if (age > 18 && age <= 64)
						{
							Console.Write("12$");
						}
						else if (age > 64 && age <= 122)
						{
							Console.Write("10$");
						}
						else
						{
							Console.Write("Error!");
						}
					}
					break;
			}
		}
	}
}
