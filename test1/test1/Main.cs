using System;

namespace test1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
		
			
			#if false
			Console.WriteLine ("请输入用户名");
			Console.WriteLine ("请输入密码\n");
			string s=Console.ReadLine ();
			string t=Console.ReadLine ();			
			if(s=="admin"&&t=="888888")
				Console.WriteLine ("正确\n");
			if(s!="admin")
				Console.WriteLine ("用户名不存在\n");
			if(t!="888888")
				Console.WriteLine ("密码错误\n");
			#endif
			
			
				
			#if false
			Console.WriteLine ("请输入你的实际年龄");			
			string s=Console.ReadLine ();
			int t=Convert.ToInt32(s);
			if(t>=18)
				Console.WriteLine ("可以查看");
			else if(t>=10)
			{Console.WriteLine ("是否继续查看，请输入yes或者no");
			string p=Console.ReadLine ();
			if(p=="yes")
				Console.WriteLine ("可以查看");
			else
				Console.WriteLine ("不可以查看");
			}
			else
				Console.WriteLine ("对不起，年龄不合法，不可以查看");
			#endif
			
			
			
			#if false
			int i=0;
			while(i<101)
				Console.Write(i+++" ");
			#endif
			
			
			#if false
			int i=0;
			while(i<=100)
			{if(i%2==0)
			Console.Write(i+" ");
			i++;
			}
			#endif
			
			
			#if false
			int i=2;
			while(i<=100)
			{Console.Write(i+" ");
				i++;
			}
			#endif
			
			
			#if false
			int i=100;
			while(i>=2)
			{
				Console.Write(i+" ");
				i--;
			}
			#endif
			
			
			
			#if false
			int s=0,i=1;
			while(i<=100)
			{
				s+=i;
				i++;
			}
			Console.WriteLine (s);
			#endif
			
			
			
			#if false
			int i=1,s=0;
			while(i<=100)
			{
				if(i%7!=0)
				s+=i;
				i++;
			}
			Console.WriteLine (s);
			#endif
		
			
			
			#if false
			int i=0;
			while(i<=100)
			{if(i%2==0)
			Console.Write(i+" ");
			i++;
			}
			#endif
			
			
			
			#if false
			Console.WriteLine("请输入用户名，回车后输入密码");
			string s=Console.ReadLine ();
			string t=Console.ReadLine ();
			if(s=="admin"&&t=="888888")
				Console.WriteLine ("登陆成功");
			while(s!="admin"||t!="888888")
			{
				Console.WriteLine ("请重新输入用户名和密码");
				string s1=Console.ReadLine ();
				string t1=Console.ReadLine ();
				if(s1=="admin"&&t1=="888888")
					Console.WriteLine ("登陆成功");	
				break;
			}
			#endif

		
		
			
			
		
			#if false
			while(true)
			{
				Console.WriteLine ("请输入一个数字");
				string s=Console.ReadLine ();
				if(s=="q")
				{
					break;
				}
				int t=Convert.ToInt32(s);
				Console.WriteLine (2*t);
				
			};
			#endif
			
			
			
			
			
		
			//1不断要求输入一个数字，输入end跳出，输出最大值
			#if false
			Console.WriteLine ("请输入一个数字");
			//Console.WriteLine(int.MinValue);
			string q=Console.ReadLine ();
			int max=Convert.ToInt32(q);
			//int temp, max=-2147483648;
			while(true)
			{
				
				Console.WriteLine ("请输入一个数字");
				string s=Console.ReadLine ();
				if(s=="end")
				{
					Console.WriteLine (max);
					break;
				}
				int t=Convert.ToInt32(s);
					
				if(t>=max)
					max=t;				
			}
			#endif
		
			//2不断要求输入一个数字，输入end跳出，输出最大值
			#if false
			bool first=true;
			int max=0;
			while(true)
			{
				string s=Console.ReadLine ();
				if(s=="end")
				{
					break;
				}
				int t=Convert.ToInt32(s);
				if(first)
				{
					max=t;
					first=false;
				}
				if(t>max)
				{
					max=t;
				}
			}
			Console.WriteLine (max);
			#endif
		
			
			
		
			
			
		
		
			
			
			
			
		
		}
	}
}
