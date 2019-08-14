using System;

namespace Shooting{
	public class Bullet{
		string shape = "｜";
		int x,y; //point;
		int own;//owner 0:player 1:enemy
		bool exist = false;
		int nframe=15; //frame cycle
		int nStay;//const frame size
		
		
		public Bullet(int x=0, int y=0, int own=0){
			this.x = x;
			this.y = y;
			this.own = own;
			nStay = nframe;
		}
		
		public void shoot(int x ,int y ,int own){
			this.x = x;
			this.y = y;
			this.own = own;
			exist = true;
		}
		
		public void move(){
			switch(own){
				case 0:
				y--;
				break;
				case 1:
				y++;
				break;
			}
		}
		
		public bool countFrame(){ //이동 관리
			if(nframe == 0){
				nframe = nStay;
				return true;
			}else
			{
				nframe--;
				return false;
			}
		}
		
		public void collision(){
			exist = false;
		}
		
		public int getx(){return x;}
		public int gety(){return y;}
		public string getShape(){return shape;}
	}
}

