namespace Vacation
{
	using System;
	class Program
	{
		static void Main(string[] args)
		{
			int peopleCount = int.Parse(Console.ReadLine());
			string groupType = Console.ReadLine();
			string day = Console.ReadLine();
			double price = 0;

			switch (groupType)
			{
				case "Students":
					switch (day)
					{
						case "Friday":
							price = peopleCount * 8.45;
							break;
						case "Saturday":
							price = peopleCount * 9.80;
							break;
						case "Sunday":
							price = peopleCount * 10.46;
							break;
					}
					if (peopleCount >= 30)
					{
						price = price - (price * 0.15);
					}
					break;
				case "Business":
					if (peopleCount >= 100)
					{
						peopleCount = peopleCount - 10;
					}
					switch (day)
					{
						case "Friday":
							price = peopleCount * 10.90;
							break;
						case "Saturday":
							price = peopleCount * 15.60;
							break;
						case "Sunday":
							price = peopleCount * 16;
							break;
					}
					break;
				case "Regular":
					switch (day)
					{
						case "Friday":
							price = peopleCount * 15;
							break;
						case "Saturday":
							price = peopleCount * 20;
							break;
						case "Sunday":
							price = peopleCount * 22.50;
							break;
					}
					if (peopleCount >= 10 && peopleCount <= 20)
					{
						price = price - (price * 0.05);
					}
					break;

			}
			string totalprice = String.Format("{0:0.00}", price);
			Console.WriteLine($"Total price: {totalprice}");

		}
	}
}
