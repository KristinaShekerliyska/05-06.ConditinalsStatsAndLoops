using System;

namespace VendingMachine
{
	class Program
	{
		static void Main(string[] args)
		{
			string money = string.Empty;
			double sum = 0;
			while (!(money = Console.ReadLine()).Equals("Start"))
			{ 
				switch (money)
				{
					case "0.1":
						sum += 0.1;
						break;
					case "0.2":
						sum += 0.2;
						break;
					case "0.5":
						sum += 0.5;
						break;
					case "1":
						sum += 1;
						break;
					case "2":
						sum += 2;
						break;
					default:
						Console.WriteLine($"Cannot accept {money}");
						break;
				}
			}
			string product = string.Empty;
			while (!(product = Console.ReadLine()).Equals("End"))
			{
				switch (product)
				{
					case "Nuts":
						if (sum >= 2)
						{
							sum -= 2;
							Console.WriteLine($"Purchased nuts");
						}
						else {
							Console.WriteLine("Sorry, not enough money");
						}
						break;
					case "Water":
						if (sum >= 0.7)
						{
							sum -= 0.7;
							Console.WriteLine($"Purchased water");
						}
						else
						{
							Console.WriteLine("Sorry, not enough money");
						}
						break;
					case "Crisps":
						if (sum >= 1.5)
						{
							sum -= 1.5;
							Console.WriteLine($"Purchased crisps");
						}
						else
						{
							Console.WriteLine("Sorry, not enough money");
						}
						break;
					case "Soda":
						if (sum >= 0.8)
						{
							sum -= 0.8;
							Console.WriteLine($"Purchased soda");
						}
						else
						{
							Console.WriteLine("Sorry, not enough money");
						}
						break;
					case "Coke":
						if (sum >= 1)
						{
							sum -=1;
							Console.WriteLine($"Purchased coke");
						}
						else
						{
							Console.WriteLine("Sorry, not enough money");
						}
						break;
					default:
						Console.WriteLine("Invalid product");
						break;
				}
			}
			string leftMoney = String.Format("{0:0.00}", sum);
			Console.WriteLine($"Change: {leftMoney}");
		}
	}
}
