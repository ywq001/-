using System;
using CSharp;
using System.Xml.Linq;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml;
using CSharp.OtherAssignments;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //实现GetCount(string container, string target)方法，可以统计出container中有多少个target
            //string a = "123123";
            //string b = "1";
            //Console.WriteLine(StringMethod.GetCount(a, b));


            ///不使用string自带的Join()方法，定义一个mimicJoin()方法，
            ///能将若干字符串用指定的分隔符连接起来，
            ///比如：mimicJoin("-", "a", "b", "c", "d")，其运行结果为：a - b - c - d
            //string a = "-";
            //string[] b = new string[] { "a", "b", "c", "d", "e", "f" };
            //Console.WriteLine(StringMethod.mimicJoin(a,b));


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


            //Content ywq = new Suggest("文章");
            //Console.WriteLine(ywq.CreateTime);

            //Type typeinfo = typeof(Content);
            //FieldInfo onCreatetime = typeof(Content).GetField("_createtime", BindingFlags.Instance | BindingFlags.NonPublic);
            //onCreatetime.SetValue(ywq, DateTime.Now);
            //Console.WriteLine(ywq.CreateTime);

            //ywq.Issue();

            //Problem wx = new Problem("求助");
            //wx.Reward = -2;
            //Console.WriteLine(wx.Reward);

            //ContentService.Publish(wx);

            //linq方法调用
            //ExerciseOfLinq.Do();
            //ExerciseOfLinq.getArticleByFeige();
            //ExerciseOfLinq.getArticleByXiaoyu();
            //ExerciseOfLinq.getArticleByTime();
            //ExerciseOfLinq.getArticleByCommentMax();
            //ExerciseOfLinq.getArticleByKeyword();
            //ExerciseOfLinq.getAuthorByArticle();
            //ExerciseOfLinq.getAuthorByRecentlyArticle();


            ///现有一个txt文件，里面存放了若干email地址，
            ///使用分号（;）或者换行进行了分隔。
            ///请删除其中重复的email地址，并按每30个email一行（行内用; 分隔）重新组织

            //按以下格式生成一个XML对象

            //Console.WriteLine(XmlHomework.xmlarticles());



            ////然后，将其以文件形式存放到磁盘中；
            //XDocument article = new XDocument(
            //    new XDeclaration("1.0", "utf-8", "yes"),
            //    XmlHomework.xmlarticles());
            //article.Save("E:\\新建文件夹\\article.xml");

            ////再从磁盘中读取到内存中
            //XElement element = XElement.Load("E:\\新建文件夹\\article.xml");

            ////在根节点下添加一个新的article元素，内容至少包含id、title和authorId
            //XmlHomework.xmlarticles().Add(new XElement("article",
            //             new XElement("id", 1),
            //             new XElement("title", "net"),
            //             new XElement("authorId", "2")));
            //XmlHomework.xmlarticles().Save("E:\\article.xml");
            //Console.WriteLine(XmlHomework.xmlarticles());

            ////删除id = 12的评论
            //XElement idCard = (from a in XmlHomework.xmlarticles().Descendants("comment")
            //                   where a.Element("id").Value == "12"
            //                   select a).Single();
            //idCard.Remove();
            ////articles.Save("D:\\article.xml");
            //Console.WriteLine(XmlHomework.xmlarticles());
            ////articles.Descendants("id").Where(x => (string)x == "12");

            ////改变id = 2的article：isDraft = false，title = 源栈培训：C#进阶-8：异步和并行
            //XElement idCard2 = (from a in XmlHomework.xmlarticles().Descendants("article")
            //                    where a.Element("id").Value == "2"
            //                    select a).Single();
            //idCard2.SetAttributeValue("isDraft", false);
            //idCard2.SetElementValue("title", "源栈培训：C#进阶-8：异步和并行");
            //XmlHomework.xmlarticles().Save("E:\\Temp\\article.xml");
            //Console.WriteLine(XmlHomework.xmlarticles());

            //参照上述articles，代码生成一个XML的users对象，能够存放用户的id、name和password，然后并存放到磁盘
            Console.WriteLine(XmlHomework.xmlusers());

            XDocument user = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                XmlHomework.xmlusers());
            XmlHomework.xmlusers().Save("E:\\Temp\\users.xml");

            ///扩展user和articles的内容，使其能够完成以下操作：
            ///根据用户名查找他发布的全部文章
            XmlHomework.findArticle();

            ///统计出每个用户各发表了多少篇文章
            XmlHomework.userArticle();

            ///查出每个用户最近发布的一篇文章
            XmlHomework.recentArticle();

            ///每个用户评论最多的一篇文章
            
             
            ///删除没有发表文章的用户

        }

        
    }
    
}

