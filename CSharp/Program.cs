using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "于维谦";
            int age = 23;
            bool IsFemale = false;
            double Height = 1.87;
            String FromCity = "山东济宁";
            Console.WriteLine("hello");
            Console.WriteLine("名字:"+name);
            Console.WriteLine("年龄："+age);
            Console.WriteLine("性别:"+IsFemale);
            Console.WriteLine("身高:"+Height);
            Console.WriteLine("来自:"+FromCity);
            Console.ReadLine();
            int i = 10, j = 20;
            //i和j的“和”输出为30，差为-10，积为200，商为0.5；
            Console.WriteLine("和:"+(i+j));
            Console.WriteLine("差:"+(i-j));
            Console.WriteLine("积:"+(i*j));
            Console.WriteLine("商:"+(double)i/(double)j);
            double k = 2.5, l = 0.5;
            //k和l的“和”输出为3，差为2，积为1.25，商为5；
            Console.WriteLine("和:"+(k+l));
            Console.WriteLine("差:"+(k-l));
            Console.WriteLine("积:"+(k*l));
            Console.WriteLine("商:"+(k/j));
        }
    }
}
