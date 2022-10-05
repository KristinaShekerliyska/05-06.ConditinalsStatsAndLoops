using System;
using System.Linq;

namespace A_01_SortNumbres
{
	class Program
	{
		static void Main(string[] args)
		{
			//int num1 = int.Parse(Console.ReadLine());
			//int num2 = int.Parse(Console.ReadLine());
			//int num3 = int.Parse(Console.ReadLine());

			int[] arr = new int[3];
			for (int i = 0; i <= 2; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
			}
			arr = arr.OrderByDescending(c => c).ToArray();
			//for (int i = 0; i <= 2; i++)
			//{
			//	for (int j = 0; j <= 2; j++)
			//	{
			//		if (arr[j] < arr[j + 1])
			//		{
			//			int temp = arr[j];
			//			arr[j] = arr[j + 1];
			//			arr[j + 1] = temp;
			//		}

			//	}
			//}

			for (int i = 0; i <= 2; i++)
			{
				Console.WriteLine(arr[i]);
			}
		}
	}
}
