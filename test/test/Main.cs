using System;

namespace test
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//int A=123456789;
				//Console.ReadLine ();
				//Console.WriteLine ("       ");
				/*Console.WriteLine (A);	
				Console.WriteLine ("hello c#");
				Console.WriteLine ("hello c#");
				Console.WriteLine ("hello c#");
				Console.WriteLine ("hello c#");
			Console.WriteLine ();*/
			/*int i=12;
			int j=i;
			i=2;
			Console.WriteLine (j);*/
			
		
			#if false
			int a=10;
			int b=20;
			//int t;
			Console.WriteLine("a="+a);
			Console.WriteLine("b="+b);
			Console.WriteLine ("convert them");
			int t=a;
			a=b;
			b=t;
			Console.WriteLine ("a="+a);
			Console.WriteLine ("b="+b);
			float x=2.23141f;
			Console.WriteLine (x);
			#endif
			
			
			#if false
			//char a='A';
			char b=(char)88;

			Console.WriteLine (a+""+b);
			Console.WriteLine ((char)(a+b));
			#endif
		
			//Console.Write (b);
			#if false
			char a='*';
			Console.WriteLine ((char)(a+1));


			Console.WriteLine ((float)3/2);


			char a='p';
			Console.WriteLine ((int)a);
			#endif
			
			
			/*
			char c='B';
			//Console.WriteLine ((char)(c+32));
			//c=(char)(c+32);
			c+=(char)32;
			Console.WriteLine (c);
			string s="sdf";
			s="sdd"+"sf";
			Console.WriteLine (s);
			*/
			
			
			/*char c='1';
			Console.WriteLine (c);*/
			
			
			/*string s="1234";
			int i=Convert.ToInt32(s);
			Console.WriteLine (i);
			int a=12343;
			//string b=a.ToString();
			string b=a+"";
			Console.WriteLine (b);*/
			
			
			#if false
			string s=Console.ReadLine ();
			Console.WriteLine ("you have inputted:"+s);
			int t=Convert.ToInt32(s);
			t=t*t;  //t的值发生改变
			Console.WriteLine ("the sqart is:"+t);
			//Console.WriteLine (t*t);
			#endif
			
			
			//Console.WriteLine ("{0},{1}，{2}",1,2.3f,false);
			
			
			//string s=Console.ReadLine ();
			//Console.WriteLine ("hello:{0}",s);
			//Console.WriteLine ("hello:"+s);
			
			
			
			#if false
			string t="hello:";	
			string p="castleyang";
			char a='"';
			Console.WriteLine (t+a+p+a);
			Console.WriteLine ("hello:{0}{1}{2}",a,p,a);

			Console.WriteLine ("hello:\"castleyang\"");



			int i=10+20*2;
			Console.WriteLine (i);
			//Console.WriteLine (10>10);
			bool b=true;
			Console.WriteLine (b!=true);


			string t=Console.ReadLine ();
			double p=Convert.ToDouble(t);
			if(p%2==0.0)
				Console.WriteLine (true);
			else
				Console.WriteLine (false);



			int a=10;
			a++;
			a+=a;
			Console.WriteLine (a);


			Console.WriteLine ("my age is:"+10+20);
			int i1=20;int i2=30;
			Console.WriteLine (i1>10&&i2<100);
			#endif
			
			
			Console.WriteLine ("请输入年龄");
			string s=Console.ReadLine ();
			int t=Convert.ToInt32(s);
			if(t>18)
			{
				Console.WriteLine ("可以查看");
			}
			else if(t>10)
			{
				Console.WriteLine ("是否继续查看");
				string q=ReadLine();
				if(q=="yes")
					
				{
					Console.WriteLine("可以查看");
				}
				else
				{
					
				}
			}
			
			
			
			
			
		}
	}
}
//Console.WriteLine,Console.ReadLine,Console.ReadKey