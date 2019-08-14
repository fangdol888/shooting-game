using System;

namespace Shooting{
	public class Map{
		string wall = "▣";
		public static int x = 20,y = 20; //size;
		
		public Map(){
			showMap();
		}
		
		public void setPoint(int x, int y){
			Map.x = x; 
			Map.y = y;
			
		}
		
		public int getx(){return x;}
		public int gety(){return y;}
		
		public void showMap(){
			//draw wall
			for(int i = 0 ; i<= x;i++){
				Graphic.printPoint(i,0,wall);
				Graphic.printPoint(i,y,wall);
			}
			for(int i = 0; i < y;i++){
				Graphic.printPoint(0,i,wall);
				Graphic.printPoint(x,i,wall);
			}
		}
		
		public bool possiblePoint(int x, int y){
			if(x>1 && x < Map.x-1 && y>1 && y < Map.y){
				return true;
			}				
			else return true;
		}
	}
}

