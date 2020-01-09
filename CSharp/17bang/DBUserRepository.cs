using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._17bang
{
    class DBUserRepository<T> : DbContext where T:class
    {
        public DbSet<T> entities { set; get; }   //EF据此确定哪些class需要映射到数据库
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString =
                @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = 17bang;Integrated Security = True;";
            //UseSqlServer()需要添加NuGet引用：Microsoft.EntityFrameworkCore.SqlServer
            optionsBuilder.UseSqlServer(connectionString);
        }
        public void Save(T entity)
        {
            entities.Add(entity);
            SaveChanges();
        }
    }
}
