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
             fg = new User { Name = "飞哥" };
             xy = new User { Name = "小余" };
             sql = new Keyword { Content = "SQL" };
             csharp = new Keyword { Content = "C#" };
             net = new Keyword { Content = ".NET" };
             java = new Keyword { Content = "JAVA" };
             js = new Keyword { Content = "JAVASCRIPT" };
             html = new Keyword { Content = "HTML" };
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
            getArticleByKeyword();
        }
        //找出“飞哥”发布的文章
        public static void getArticleByFeige()
        {
            var fgArticle = articles.Where(a => a.Author == fg);
            foreach (var item in fgArticle)
            {
                Console.WriteLine(item.Title);
            }
        }


        //找出2019年1月1日以后“小鱼”发布的文章
        public static void getArticleByXiaoyu()
        {
            var xyArtricle = articles.Where(a => a.Author == xy && a.PublishTime > new DateTime(2019,1,1));
            foreach (var item in xyArtricle)
            {
                Console.WriteLine(item.Title);
            }
        }


        //按发布时间升序 / 降序排列显示文章
        public static void getArticleByTime()
        {
            var ascArticle = articles.OrderByDescending(a => a.PublishTime);
            //按时间降序
            var descArticle = articles.OrderBy(a => a.PublishTime);
            //按时间升序
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

        public static void getAuthorByArticle()
        {
            var authorArticle = articles.GroupBy(a => a.Author)
                                 .Select(ga => new
                                 {
                                     Author = ga.Key,
                                     count=ga.Count()
                                 });       
            foreach (var item in authorArticle)
            {
                Console.WriteLine(item.Author.Name + ":" + item.count);
            }
        }
        //找出包含关键字“C#”或“.NET”的文章
        public static void getArticleByKeyword()
        {

            var keywordArticle = articles.Where(a => a.Keywords.Contains(csharp) || a.Keywords.Contains(net));
            foreach (var item in keywordArticle)
            {
                Console.WriteLine(item.Title);
            }
        }

        //找出评论数量最多的文章
        public static void getArticleByCommentMax()
        {
            var commentsArticle = (articles.OrderByDescending(a => a.Comments?.Count())).First();
            Console.WriteLine(commentsArticle.Title);
        }

        //找出每个作者最近发布的一篇文章
        public static void getAuthorByRecentlyArticle()
        {
            var authorArticle = articles.GroupBy(a => a.Author).Select(a => a.OrderByDescending(p => p.PublishTime).First());
            foreach (var item in authorArticle)
            {
                Console.WriteLine(item.Title);
            }
        }

        //为求助（Problem）添加悬赏（Reward）属性，并找出每一篇求助的悬赏都大于5个帮帮币的文章作者

    }
}
