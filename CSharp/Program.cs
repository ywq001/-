﻿using System;

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
            //string[] students = { "陈元", "阿泰", "彭志强", "王欣", "jimi" };
            //string[,] seat = new string[4, 3];
            //seat[0, 0] = "于维谦";
            //seat[1, 0] = "彭志强";
            //seat[2, 0] = "刘";
            //seat[3, 0] = "陈";
            //seat[0, 1] = "";

            //seat[2, 1] = "王";
            //seat[1, 1] = "泰";
            //seat[1, 2] = "曾";
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
            //int l;
            //int sum = 0;
            //for (l = 1; l < 100; l += 2)
            //{

            //    sum += l;

            //}
            //Console.WriteLine(sum);

            //将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分

            //double[] scoers = new double[] { 68.5, 67.5, 96.5, 87.5, 56.5, 80 };

            //double min = scoers[0];
            //for (int i = 1; i < scoers.Length; i++)
            //{
            //    if (min > scoers[i])
            //    {
            //        min = scoers[i];
            //    }
            //    else
            //    {
            //        //nothing
            //    }
            //}
            //Console.WriteLine(min);

            //double max = scoers[0];
            //for (int i = 1; i < scoers.Length; i++)
            //{
            //    if (max < scoers[i])
            //    {
            //        max = scoers[i];
            //    }
            //}
            //Console.WriteLine(max);

            //找到100以内的所有质数（只能被1和它自己整除的数）

            //int x, n;
            //for (x = 1; x < 100; x++)
            //{
            //    for (n = 2; n < x; n++)
            //    {
            //        if (x % n == 0)
            //        {
            //            break;
            //        }
            //        if (n==x-1)
            //        {
            //            Console.WriteLine(x);
            //        }
            //    }
            //}
            //将之前以下作业封装成方法（自行思考参数和返回值），并调用执行
            //自我介绍：SelfIntroduce()
            //加减乘除：Add() / Minus() / Mutiply() / Divide()
            //取字符值：GetUnicode()
            //取最高分：GetMax()
            //static void SelfIntroduce(string name,int age,bool IsFemale,double Height,string FromCity)
            // {
            //     Console.WriteLine("hello");
            //     Console.WriteLine("名字:" + name);
            //     Console.WriteLine("年龄：" + age);
            //     Console.WriteLine("性别:" + IsFemale);
            //     Console.WriteLine("身高:" + Height);
            //     Console.WriteLine("来自:" + FromCity);
            // }
            // SelfIntroduce("阿泰小贼",199,true,1.55,"重庆");

            //static void Add(int i,int j)
            //{
            //    Console.WriteLine("和:" + (i + j));
            //}
            //Add(30,20);

            //static void Minus(int i,int j)
            //{
            //    Console.WriteLine("差:" + (i - j));
            //}
            //Minus(30, 20);

            //static void Mutiply(int i,int j)
            //{
            //    Console.WriteLine("积:" + (i * j));
            //}
            //Mutiply(5,3);

            //static void Divide(int i,int j)
            //{
            //    Console.WriteLine("商:" + (double)i / (double)j);
            //}
            //Divide(5, 3);

            //static void GetUnicode(char k)
            //{
            //    Console.WriteLine((int)'k');
            //}
            //GetUnicode('牛');

            //static void GetMax(double[] array)
            //{
            //    double max = array[0];
            //    for (int i = 1; i < array.Length; i++)
            //    {
            //        if (max < array[i])
            //        {
            //            max = array[i];
            //        }
            //    }
            //    Console.WriteLine(max);
            //}
            //double[] scoers = new double[] { 68.5, 67.5, 96.5, 87.5, 56.5, 80 };
            //GetMax(scoers);

            //计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
            //static void GetAverage(double[] ary)
            //{
            //    double sum = 0;
            //    for (int i = 0; i < ary.Length; i++)
            //    {
            //        sum += ary[i];

            //    }
            //    Console.WriteLine(sum / ary.Length);
            //}
            //double[] scoers = new double[] { 68.5, 67.5, 96.5, 87.5, 56.5, 80 };
            //GetAverage(scoers);

            //完成“猜数字”游戏，方法名GuessMe()

            static void GuessMe(int min, int max)
            {
                int number;
                int guessNumbers;
                Random rd = new Random();
                number = rd.Next(min, max);
                int count = 0;
                Console.WriteLine("请输入小于"+max+"大于"+min+"的猜测数值：");
                guessNumbers = Convert.ToInt32(Console.ReadLine());
                while (guessNumbers <= max)
                {
                    if (number == guessNumbers)
                    {
                        if (count<=9)
                        {
                            if (count<=8)
                            {
                                if (count<=5)
                                {
                                    Console.WriteLine("你真牛逼");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("不错嘛");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("还行");
                            break;
                        }
                        
                    }
                    else
                    {
                        count++;
                        if (count == 10)
                        {
                            Console.WriteLine("(～￣(OO)￣)ブ");
                            break;
                        }

                        else
                        {
                            if (guessNumbers<number)
                            {
                                Console.WriteLine("小了");
                            }
                            else
                            {
                                Console.WriteLine("大了");
                            }
                        }
                    }
                    Console.WriteLine("请再次输入猜测的数字：");
                    guessNumbers = Convert.ToInt32(Console.ReadLine());
                }
                
            }
            //test1=>当输入正确的时候的显示恭喜你猜对了，然后跳出循环
            //test2=>当猜错时显示你真笨，继续输入数字
            //test3=>当猜测5次时，GANE OVER跳出循环
            GuessMe(1,1000);
        }
    }
}

