using System;

namespace object2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			#if false
			Abc t=new Abc  ();
			t.Set=2;
			Console.WriteLine (t.Get);
			#endif
			
			
				#if false
				Person p = new Person();
				Console.WriteLine(p.age);
				Person p1 = new Person("zhangsan",23);
				Console.WriteLine(p.name);
				Console.WriteLine(p.age);
				Console.WriteLine(p1.age);
				#endif
			
			

			
			
		}
	}
	
	
	#if false
	class Abc
	{
		int MyNumber;
		public int Get
		{
			
			get
			{
				return MyNumber/12;
			}
		}
		public int Set
		{
			set 
			{
				this.MyNumber =value*100; 
			}
		}
	}
	#endif
	
	
	#if false
	class Person
	{
		public string name;
		public int age;
		public Person()
		{
			
		}

		public Person(string n ,int a)
		{
			name = n;
			age = a;
		}
	}
	#endif
	//
	
	class Rect
	{
		float len;
		float wid;
		public Rect()
		{
			
		}
		public Rect(float x,float y)
		{
			len=x;
			wid=y;
		}
		public void circumference()
		{
			float s=len+wid;
			Console.WriteLine ("the circumference is:"+s);
		}
		public void area()
		{
			float s=len*wid;
			Console.WriteLine ("the circumference is:"+s);
		}
		public float quchangdu
		{
			get
			{
				return len;
			}
		}
		public float qukuandu
		{
			get
			{
				return wid;
			}
		}
		public void change(float x,float y)
		{
			len=x;
			wid=y;
		}
	}
	
	
	
	
	
	
	
	
	
	
}
