using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class homework
    {
        public static double GetMax(double[] array)
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
            

        public static List<int> PrimeNumber(int j)
        {
            List<int> number = new List<int>();
            int x, n;
            for (x = 1; x < j; x++)
            {
                for (n = 2; n < x; n++)
                {
                    if (x % n == 0)
                    {
                        break;
                    }
                    if (n == x - 1)
                    {
                        number.Add(x);
                    }
                }
            }
            return number;
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
    }

}
