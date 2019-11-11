using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //String name = "于维谦";
            //int age = 23;
            //bool IsFemale = false;
            //double Height = 1.87;
            //String FromCity = "山东济宁";
            //Console.WriteLine("hello");
            //Console.WriteLine("名字:"+name);
            //Console.WriteLine("年龄："+age);
            //Console.WriteLine("性别:"+IsFemale);
            //Console.WriteLine("身高:"+Height);
            //Console.WriteLine("来自:"+FromCity);
            //Console.ReadLine();
            //int i = 10, j = 20;
            ////i和j的“和”输出为30，差为-10，积为200，商为0.5；
            //Console.WriteLine("和:"+(i+j));
            //Console.WriteLine("差:"+(i-j));
            //Console.WriteLine("积:"+(i*j));
            //Console.WriteLine("商:"+(double)i/(double)j);
            //double k = 2.5, l = 0.5;
            ////k和l的“和”输出为3，差为2，积为1.25，商为5；
            //Console.WriteLine("和:"+(k+l));
            //Console.WriteLine("差:"+(k-l));
            //Console.WriteLine("积:"+(k*l));
            //Console.WriteLine("商:"+(k/j));


            //输入一个字符，显示这个字符的unicode值

            //byte[] bytes = System.Text.Encoding.Unicode.GetBytes("你");
            //Console.WriteLine(bytes[0] + "" + bytes[1]);

            //输入一个整数，如果这个整数：
            //能被6整除，显示：六六顺
            //能被8整除，显示：发发发
            //否则，显示：大吉大利
            //当整数位36时应输出六六顺
            //int number = 36;
            //if (number%6==0||number%8==0)
            //{
            //    if (number % 6 == 0)
            //    {
            //        Console.WriteLine("六六顺");
            //    }
            //    else if (number % 8 == 0)
            //    {
            //        Console.WriteLine("发发发");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("大吉大利");
            //}

            //当整数位40时应输出发发发
            //number = 40;
            //if (number % 6 == 0 || number % 8 == 0)
            //{
            //    if (number % 6 == 0)
            //    {
            //        Console.WriteLine("六六顺");
            //    }
            //    else if (number % 8 == 0)
            //    {
            //        Console.WriteLine("发发发");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("大吉大利");
            //}

            //当整数位20时应输出大吉大利
            //number = 20;
            //if (number % 6 == 0 || number % 8 == 0)
            //{
            //    if (number % 6 == 0)
            //    {
            //        Console.WriteLine("六六顺");
            //    }
            //    else if (number % 8 == 0)
            //    {
            //        Console.WriteLine("发发发");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("大吉大利");
            //}



            //将源栈同学姓名 / 昵称分别：
            //按进栈时间装入一维数组，
            //按座位装入二维数组，
            //并输出共有多少名同学。
            string[] students = { "陈元", "阿泰", "彭志强", "王欣", "jimi" };
            string[,] seat = new string[4, 3];
            seat[0, 0] = "于维谦";
            seat[1, 0] = "彭志强";
            seat[2, 0] = "刘";
            seat[3, 0] = "陈";
            seat[0, 1] = "";

            seat[2, 1] = "王";
            seat[1, 1] = "泰";
            seat[1, 2] = "曾";
            //Console.WriteLine(students.Length);


            //分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9

            //for (int i = 1; i < 6; i++)
            //{
            //    Console.WriteLine(i);

            //}

            //for (int j = 1; j < 10; j+=2)
            //{
            //    Console.WriteLine(j);
            //}

            //int k = 1;
            //while (k < 6)
            //{
            //    Console.WriteLine(k);
            //    k++;
            //}

            //while (k<10)
            //{
            //    Console.WriteLine(k);
            //    k += 2;
            //}


            //用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(students[i]);
            //}

            //for (int i = 0; i < seat.GetLength(0); i++)
            //{
            //    for (int j = 0; j < seat.GetLength(1); j++)
            //    {
            //        Console.WriteLine(seat[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            //让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值
            int l;
            int sum = 0;
            for (l = 1; l < 100; l += 2)
            {
                
                sum += l;
               
            }
            Console.WriteLine(sum);

            //将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分

            double[] scoers = new double[] { 68.5, 67.5, 96.5, 87.5, 56.5, 80 };

            double min = scoers[0];
            for (int i = 1; i < scoers.Length; i++)
            {
                if (min > scoers[i])
                {
                    min = scoers[i];
                }
                else
                {
                    //nothing
                }
            }
            Console.WriteLine(min);

            double max = scoers[0];
            for (int i = 1; i < scoers.Length; i++)
            {
                if (max < scoers[i])
                {
                    max = scoers[i];
                }
            }
            Console.WriteLine(max);

            //找到100以内的所有质数（只能被1和它自己整除的数）

            int x, n;
            for (x = 1; x < 100; x++)
            {
                for (n = 2; n <x; n++)
                {
                    if (x%n==0)
                    {
                        break;
                    }
                    if (n==x-1)
                    {
                        Console.WriteLine(x);
                    }
                }
            }
        }
    }
}

