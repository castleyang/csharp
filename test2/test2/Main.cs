using System;

namespace test2
{
	class MainClass
	{
		#if false
		enum state
		{
			working,eating,sleeping,studying
		}
		#endif
		
		
		public static void Main (string[] args)
		{
			#if false
			state person=state.studying;
			Console.WriteLine (person);
			#endif
			
			

			#if false
			int i;
			for(i=0;i<100;i++)
			{
				if(i%2!=0)
				{
					Console.Write (i+" ");
				}
			}
			#endif
			
			
			#if false
			int i;
			for(i=50;i>=1;i--)
			{
				Console.Write (i+" ");
			}
			#endif
			
			
			#if false
			int s=0;
			for(int i=1;i<=100;i++)
			{
				s+=i;
			}
			Console.WriteLine (s);
			#endif
			
			
			#if false
			int i;
			for(i=100;i<200;i++)
			{
				if(i%3!=0)
				{
					Console.Write (i+" ");
				}
			}
			#endif
			
			
			#if false
			int i,t=0;
			for(i=1;i<100;i++)
			{
				if(i%3==0&&i%5!=0)
					t++;
			}
			Console.WriteLine (t);
			#endif

			
			#if false
			int i;
			for(i=1;i<=5;i++)
			{
				Console.Write (i*i+" ");
			}
			#endif
			
			
			#if false
			int i,j=0,s=0;
			for(i=1;i<1000;i++)
			{
				if(i%7==0)
				{
					j++;
					s+=i;
					if(j==5)
					{
						Console.Write(s+" ");
						s=0;
						j=0;
					}
				}
			}
			#endif
				
			//求素数
			
			#if false
			//Console.Write (2+" ");
			bool isPrime ;
			for(int i=2;i<1000;i++)
			{
				
				isPrime = true;
				for(int j=2;j<i;j++)
				{
					if(i%j==0)
					{
						isPrime = false;
						break;
					}

				}
				if(isPrime)
				{
					Console.Write (i+" ");
				}
				
				
				#if false	//用这个需要外循环从3开始
				for(int j=2;j<i;j++)
				{
					if(i%j==0)
						break;
					if(i==j+1)
						Console.Write (i+" ");
				}
				#endif
				
			}
			#endif
		
		
			
			
			
			
			#if false
			int i,j;
			for(i=1;i<=10;i++)
			{
				for(j=1;j<=10;j++)
				{
					Console.Write ("*");
				}
				Console.WriteLine ();
			}
			#endif
			
			
			#if false
			int i,j;
			for(i=1;i<=10;i++)
			{
				for(j=1;j<=i;j++)
				{
					Console.Write ("*");
				}
				Console.WriteLine ();
			}
			#endif
			
			
			
			
			#if false
			int i,j;
			for(i=1;i<10;i++)
			{
				for(j=1;j<=i;j++)
				//Console.Write (i+"*"+j+"="+i*j+"  ");
				Console.Write("{0}*{1}={2} ",i,j,i*j);
				Console.WriteLine ();
			}
			#endif
			
			
				
			#if false
			int i,j;
			for(i=10;i>=1;i--)
			{
				for(j=1;j<=i;j++)
					Console.Write ("*");
				Console.WriteLine ();
			}
			#endif
			
			
			
			#if false
			int i,j,k;
			for(i=10;i>=1;i--)
			{
				for(j=1;j<=10-i;j++)
				{
					Console.Write (" ");
				}
				for(k=1;k<=i;k++)
				{
					Console.Write ("*");
				}
				Console.WriteLine ();
				
			}
			#endif
			
			
			
			
			#if false
			int i,j,k=5;
			for(i=1;i<=k;i++)
			{
				for(j=1;j<=i;j++)
				{
					Console.Write ("*");
				}
				Console.WriteLine ();
			}
			for(i=k-1;i>=1;i--)
			{
				for(j=1;j<=i;j++)
				{
					Console.Write ("*");
				}
				Console.WriteLine ();
			}
			#endif
			
			
			
			
			#if false
			int i,s=1;
			for(i=1;i<=10;i++)
			{
				s*=i;
			}
			Console.WriteLine (s);
			#endif
			
			
			#if false
			int i,j,k=1,s=0;
			for(i=1;i<=3;i++)
			{
				for(j=1;j<=i;j++)
				{
					k*=j;
				}
				s+=k;
				k=1;
			}
			Console.WriteLine (s);
			#endif
			
			
			
			#if false
			int[] j=new int [10];
			int i,k=0;
			for(i=1;i<=10;i++)
			{
				j[i-1]=i;
			//for(k=0;k<10;k++)
				Console.WriteLine (j[k++]);
			}
			#endif
			
			
			#if false
			int s=0;
			int[] a={11,32,45};
			for(int i=0;i<a.Length;i++)
				s+=a[i];
			Console.WriteLine (s);
			#endif
			
			
		
			#if false
			int[]a=new int[10];
			bool flag=true;
			int max=0;
			for(int i=0;i<10;i++)
			{
				string s=Console.ReadLine ();
				int t=Convert.ToInt32(s);
				a[i]=t;
				if(flag)
				{
					max=a[i];
					flag=false;
				}
			if(a[i]>max)
					max=a[i];
			}
			Console.WriteLine ("最大值为{0}",max);
			#endif
			
			
		
			
			#if false
			string[] s=new string[3]{"梅西","卡卡","郑大世"};
			for(int i=0;i<s.Length;i++)
			Console.Write (s[i]+"|");
			Console.Write("\b\n");
			/*
			{
				if(i<s.Length-1)
				{
					Console.Write (s[i]+"|");
				}
				else
				{
					Console.WriteLi (s[i]);
				}
			}
			*/
			#endif
			
			
			
			
			
			
			#if false
			Console.WriteLine ("请输入数组长度");
			string temp=Console.ReadLine ();
			int length=Convert.ToInt32(temp);
			Console.WriteLine ("请输入数组元素");
			int[] a=new int [length];
			for(int i=0;i<a.Length;i++)
			{string s=Console.ReadLine ();
				int t=Convert.ToInt32(s);
				a[i]=t;
				if(a[i]>0)
				{
					a[i]+=1;
				}
				if(a[i]<0)
				{
					a[i]-=1;
				}

			}
			Console.WriteLine ("convert them");
			for(int i=0;i<a.Length;i++)
				Console.WriteLine (a[i]);
			#endif
			
				
			
			#if false
			int []a={45,5452,878,36,15,65,94};
			string[]b=new string[a.Length];
			int i;
			for(i=0;i<a.Length;i++)
			{
				string s=Convert.ToString(a[i]);
				b[i]=s;
				Console.Write (b[i]+"->");
			}
			#endif
							
				
			#if false
			string[] s={"3","a","8","haha}"};
			for(int i=0;i<s.Length;i++)
			{
				Console.Write(s[i]+" ");
			}
			Console.WriteLine ();
			for(int i=s.Length;i>0;i--)
			{
				Console.Write(s[i-1]+" ");
			}
			#endif
			
			
			#if false
			int[] a={1,4,3,2,5};
			int temp;
			for(int i=0;i<a.Length;i++)
			{
				for(int j=i+1;j<a.Length;j++)
				{
					if(a[i]>a[j])
					{
						temp=a[i];
						a[i]=a[j];
						a[j]=temp;
					}
				}
			}
			for(int i=0;i<a.Length;i++)
			{
				Console.Write (a[i]+" ");
			}
			#endif
			
			
			#if false
			string s="sfgeadfge12";
			char[]t=s.ToCharArray();
			foreach(char temp in t)
			{
				Console.WriteLine (temp);
			}
			#endif
			
			
			
			#if false
			char[] a={'d','2','4','g','g'};
			string s=new string (a,1,3);
			Console.WriteLine (s);
			#endif
			
			
			#if false
			int[,]a;
			a=new int[3,2];
			int[,] num=new int[,]{{1,2},{3,4},{5,6}};
			Console.WriteLine (num[1,1]);
			#endif
			
			//关于数组的认识
			#if false
			int num=10;
			#if false			//错误思想
			for(int i=0;i<=num;i++)
			{
				if(i%2!=0)
				{
					if(i==0||i==num)
					{for(int j=0;j<num;j++)
							Console.Write("*");
					Console.Write ("\n");
					}
					else
					{
						for(int k=0;k<num;k++)
							if(k==1||k==num-2)
								Console.Write ("*");
							else
								Console.Write (" ");
					}
				}
				else
					for(int p=0;p<num;p++)
						Console.Write(" ");
				Console.WriteLine();
				
			}
			#endif
			for(int i=0;i<num;i++)		//从数组坐标来考虑
			{
				for(int j=0;j<num;j++)
				{
					if(i==0||i==num-1||j==0||j==num-1)
					{
						Console.Write("*");
						
					}
					
					else
					{
						Console.Write (" ");
					}
				}
				Console.WriteLine ();
			}
			#endif
			
			
			//打印三角形
			
			#if false
			Console.WriteLine ("请输入大小");
			string s=Console.ReadLine ();
			int num=Convert.ToInt32(s);
			for(int i=0;i<num;i++)
			{	
				int k=2*i+1;
				for(int j=0;j<2*num-1;j++)
				{	
				if(k!=0&&j>=num-1-i)
				{
					Console.Write ("*");
					k--;
				}
				else
					Console.Write (" ");
				}
				Console.WriteLine ();
			}
			#endif
			
			
			
			#if false
			//int[,] data=new int [5,10];
			int[,] data = {{0,1,0,0,0,0,0,1,0,0},{0,0,0,0,0,0,1,0,0,0},
			{1,0,0,0,0,0,0,0,0,0},{0,0,1,0,1,0,0,0,0,0},
			{0,0,0,0,0,0,0,1,0,1}};
			for(int i=0;i<5;i++)
			{	for(int j=0;j<10;j++)
			{	//data[i,j]=i+j;
				Console.Write (data[i,j]+" ");
			}
			Console.WriteLine ();
			}
			#endif
			
			
			//1
			//Console.WriteLine(max(4,23));
			
			
			//2
			#if false
			Console.WriteLine ("请输入数组个数");
			int len=Convert.ToInt32(Console.ReadLine());
			int[]a=new int [len];
			Console.WriteLine ("请输入数组元素");
			for(int i=0;i<len;i++)
			{
				string s=Console.ReadLine ();
				int t=Convert.ToInt32(s);
				a[i]=t;
			}
			Console.Write("数组和为：");
			Console.WriteLine (sum (a));
			#endif
			
			
			//3
			#if false
			string [] strs={"aa","333","ccc"};
			Console.WriteLine ("请输入分隔符");

			string s=Console.ReadLine ();

			Console.WriteLine(Join (strs,s));
			#endif
			
			
			//4
			#if false
			Console.WriteLine ("请输入所求阶乘数");
			string s=Console.ReadLine();
			int t=Convert.ToInt32(s);
			Console.WriteLine ("阶乘为："+Factorial(t));
			#endif
			
			
			
			
			
		}
		//1最大值
		#if false
		static int max(int i,int j)
		{
		int t=i>j?i:j;
			return t;
		}
		#endif
		
		//2计算输入数组的和
		#if false
		static int sum(int []value)
		{
			int s=0;
			for(int i=0;i<value.Length;i++)
				s+=value[i];
			return s;
		}
		#endif
		
		
		//3返回给我字符串，然后字符串使用我指定的分隔符来进行分割
		#if false
		static string Join(string[] strs,string seperator)
		{
			//string []str={};
			//string s="s";
			string s="";
			for(int i=0;i<strs.Length;i++)
			{
				if(i!=strs.Length-1)
				{
					s+=strs[i]+seperator;
					//Console.Write (strs[i]+seperator);
				}
				else
				{
					s+=strs[i];
					//Console.Write (strs[i]);
				}
			}
			
			return  s;
		}
		#endif
	

		//4求阶乘
		#if false
		static long Factorial(int i)
		{
			int s=1;
			for(int j=1;j<=i;j++)
				s*=j;
			return s;
		}
		#endif
		
		
		
	}
}
