using System;

namespace Login
{
	class Program
	{
		static void Main(string[] args)
		{
			string username = Console.ReadLine();
			string pass = string.Empty;
			int attempts = 1;

			for (int i = username.Length - 1; i >= 0; i--)
			{
				char current = username[i];
				pass += current;
			}

			string input;

			while (!(input = Console.ReadLine()).Equals(pass))
			{
				if (attempts >=4)
				{
					Console.WriteLine($"User {username} blocked!");
					break;
				}
				else
				{
					Console.WriteLine("Incorrect password. Try again.");
				}
				attempts++;
			}
			if (attempts < 4)
				Console.WriteLine($"User {username} logged in.");

		}
	}
}
