using System;

namespace Shooting{
	public class Enemy(){
		string shape = " ▼ ";
		int x,y; //point;
		int dir = 1 ; //0:left, 1: right;
		int nframe= 60;
		int nStay = nframe;
		int exist = false;
		
		public Enemy(int x, int y){
			this.x = x;
			this.y = y;
			exist = true;
		}
		public newEnemy(int x, int y){
			this.x = x;
			this.y = y;
			exist = true;
		}
		
		public void dead(){
			
			exist=false;
		}
		
		public void move(){
				switch(dir){
					case 0:
					if(x-1<=0){
						y--;
					}
					else x--;
					break;
					
					case 1:
					if(x+1<Map.x) y--;
					else x++;
					break;
				}
		}
		
		public bool countFrame(){
			if(nframe == 0){
				nframe = nStay;
				return true;
			}else
			{
				nframe--;
				return false;
			}
		}
		
		public int getx(){return x;}
		public int gety(){return y;}
		public string getShape(){return shape;}
	}
}

