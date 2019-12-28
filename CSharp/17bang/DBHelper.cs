using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Data.Sql;


namespace CSharp._17bang
{
    class DBHelper
    {
        private const string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = 17bang;Integrated Security = True;";

        private SqlConnection _longConnection;
        public SqlConnection LongConnection
        {
            get
            {
                //写法一
                //if (_longConnection == null)
                //{
                //    _longConnection = new SqlConnection(connectionString);
                //}
                //写法二
                _longConnection = _longConnection ?? new SqlConnection(connectionString);
                return _longConnection;
            }
        }

        public int ExecuteNonQuery(string cmdText)
        {
            if (new DBHelper().LongConnection.State == ConnectionState.Closed)
            {
                LongConnection.Open();
            }
                DbCommand getByUser = new SqlCommand();
            getByUser.CommandText = cmdText;
            getByUser.Connection = LongConnection;
                int result= getByUser.ExecuteNonQuery();
            return result;
        }

        public object ExecuteScalar(string cmdText)
        {
            if (new DBHelper().LongConnection.State == ConnectionState.Closed)
            {
                LongConnection.Open();
            }
            DbCommand getByUser = new SqlCommand();
            getByUser.CommandText = cmdText;
            getByUser.Connection = LongConnection;
            object result = getByUser.ExecuteScalar();
            return result;
        }

        public DbDataReader ExecuteReader(string cmdText)
        {
            if (new DBHelper().LongConnection.State == ConnectionState.Closed)
            {
                LongConnection.Open();
            }
            DbCommand getByUser = new SqlCommand();
            getByUser.CommandText = cmdText;
            getByUser.Connection = LongConnection;
            DbDataReader result = getByUser.ExecuteReader();
            return result;
        }
    }
}
