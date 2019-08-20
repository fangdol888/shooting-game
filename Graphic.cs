using System;

namespace Shooting{
	public static class Graphic{
		
		public static void drawMovedObject(){
			
		}
		public static void showStatus(ref Player pl){
			Console.SetCursorPosition(50,5);
			Console.Write("Score: {0}\n", pl.getScore());
		}
		public static void printPoint(int x, int y, string str){
			Console.SetCursorPosition(x*2,y);
			Console.Write(str);
		}
		public static void
	}
}

