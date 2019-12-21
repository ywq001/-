using System;
using CSharp;
using System.Xml.Linq;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml;

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

            //找出“飞哥”发布的文章
            //找出2019年1月1日以后“小鱼”发布的文章
            //按发布时间升序 / 降序排列显示文章
            //统计每个用户各发布了多少篇文章
            //找出包含关键字“C#”或“.NET”的文章
            //找出评论数量最多的文章
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
            XElement articles = new XElement(
                "articles",
                new XComment("以下存放所有“源栈”所有文章"),
                new XElement("article",
                    new XAttribute("isDraft",false),
                    new XElement("id","1"),
                    new XElement("title", "源栈培训：C#进阶-7：Linq to XML"),
                    new XElement("body", "什么是XML（EXtensible Markup Language）" +
                    "是一种文本文件格式被设计用来传输和存储数据由：标签和属性组成元素（节点），由元素组成“树状结构”必须有而且只能有一个根节点其他："),
                    new XElement("authorId","1"),
                    new XElement("publishDate", "2019/6/18 18:15"),
                    new XElement("comments",
                    new XElement("comment",
                    new XElement("id","12"),
                    new XElement("body", "不错，赞！"),
                    new XElement("authorId","2"),
                    new XAttribute("recommend",true)),
                    new XElement("comment",
                    new XElement("id","14"),
                    new XElement("body", "作业太难了"),
                    new XElement("authorId","3")))),
                new XElement("article",
                    new XElement("id","2"),
                    new XElement("title", "源栈培训：C#进阶-6：异步和并行"),
                    new XElement("authorId",1),
                    new XAttribute("isDraft",true))
                );
            Console.WriteLine(articles);

            //然后，将其以文件形式存放到磁盘中；
            XDocument article = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                articles);
            article.Save("E:\\新建文件夹\\article.xml");
        }

        
    }
    
}

