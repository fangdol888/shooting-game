using System;

namespace Shooting{
	public static class Graphic(){
		public Graphic(){
			
		}
		public static void showStatus(ref Player pl){
			
		}
		public static void printPoint(int x, int y, string str){
			Console.SetCursorPosition(x*2,y);
			Console.Write(str);
		}
	}
}

