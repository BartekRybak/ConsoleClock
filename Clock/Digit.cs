using System;
namespace ShadeClock
{
	public class Digit
	{
		public int digit;

		public static int Width = 9;
		public static int Height = 9;

		public Digit(int d)
		{
			digit = d;
		}

		public static void Draw(int digit,ConsoleColor color,int _x, int _y)
		{
			string[] dig = GetStringArray(digit);
			Console.ForegroundColor = color;
			for (int y = 0; y < dig.Length; y++)
			{
				for (int x = 0; x < dig[y].Length; x++)
				{
					
					Console.SetCursorPosition(_x + x,_y + y);
					Console.Write(dig[y][x]);

				}
			}
			Console.ResetColor();
		}

		public static void Draw(int digit, int _x, int _y)
		{
			string[] dig = GetStringArray(digit);
			for (int y = 0; y < dig.Length; y++)
			{
				for (int x = 0; x < dig[y].Length; x++)
				{
					Console.SetCursorPosition(_x + x, _y + y);
					Console.Write(dig[y][x]);					
				}
			}
		}

		public static string[] GetStringArray(int digit)
		{
			switch (digit)
			{
				case 0:
					return new string[] {
						"████████",
						"█      █",
						"█      █",
						"█      █",
						"█      █",
						"█      █",
						"█      █",
						"█      █",
						"████████"
					};

				case 1:
					return new string[] {
						"█",
						"█",
						"█",
						"█",
						"█",
						"█",
						"█",
						"█",
						"█"
					};

				case 2:
					return new string[] { 	
						"████████",
						"       █",
						"       █",
						"       █",
						"████████",
						"█       ",
						"█       ",
						"█       ",
						"████████"
					};
				case 3:
					return new string[] {
						"████████",
						"       █",
						"       █",
						"       █",
						"████████",
						"       █",
						"       █",
						"       █",
						"████████"
					};
				case 4:
					return new string[] { 
						"█      █",
						"█      █",
						"█      █",
						"█      █",
						"████████",
						"       █",
						"       █",
						"       █",
						"       █",
					};
				case 5:
					return new string[] {
						"████████",
						"█       ",
						"█       ",
						"█       ",
						"████████",
						"       █",
						"       █",
						"       █",
						"████████"
					};

				case 6:
					return new string[] { 
						"████████",
						"█       ",
						"█       ",
						"█       ",
						"████████",
						"█      █",
						"█      █",
						"█      █",
						"████████"
					};

				case 7:
					return new string[] {
						"███████",
						"      █",
						"      █",
						"      █",
						"      █",
						"      █",
						"      █",
						"      █",
						"      █"
					};

				case 8:
					return new string[] {
						"████████",
						"█      █",
						"█      █",
						"█      █",
						"████████",
						"█      █",
						"█      █",
						"█      █",
						"████████"
					};

				case 9:
					return new string[] {
						"████████",
						"█      █",
						"█      █",
						"█      █",
						"████████",
						"       █",
						"       █",
						"       █",
						"████████"
					};

				case 10:
					return new string[] {
						" ",
						" ",
						"█",
						"█",
						" ",
						"█",
						"█",
						" ",
						" " 
					};
					
				default: return new string[] {
						"████████",
						"█      █",
						"█      █",
						"█      █",
						"████████",
						"       █",
						"       █",
						"       █",
						"████████"
					};
			}
		}
	}
}
