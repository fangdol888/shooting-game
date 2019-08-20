using System;

namespace Shooting{
	public class Player{
		string shape = " △ ";
		int x,y; //point;
		int life = 3;
		int score=0;
		
		public Player(){
			this.x = Map.x/2;
			this.y = Map.y-1;
		}
		public void move(int dx, int dy){
			x+=dx;
			y+=dy;
		}
		
		public void shoot(){
			
		}
		
		public void addScore(int plus){
			score += plus;
		}
		
		public void dead(){
			life--;
			this.x = Map.x/2;
			this.y = Map.y-1;
		}
		public int getx(){return x;}
		public int gety(){return y;}
		public int getScore(){return score;}
		public string getShape(){return shape;}
		
	}
}

