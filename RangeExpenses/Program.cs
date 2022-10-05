using System;

namespace RageExpenses
{
	class Program
	{
		static void Main(string[] args)
		{
			int lostGamesCount = int.Parse(Console.ReadLine());
			decimal headsetPrice = decimal.Parse(Console.ReadLine());
			decimal mousePrice = decimal.Parse(Console.ReadLine());
			decimal keyboardPrice = decimal.Parse(Console.ReadLine());
			decimal displayPrice = decimal.Parse(Console.ReadLine());

			int headsetTrash = lostGamesCount / 2;
			int mouseTrash = lostGamesCount / 3;
			int keyboardTrash = lostGamesCount / 6;
			int displayTrash = lostGamesCount / 12;

			decimal expenses = headsetPrice * headsetTrash + mousePrice * mouseTrash + keyboardPrice * keyboardTrash + displayPrice * displayTrash;
			//string total = String.Format("{0:0.00}", expenses);
			Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
		}
	}
}
