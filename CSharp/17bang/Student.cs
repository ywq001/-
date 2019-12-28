using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using CSharp._17bang;
using System.Data.Common;

namespace CSharp._17bang
{
    class Student
    {
        private DBHelper _dbHelper;
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public Student()
        {
            if (_dbHelper == null)
            {
                _dbHelper = new DBHelper();
            }
        }

        public static void SaveSome(params Student[] students)
        {
            using(DbConnection connection = new DBHelper().LongConnection)
            {
                for (int i = 0; i < students.Length; i++)
                {
                    students[i].Save();
                }
            }
        }

        private void Save()
        {
            _dbHelper.ExecuteNonQuery(
                $"DELETE student WHERE Id={Id}");
        }



    }
}
