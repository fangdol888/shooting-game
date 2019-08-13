using System;

namespace Shooting{
	public class Map(){
		string wall = "▣";
		public static const int x = 20,y = 20; //size;
		int[,] status = new int[y,x];
		
		public Map(){
		
		
		}
		
		public int setPoint(int x, int y){
			this.x = x; 
			this.y = y;
		}
		
		public int getx(){return x;}
		public int gety(){return y;}
		
		public void showMap(){
			for(int i = 0 ; i< x;i++){
				for(int j = 0 ; j < y;j++){
					
				}
			}
		}
	}
}

