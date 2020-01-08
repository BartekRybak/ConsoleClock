using System;
using System.Threading;

namespace ShadeClock
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.Title = "ShadeClock";
			Console.CursorVisible = false;
			Console.SetWindowSize(59, 11);
			Console.SetBufferSize(59, 11);

			Clock clock = new Clock(0, 1);
	
			while (true) {
				Console.Clear();
				clock.Draw();
				Thread.Sleep(1000);
			}
		}
	}
}
