using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CSharp;

namespace CSharp
{
    public static class ExerciseOfLinq
    {
        static User fg, xy;
        static Keyword sql, csharp, net, java, js, html;
        static Article SQL, JAVA, UI, CSharp;
        static Comment wx, atai, pzq, cbw, ljp;

        static ExerciseOfLinq()
        {
             fg = new User() { Name = "飞哥" };
             xy = new User() { Name = "小余" };
             sql = new Keyword() { Content = "SQL" };
             csharp = new Keyword() { Content = "C#" };
             net = new Keyword() { Content = ".NET" };
             java = new Keyword() { Content = "JAVA" };
             js = new Keyword() { Content = "JAVASCRIPT" };
             html = new Keyword() { Content = "HTML" };
             SQL = new Article("文章") { Author = fg, Title = "SQL", Keywords = new List<Keyword> { sql } };
             JAVA = new Article("文章") { Author = fg, Title = "JAVA", Keywords = new List<Keyword> { java, html } };
             UI = new Article("文章") { Author = xy, Title = "UI", Keywords = new List<Keyword> { js, html, net } };
             CSharp = new Article("文章") { Author = xy, Title = "CSharp", Keywords = new List<Keyword> { csharp } };
             wx = new Comment(JAVA) { Body = "写的不行", Author = new User { Name = "王欣" } };
             atai = new Comment(SQL) { Body = "写的很好", Author = new User { Name = "阿泰" } };
             pzq = new Comment(UI) { Body = "还可以", Author = new User { Name = "彭志强" } };
             cbw = new Comment(CSharp) { Body = "一般般", Author = new User { Name = "陈百万" } };
             ljp = new Comment(CSharp) { Body = "看得下去", Author = new User { Name = "刘江平" } };
            SQL.Comments = new List<Comment> { atai };
            JAVA.Comments = new List<Comment> { wx };
            UI.Comments = new List<Comment> { pzq };
            CSharp.Comments = new List<Comment> { cbw, ljp };
            sql.Articles = new List<Article> { SQL };
            csharp.Articles = new List<Article> { CSharp };
            net.Articles = new List<Article> { UI };
            java.Articles = new List<Article> { JAVA };
            js.Articles = new List<Article> { UI };
            html.Articles = new List<Article> { JAVA, UI };
            articles = new List<Article> { SQL, JAVA, UI, CSharp };
            ContentService.Publish(UI);
            ContentService.Publish(CSharp);
            ContentService.Publish(SQL);
            ContentService.Publish(JAVA);
        }

        

        private static IEnumerable<Article> articles;
       
        internal static void Do()
        {
            getArticleByFeige();
            getArticleByXiaoyu();
            getArticleByTime();
            getAuthorByArticle();
            getArticleByKeyword(csharp,net);
        }
        //找出“飞哥”发布的文章
        private static void getArticleByFeige()
        {
            var fgArticle = from a in articles
                            where a.Author.Name == "飞哥"
                            select a;
            foreach (var item in fgArticle)
            {
                Console.WriteLine(item.Title);
            }
        }


        //找出2019年1月1日以后“小鱼”发布的文章
        private static void getArticleByXiaoyu()
        {
            var xyArtricle = from a in articles
                             where a.PublishTime > Convert.ToDateTime("2019年1月1日") && a.Author.Name == "小余"
                             select a;
            foreach (var item in xyArtricle)
            {
                Console.WriteLine(item.Title);
            }
        }


        //按发布时间升序 / 降序排列显示文章
        private static void getArticleByTime()
        {
            var ascArticle = from a in articles
                             orderby a.PublishTime ascending
                             select a;//按时间升序
            var descArticle = from a in articles
                              orderby a.PublishTime descending
                              select a;//按时间降序
            foreach (var item in ascArticle)
            {
                Console.WriteLine(item.Title);
            }
            foreach (var item in descArticle)
            {
                Console.WriteLine(item.Title);
            }
        }

        //统计每个用户各发布了多少篇文章

        private static void getAuthorByArticle()
        {
            var authorArticle = from a in articles
                                group a by a.Author.Name into gm
                                select new
                                {
                                    Author = gm.Key,
                                    count = gm.Count()
                                };
            foreach (var item in authorArticle)
            {
                Console.WriteLine(item.Author + ":" + item.count);
            }
        }
        //找出包含关键字“C#”或“.NET”的文章
        private static void getArticleByKeyword(Keyword keyword, Keyword Keyword)
        {

            var keywordArticle = from a in articles
                                 where a.Keywords.Contains(keyword) || a.Keywords.Contains(Keyword)
                                 select a;//找出包含关键字“C#”或“.NET”的文章
            foreach (var item in keywordArticle)
            {
                Console.WriteLine(item.Title);
            }
        }

        //找出评论数量最多的文章
        private static void getArticleByCommentMax()
        {
            var commentsArticle = (from a in articles
                                   orderby a.Comments.Count() descending
                                   select a).First();//找出评论数量最多的文章
            Console.WriteLine(commentsArticle.Title);
        }

    }
}
