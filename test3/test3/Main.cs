using System;

namespace test3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
				
			#if false
			person j=person.drink;
			dos(j);
			#endif
			
			#if false
			int i=9;
			add(i);
			Console.WriteLine ("b"+i);
			#endif
			
			#if false
			int i=10,j=20;
			change (ref i,ref j);
			Console.Write (i+"\n"+j+"\n");
			#endif
			
			#if false
			int j=31;//在此改变j值，ref引用，out不引用
			add (out j);
			Console.WriteLine(j);
			#endif
			
			
			#if false
			int i=3;
			float j=234.021554f;
			add(i,j,1,2,3,4,5);
			#endif
			
			#if false
			string x=Console.ReadLine ();
			int c=Convert.ToInt32(x);
			//Console.WriteLine ("阶乘为："+jc (c));
			ou (c);
			#endif
			
			
			#if false
			string s="s# , De,3#s  De,G,R g #g,#a,d  ";
			#if false
			Console.WriteLine (s.Length );
			Console.WriteLine (s.ToUpper ());
			Console.WriteLine (s.ToLower ());
			Console.WriteLine (s);
			Console.WriteLine ((s.Trim ()).Length );
			char[]aa=s.ToCharArray ();
			for(int i=0;i<s.Length ;i++)
			Console.Write (aa[i]+"|");
			#endif
			//string[]ss=s.Split(',','#');
			//string []ss=s.Split (new char[]{'#',','},StringSplitOptions.None);
			//string []ss=s.Split (new string []{"De"},StringSplitOptions.None);
			//string ss=s.Replace("De","**");//输出要用char
			//string ss=s.Substring(4);
			//string ss=s.Substring (1,6);//起始从零开始
			//bool judge=s.Contains("sdf");
			//bool judge=s.StartsWith ("3#");
			//bool judge=s.EndsWith ("  ");
			int index=s.IndexOf ("s#");
			Console.WriteLine (index);
			/*foreach(char temp in ss)
			{
				Console.Write (temp+"\n");
			}*/
			//Console.WriteLine (judge);
			#endif
			
			//1
			#if false
			string s=Console.ReadLine ();
			int i=0;
			char[] ss=s.ToCharArray ();
			for(i=s.Length-1;i>=0;i--)
				Console.Write (ss[i]);
			#endif
			
			
			#if false
			string s=Console.ReadLine ();
			string[] ss=s.Split(' ');
			int i=0;
			for(i=ss.Length-1 ;i>=0;i--)
				Console.Write (ss[i]+" ");
			#endif
			
			
			
			#if false
			Console.WriteLine("请输入Email:");
			string s=Console.ReadLine ();
			string []ss=s.Split('@');
			Console.WriteLine ("用户名为：{0}，域名为：{1}",ss[0],ss[1]);
			#endif
			
			#if false
			Console.WriteLine ("请输入手机号码：");
			string s=Console.ReadLine ();
			string ss=s.Substring(0,6);
			Console.WriteLine (ss+"xxxx");
			#endif
			
			#if false
			string s=Console.ReadLine ();
			if(s.Length <=20)
			{
				Console.WriteLine (s);
			}
			else 
			{
				string ss=s.Substring(0,20);
				Console.WriteLine (ss+"...");
			}
			#endif
			
			#if false
			string s=Console.ReadLine ();
			bool judge=s.StartsWith("kf");
			bool judgee=s.StartsWith("game");
			if(judge)
				Console.WriteLine ("客服");
			if(judgee)
				Console.WriteLine ("游戏");
			#endif
			
			#if false
			string s=Console.ReadLine ();
			string ss=s.Substring (7);
			Console.Write ("域名为："+ss);
			#endif
			
			#if false
			string s="2008-02-08";
			string []ss=s.Split('-');
			Console.Write (ss[0]+"年"+ss[1]+"月"+ss[2]+"日");
			#endif
			
	
			
			
			
			#if false
			string[]t={"和谐","天安门","主席","台湾"};
			bool flag=true;
			while(true)
			{
				flag=true;
				string s=Console.ReadLine ();
				foreach(string temp in t)
				{
					if(s.Contains (temp))
					{
					Console.WriteLine ("请重新输入");
					flag=false ;
					
					}	
				}
				if(!flag)
					continue;
				else 
					break ;
			}
			#endif
			
			
			#if false
			string[] mgc = {"hx","tam","zx","tw"};
			bool isSuccess = true;
			while(true)
			{
				isSuccess = true;
				string s = Console.ReadLine();
				foreach(string temp in mgc)
				{
				if(s.Contains(temp))
				{
				isSuccess = false;
				break;
				}
				}
				if(isSuccess ==true)
				{
				break;
				}
			}
			Console.WriteLine("success!!!!");
			#endif
			
		

			
			
			
			
			
			//自动替换敏感词长度
			#if false
			string s=Console.ReadLine ();
			string[]t={"和谐","天安门前","主席","台湾"};
			for(int i=0;i<t.Length ;i++)
			{
				string n="";
				for(int k=0;k<t[i].Length;k++)
					n+="*";
				if(s.Contains(t[i]))
				{
					s=s.Replace (t[i],n);
				}
			}	
			Console.WriteLine (s);
			#endif
					
		
			#if false
			string s=Console.ReadLine ();
			char[] ss=s.ToCharArray();
			for(int i=0;i<s.Length ;i++)
				Console.Write ("字符{0}的ASC码值为：{1}\n",ss[i],(int)ss[i]);
			#endif
			
			#if false
			string s="totalpage:21,frompage:1,topage:10";
			string s1=s.Substring(10,2);
			string s2=s.Substring(22,1);
			string s3=s.Substring(31,2);
			Console.Write (s1+"\n"+s2+"\n"+s3+"\n");
			#endif
		
				
			
			#if false
			string s=Console.ReadLine ();
			string[]ss=s.Split(new char[]{' ',','},StringSplitOptions.RemoveEmptyEntries);
			for(int i=0;i<ss.Length ;i++)
			{
				if(ss[i]=="no")
					ss[i]="yes";
				Console.Write ("\"{0}\" ",ss[i]);
			}
			#endif
			
			
			
			//合并两种方法		
	
			
			#if false
			string s=Console.ReadLine ();
			char[]ss=s.ToCharArray ();
			//string temp = ""+ss[0];
			string temp = "";
			/*for(int i=1;i<ss.Length ;i++)
			{	
				if(ss[i]!=ss[i-1])
				{
					temp += ss[i];
				}
			}
			Console.WriteLine(temp);*/

			for(int i=0;i<ss.Length-1;i++)
			{
				if(ss[i]!=ss[i+1])
				{
					temp += ss[i];
				}
			}
			temp += ""+ss[ss.Length-1];
			Console.Write (temp);
			#endif
				
		
		
				
			#if false
			string s=Console.ReadLine ();
			Console.WriteLine (s.Length );
			Console.WriteLine (s.IndexOf("a"));
			s=s.Insert (3,"hello");
			Console.WriteLine (s);
			string s1=s.Replace("hello","me");
			Console.WriteLine (s1);
			string[] s2=s.Split('m');
			foreach(string temp in s2)
			Console.WriteLine(temp);
			#endif
			
			
			
		
		
		
		
		
		#if false
		enum person
		{
			eat,drink,pull,push
		}
		static void dos(person i)
		{
			switch(i)
			{
			case person.drink:
				Console.WriteLine("are you thirsty");
				break ;
			case person.eat:
				Console.WriteLine("are you hungry");
				break ;
			case person.pull:
				Console.WriteLine ("it is disgut");
				break ;
			default :
				Console.WriteLine("ok,you are the winner");
				break ;
			
			}
		}
		#endif
		
		#if false
		static void add( int i)
		{
			i--;
			Console.WriteLine ("a"+i);
		}
		static void change(ref int i,ref int j)
		{
			int t;
			t=i;
			i=j;
			j=t;
		}
		#endif
		
		#if false
		static void add(out int i)
		{
			i=2;
		}
		#endif
		
		
		#if false
		static void add(int i,float j,params int[]a)
		{
			Console.Write(i+"\n"+j+"\n");
			foreach(int k in a)
			{
				Console.WriteLine(k);

			}

		}
		#endif
		
		#if false
		static int  jc(int i)
		{
			
			if(i==0)
				return 1;
			else 
				return  i*(i-1);
			
			
		} 
		#endif
		}
	
			static void ou(int i)
			{
			
			if(i<=1)
				Console.WriteLine() ;
			else if(i%2==0)
			{
				ou (i-2);
				Console.Write (i+" ");
				
			}
			else  
				ou (i-1);
			
			
			
			if(i>1)
				ou (i-1);
			if(i%2==0)
				Console.Write (i);
			}

	}
}