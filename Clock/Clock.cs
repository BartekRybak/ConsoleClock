using System;
namespace ShadeClock
{
	public class Clock
	{
		public int X;
		public int Y;

		public Clock(int x,int y)
		{
			X = x;
			Y = y;
		}

		public static string ParseTime(int time)
		{
			if (time.ToString().Length == 1)
			{
				return "0" + time;
			}
			else
			{
				return time.ToString();
			}
		}


		public void Draw()
		{
			// Godziny
			string parseHour = ParseTime(DateTime.Now.Hour);
			for (int i = 0; i < parseHour.Length; i++)
			{
				int d = (int)(parseHour[i] - '0');
				Digit.Draw(d,ConsoleColor.White, X + (i* Digit.Width) + 1, Y);
			}
			Digit.Draw(10, X + (Digit.Width * 2) + 1,Y);

			// Minuty
			string parseMinutes = ParseTime(DateTime.Now.Minute);
			for (int i = 0; i < parseMinutes.Length; i++)
			{
				int d = (int)(parseMinutes[i] - '0');
				int space = (Digit.Width * 2) + 3;
				Digit.Draw(d, ConsoleColor.White, X + (Digit.Width * i) + space, Y);
			}
			Digit.Draw(10, X + (Digit.Width * 4) + 3, Y);

			// Sekundy
			string parseSeconds = ParseTime(DateTime.Now.Second);
			for (int i = 0; i < parseSeconds.Length; i++)
			{
				int d = (int)(parseSeconds[i] - '0');
				int space = (Digit.Width * 4) + 5;
				Digit.Draw(d, ConsoleColor.White, X + (Digit.Width * i) + space, Y);
			}

			// Rysowanie Ramki

		}
	}
}
