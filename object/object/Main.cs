using System;

namespace object1
{
	
	class MainClass
	{
		
		public static void Main(string[] args)
		{
			
			#if false
			Person p=new Person ();
			Person p1=new Person ();
			p.Age=20;
			p.Name ="wangwu";
			p.setname("zhaoliu");
			Console.WriteLine (p.Age );
			Console.WriteLine (p.Name );

			Per cp=new Per ();
			cp.name="zhangsan";
			cp.nickname="gaga";
			cp.age=22;
			cp.sex=true;
			cp.height =1.62f;
			cp.eat ();
			cp.message ();
			#endif
			
			
			#if false
			Person p=new Person ();
			p.age=22;
			p.sex=false;
			p.weight =62.2f;
			p.name ="cuihua";
			p.say ();
			p.loseweight ();
			Console.WriteLine (p.weight);
			#endif
			
			
			#if false
			Bank one=new Bank ();
			//one.message ();
			one.cunkuan ();
			//one.qukuan ();
			one.message ();
			#endif
			
			
			#if false
			Point p=new Point ();
			p.x=32;
			p.y=43;
			p.Display();
			#endif
			
			
			#if false
			Circle c=new Circle ();
			c.GetO();
			c.SetR ();
			c.MoveTo ();
			c.Display ();
			#endif
			
			
			
			#if false
			Area trieple=new Area ();
			trieple .d=2f;
			trieple .g=4f;
			trieple .area(trieple .d,trieple .g);
			
			
			Area circle=new Area ();
			circle .r=4f;
			circle .area(circle .r);
			
			
			Area quad=new Area ();
			quad.sd=4;
			quad.xd=5;
			quad.tg=3;
			quad.area(quad.sd,quad.xd,quad.tg);
			#endif
			
			
			
			#if false
			Student one=new Student ();
			one.name="zhangsan";
			one.sex="male";
			one.chscore =90f;
			one.mathscore =95f;
			one.enscore =80f;
			one.say ();
			one.allscores();
			one.generalscores();

			/*Student two=new Student ();
			two.name="xiaolan";
			two.sex="female";
			two.chscore =95f;
			two.mathscore =85f;
			two.enscore =100f;
			two.say ();
			two.allscores();
			two.generalscores();*/
			#endif

			
			
			//随机数三道练习
			#if false
			float[] score=new float [30];
			Random r=new Random ();
			float ger=0f;
			for(int i=0;i<30;i++)
			{
				score[i]=(float)r.Next(1,101);
				ger+=score[i];
				Console.Write (score[i]+" ");
			}
			Console.WriteLine ();
			Console.WriteLine ("the general scores is:"+ger/30);
			#endif
			
			#if false
			Random r=new Random ();
			int t=r.Next (0,101);
			Console.WriteLine ("input a number");
			while(true)
			{
				string s=Console.ReadLine ();
				int s1=Convert.ToInt32(s);
				if(s1>t)
				{
					Console.WriteLine ("your number is bigger");
				}
				else if(s1<t)
				{
					Console.WriteLine ("your number is smaller");
				}
				else 
				{
					Console.WriteLine("congratulation!the number is {0} ",t);
					break ;
				}
				if(s=="q")
					break ;
			}
			#endif
			
			#if false
			Random R=new Random ();
			int[] s={1,2,3,4,5,6};
			int[] Time=new int [6];
			for(int i=0;i<100;i++)
			{
				int j=R.Next (1,7);
				foreach(int t in s)
				{
					if(t==j)
						Time[(t-1)]++;
				}
			}
			for(int i=0;i<6;i++)
			{
				Console.WriteLine ("number {0} have appeared {1} times",i+1,Time[i]);
			}
			#endif
			
			
			
			
		}
	}

	#if false
	class Person
	{
		protected  int age;
		private string name;
		public int Age
		{
			get
			{
				return age;
			}
			set
			{
				this.age=value;
			}
		}
		public void setname(string n)
		{
			name=n;
		}
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				this.name=value;
			}
		}

	}

	class Per
	{
		public   int age;
		public   string name;
		public  string nickname;
		public  bool sex;
		public   float height;
		public void eat()
		{
			Console.WriteLine("eating");
		}
		public void swim()
		{
			Console.WriteLine ("swimming");
		}
		public void message()
		{
			Console.WriteLine (name);
			Console.WriteLine (sex);
			Console.WriteLine (height);
			Console.WriteLine (age);
			Console.WriteLine (nickname);
		}
	}
	#endif
	
	

	#if false
	class Person
	{
		public string name;
		public bool sex;
		public int age;
		public float weight;
		public void say()
		{
			Console.WriteLine ("hello");
		}
		public void walk()
		{
			Console.WriteLine ("walking");
		}
		public void eat()
		{
			Console.WriteLine ("eating");
			weight+=1;
		}
		public void loseweight()
		{
			Console.WriteLine ("fat lower");
			weight-=1;
		}
	}
	#endif

	

	#if false
	class Bank
	{
		string name="lisi";
		int id=123456;
		int ip=000000;
		float tub=100.0f;
		public void qukuan()
		{
			Console.WriteLine ("请输入密码");
			string account=Console.ReadLine ();
			int account1=Convert.ToInt32 (account);
			if(account1==ip&&tub>0)
			{
				Console.WriteLine ("请输入取款金额");
				string s=Console.ReadLine();
				int t=Convert.ToInt32(s);
				if(tub>=t)
				{
					tub-=t;
					Console.WriteLine ("you have getted {0} yuan",s);
				}
				else
				Console.WriteLine("余额不足");
			}
			else
				Console.WriteLine ("密码错误");
		}
		public void message()
		{
			Console.WriteLine ("name:"+name);
			Console.WriteLine ("id:"+id);
			Console.WriteLine ("tub:"+tub);
		}
		public void cunkuan()
		{
			Console.WriteLine ("请输入密码");
			string account=Console.ReadLine ();
			int account1=Convert.ToInt32 (account);
			if(account1==ip)
			{
				Console.WriteLine ("请输入存款金额");
				string s=Console.ReadLine();
				int t=Convert.ToInt32(s);
				tub+=t;
				Console.WriteLine ("you have saveed {0} yuan",s);
			}
			else
				Console.WriteLine ("密码错误");

		}

	}
	#endif
	
	
	
	
	#if false
	class Point
	{
		public double x;
		public double y;
		public void Display()
		{
			Console.WriteLine ("("+x+","+y+")");
		}
	}


	class Circle
	{
		public double R;
		Point O=new Point ();
		public void GetO()
		{
			Point O=new Point ();
			O.Display();
		}
		public void GetR()
		{
			string s=Console.ReadLine ();
			double t=Convert.ToDouble (s);
			R=t;
		}
		public void MoveTo()
		{
			Console.WriteLine ("输入要移动到的x和y坐标");
			string s=Console.ReadLine ();
			double t=Convert.ToDouble (s);
			O.x=t;
			string s1=Console.ReadLine ();
			double t1=Convert.ToDouble (s1);
			O.y=t1;
		}
		public void SetR()
		{
			Console.WriteLine ("输入要更改的半径大小");
			string s=Console.ReadLine ();
			double t=Convert.ToDouble (s);
			R=t;
		}
		public void Display()
		{
			Console.WriteLine ("R:"+R);
			Console.WriteLine ("circle:");
			O.Display();
		}
	}
	
	/*class Circle
	{
		public Point o;
		public int r;
		
		
		public int GetR()
		{
			return r;
		}
		
		public void SetR(int r1)
		{
			r = r1;
		}
		
		public Point GetO() 
		{
			return o;
		}
		public void MoveTo(Point o1)
		{
			o = o1;
		}
	}*/


	
	
	
	#endif
	
	

	
	
	#if false
	class Area
	{
		const float PI =3.1415926f;
		public float areas=0;
		public float r;
		public float d;
		public float g;
		public float sd;
		public float xd;
		public float tg;
		public void area(float x)
		{
			areas=PI*x*x;
			Console.WriteLine ("area:"+areas);
		}
		public void area(float x,float y)
		{
			areas=0.5f*x*y;
			Console.WriteLine ("area:"+areas);
		}
		public void area(float x,float y,float z)
		{
			areas=0.5f*(x+y)*z;
			Console.WriteLine ("area:"+areas);
		}
	}
	#endif
	



	#if false
	class Student
	{
		public string name;
		public string sex;
		public int age;
		public float chscore;
		public float mathscore;
		public float enscore;
		public void say()
		{
			Console.WriteLine ("hello everyone,i am {0},i am {1} years old,i am a {2}",name,age,sex);
		}
		public void allscores()
		{
			float s=chscore +mathscore +enscore ;
			Console.WriteLine ("i am {0},my blanket is {1} ",name,s);
		}
		public void generalscores()
		{
			float s=(chscore +mathscore +enscore)/3 ;
			Console.WriteLine ("i am {0},my blanket is {1} ",name,s);
		}
	}
	#endif


	
	
	
	
	
	
	
	
}
