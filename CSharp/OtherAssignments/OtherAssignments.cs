using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class OtherAssignment
    {
        static void Divide(int i, int j)
        {
            Console.WriteLine("商:" + (double)i / (double)j);
        }
        static void GetUnicode(char k)
        {
            Console.WriteLine((int)'k');
        }
        static DateTime Getdate(int amount, DateTime begin, Unit unit)
        {
            switch (unit)
            {
                case Unit.Day:
                    return begin.AddDays(amount);
                case Unit.Week:
                    return begin.AddDays(amount * 7);
                case Unit.Month:
                    return begin.AddMonths(amount);
                default:
                    throw new Exception("");
            }
        }
        enum Unit
        {
            Day,
            Week,
            Month
        }

        static void Getweeks(int year)
        {

            DateTime date = getweeks(year);
            DateTime LastMondy = getweeks(year + 1).AddDays(-7);
            while (date < LastMondy)
            {

                Console.Write(date.ToString("yyyy年MM月dd日"));
                date = date.AddDays(6);
                Console.Write("----");
                Console.Write(date.ToString("yyyy年MM月dd日"));
                date = date.AddDays(1);
                Console.WriteLine();
            }
        }

        static DateTime getweeks(int year)
        {
            DateTime date = new DateTime(year, 1, 1);
            while (date.DayOfWeek != DayOfWeek.Monday)
            {
                date = date.AddDays(1);
            }
            return date;
        }

        static void Mutiply(int i, int j)
        {
            Console.WriteLine("积:" + (i * j));
        }
        static void SelfIntroduction((int age, string name, bool IsFemale, double Height) students)
        {
            Console.WriteLine("姓名：" + students.name);
            Console.WriteLine("年龄:" + students.age);
            Console.WriteLine("性别：" + students.IsFemale);
            Console.WriteLine("身高：" + students.Height);

        }

        static string[] GetArray(string a)
        {
            string[] rarray = new string[1];
            return rarray;

        }

        static void Minus(int i, int j)
        {
            Console.WriteLine("差:" + (i - j));
        }

        static void Getweek()
        {

            string input = Console.ReadLine();
            int a = 1;
            bool result = int.TryParse(input, out a);
            if (result)
            {
                int inputDate = int.Parse(input);
                DateTime date = new DateTime(inputDate, 1, 1);
                DateTime fristDay = date;
                while (date.DayOfWeek != DayOfWeek.Monday)
                {
                    date = date.AddDays(1);
                }
                DateTime fristDate = date;
                Console.WriteLine("第1周："
                    + fristDay.ToString("yyyy年MM月dd日")
                    + "---"
                    + fristDate.AddDays(-1).ToString("yyyy年MM月dd日"));
                DateTime last = new DateTime(inputDate, 12, 31);
                DateTime lastDay = last;
                while (last.DayOfWeek != DayOfWeek.Monday)
                {
                    last = last.AddDays(-1);
                }
                DateTime lastDate = last;

                int k = ((lastDate - fristDate).Days) / 7;
                for (int j = 2; j <= k + 1; j++)
                {
                    Console.WriteLine("第" + j + "周："
                        + fristDate.ToString("yyyy年MM月dd日")
                        + "---"
                        + fristDate.AddDays(6).ToString("yyyy年MM月dd日"));
                    if (date.Year == inputDate)
                    {
                        fristDate = fristDate.AddDays(7);
                    }
                }
                Console.WriteLine("最后1周："
                    + lastDate.ToString("yyyy年MM月dd日")
                    + "---"
                    + lastDay.ToString("yyyy年MM月dd日"));
            }
            else
            {
                Console.WriteLine("请输入一个数字");
            }


        }

        static void Add(int i, int j)
        {
            Console.WriteLine("和:" + (i + j));
        }

        static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static int[] GetArray(int max)
        {
            int[] rArray = new int[10];
            for (int i = 0; i < rArray.Length; i++)
            {
                int number;

                if (i == 0)
                {
                    Random rd = new Random();
                    number = rd.Next(1, max);
                    rArray[i] = number;
                }
                else
                {
                    Random rd = new Random();
                    number = rd.Next(rArray[i - 1], rArray[i - 1] + 5);
                    rArray[i] = number;
                    if (rArray[i] == rArray[i - 1])
                    {
                        i--;
                    }
                    else
                    {
                        //nothing
                    }
                }

                Console.WriteLine(rArray[i]);
            }
            return rArray;
        }

        static void GuessMe(int min, int max)
        {
            int number;
            int guessNumbers;
            Random rd = new Random();
            number = rd.Next(min, max);
            int count = 1;
            Console.WriteLine("请输入小于" + max + "大于" + min + "的猜测数值：");
            guessNumbers = Convert.ToInt32(Console.ReadLine());
            while (count < 11)
            {
                if (guessNumbers.GetType() == typeof(int))
                {
                    if (number == guessNumbers)
                    {
                        if (count <= 9)
                        {
                            if (count <= 8)
                            {
                                if (count <= 5)
                                {
                                    Console.WriteLine("你真牛逼");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("不错嘛");
                                }
                            }
                            else
                            {
                                Console.WriteLine("还可以");
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

                        if (count == 10)
                        {
                            Console.WriteLine("(～￣(OO)￣)ブ");
                            break;
                        }

                        else
                        {
                            if (guessNumbers < number)
                            {
                                Console.WriteLine("小了");
                            }
                            else
                            {
                                Console.WriteLine("大了");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("请输入正整数");
                }
                count++;
                Console.WriteLine("请再次输入猜测的数字：");
                guessNumbers = Convert.ToInt32(Console.ReadLine());
            }

        }

        static void GetAverage(double[] ary)
        {
            double sum = 0;
            for (int i = 0; i < ary.Length; i++)
            {
                sum += ary[i];

            }
            Console.WriteLine(Math.Round(sum / ary.Length, 2));
        }
        //static int BinarySeek<T>(T[] numbers, T target)
        //{
        //    int min = 0;
        //    int max = numbers.Length - 1;
        //    int mid = 0;
        //    while (min <= max)
        //    {
        //        mid = (min + max) / 2;
        //        if (numbers[mid] > target)
        //        {
        //            max = mid - 1;
        //        }
        //        else if (numbers[mid] < target)
        //        {
        //            min = mid + 1;
        //        }
        //        else if (numbers[mid] == target)
        //        {
        //            return mid;
        //        }
        //    }
        //    return -1;
        //}

        static void SelfIntroduce(string name, int age, bool IsFemale, double Height, string FromCity)
        {
            Console.WriteLine("hello");
            Console.WriteLine("名字:" + name);
            Console.WriteLine("年龄：" + age);
            Console.WriteLine("性别:" + IsFemale);
            Console.WriteLine("身高:" + Height);
            Console.WriteLine("来自:" + FromCity);
        }

        static double GetMax(double[] array)
        {
            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
    }
}
