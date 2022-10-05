using System;

namespace Orders
{
	class Program
	{
		static void Main(string[] args)
		{
			int ordersCount = int.Parse(Console.ReadLine());
			decimal totalPrice = 0;
			while (ordersCount >= 1)
			{
				decimal capsulePrice = decimal.Parse(Console.ReadLine());
				int days = int.Parse(Console.ReadLine());
				int capsulesCount = int.Parse(Console.ReadLine());

				decimal price = days * capsulesCount * capsulePrice;
				Console.WriteLine($"The price for the coffee is: ${price:f2}");
				totalPrice += price;
				ordersCount--;
			}
			Console.WriteLine($"Total: ${totalPrice:f2}");
		}
	}
}
