using System;

namespace PadawanEquipment
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal amount = decimal.Parse(Console.ReadLine());
			int studentsNumber = int.Parse(Console.ReadLine());
			decimal lightsaberPrice = decimal.Parse(Console.ReadLine());
			decimal robePrice = decimal.Parse(Console.ReadLine());
			decimal beltPrice = decimal.Parse(Console.ReadLine());

			int sabresCount = studentsNumber + (int)Math.Ceiling(((double)studentsNumber * 0.1));

			int freeBelts = studentsNumber / 6;
			decimal totalBeltPrice = ((studentsNumber - freeBelts) * beltPrice);

			decimal totalPrice = sabresCount * lightsaberPrice + totalBeltPrice + robePrice * studentsNumber;
			string total = String.Format("{0:0.00}", totalPrice);
			if (totalPrice <= amount)
			{
				Console.WriteLine($"The money is enough - it would cost {total}lv.");
			}
			else
			{
				decimal neededMoney = totalPrice - amount;
				Console.WriteLine($"John will need {neededMoney:f2}lv more.");
			}

		}
	}
}
