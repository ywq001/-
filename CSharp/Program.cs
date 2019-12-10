using System;
using CSharp;

using System.Reflection;


namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Problem yq = new Problem();
            //yq.Publish();

            //Problem.Load(20);

            //Console.WriteLine(typeof(Problem).Assembly);
            //实例化文章和意见建议，调用他们：
            //继承自父类的属性和方法
            //自己的属性和方法
            //Article wx = new Article();
            //wx.Keyword = "c#";
            //Console.WriteLine(wx.Keyword);
            //Console.WriteLine(wx.PublishTime);
            //wx.moneyAmount(20);
            //Suggest atai = new Suggest();
            //atai.Keyword = "sql";
            //Console.WriteLine(atai.Keyword);
            //atai.moneyAmount(30);

            //Suggest pzq = new Suggest("文章");

            //Console.WriteLine(pzq.kind);




            //Content content = new Article("Article");
            //ContentService.Publish(content);

            //构造一个能装任何数据的数组，并完成数据的读写

            //object[] b = new object[5] { "wx", 25, true,36,45 };

            //Console.WriteLine(b[3]);

            //Getdate(10);
            //Getweek();
            //Getweeks(2020);



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
            //        if (n == x - 1)
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

            // SelfIntroduce("阿泰小贼",199,true,1.55,"重庆");


            //Add(30,20);


            //Minus(30, 20);


            //Mutiply(5,3);


            //Divide(5, 3);


            //GetUnicode('牛');


            //double[] scoers = new double[] { 68.5, 67.5, 96.5, 87.5, 56.5, 80 };
            //GetMax(scoers);

            //计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()

            //double[] scoers = new double[] { 68.5, 67.5, 96.5, 87.5, 56.5, 80 };
            //GetAverage(scoers);

            //完成“猜数字”游戏，方法名GuessMe()
            //test1=>当五次内猜对的时候的显示你真牛逼，然后跳出循环，小于8次猜对输出不错嘛，然后跳出循环，9次猜对输出还可以，10次猜对输出还行
            //test2=>当猜错时猜的数字比随机数小的时候输出小了然后继续输入猜测的数字，比随机数大就输出大了，然后继续输入
            //test3=>当第10次还没有猜对时，输出(～￣(OO)￣)ブ，跳出循环游戏结束
            //GuessMe(1, 1000);



            //定义一个生成数组的方法：int[] GetArray()，其元素随机生成从小到大排列。利用可选参数控制：
            //最小值（默认为1）
            //相邻两个元素之间的最大差值（默认为5）
            //元素个数（默认为10个）
            //GetArray(250);



            //利用ref调用Swap()方法交换两个同学的床位号
            //int a = 2;
            //int b = 3;

            //Swap(ref a,ref b);
            //Console.WriteLine($"交换后：a：{a} b：{b}");

            //重载GetArray()，使其返回一个string[]


            //GetArray("牛");

            //实现二分查找，方法名BinarySeek(int[] numbers, int target)：
            //传入一个有序（从大到小 / 从小到大）数组和数组中要查找的元素
            //如果找到，返回该元素所在的下标；否则，返回 - 1
            //int[] numbers = { 8, 11, 21, 28, 32, 43, 48, 56, 69, 72, 80, 94 };
            //Console.WriteLine(BinarySeek(int[] numbers,int 69));


            //使用tuple作为参数，重构SelfIntroduction()方法，输出自我介绍
            //var students = Tuple.Create<int, String, bool, double>(16, "阿泰", false, 1.75);

            //SelfIntroduction((16, "阿泰", false, 1.75));

            //作业: 自己实现 - 个模拟栈，增加如下功能:
            //●出栈Pop(),弹出栈顶数据
            //●入栈Push()， Push可以 - -次性压入多个数据;
            //●出入栈检查,
            //。如果压入的数据已超过栈的深度(最大容量)，提示“栈溢出”
            //。如果已弹出所有数据，提示“栈已空”



            //调用构造函数

            //User wx = new User();
            //User wx1 = new User("王欣");

            //Console.WriteLine(wx1.name);

            //User wx = new User();
            //wx.TokenManager = new TokenManager();
            //wx.TokenManager.Add(Token.Admin);
            //wx.TokenManager.Remove(Token.Admin);ago
            //Console.WriteLine(wx.TokenManager.Has());

            Content ywq = new Suggest("文章");
            Console.WriteLine(ywq.CreateTime);

            Type typeinfo = typeof(Content);
            FieldInfo onCreatetime = typeof(Content).GetField("_createtime", BindingFlags.Instance | BindingFlags.NonPublic);
            onCreatetime.SetValue(ywq, DateTime.Now);
            Console.WriteLine(ywq.CreateTime);

            //ywq.Issue();

            //Problem wx = new Problem("求助");
            //wx.Reward = -2;
            //Console.WriteLine(wx.Reward);

            //ContentService.Publish(wx);

        }

        static void Divide(int i, int j)
        {
            Console.WriteLine("商:" + (double)i / (double)j);
        }
        static void GetUnicode(char k)
        {
            Console.WriteLine((int)'k');
        }
        static DateTime Getdate(int amount,DateTime begin,Unit unit )
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

