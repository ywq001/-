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

        public int ExecuteNonQuery(string cmdText, params DbParameter[] parameters)
        {
            if (new DBHelper().LongConnection.State == ConnectionState.Closed)
            {
                LongConnection.Open();
            }
            DbCommand command = new SqlCommand();
            command.CommandText = cmdText;
            for (int i = 0; i < parameters.Length; i++)
            {
                command.Parameters.Add(parameters[i]);
            }
            command.Connection = LongConnection;
            int result = command.ExecuteNonQuery();
            LongConnection.Close();
            return result;
        }

        public object ExecuteScalar(string cmdText, DbParameter[] parameters)
        {
            if (new DBHelper().LongConnection.State == ConnectionState.Closed)
            {
                LongConnection.Open();
            }
            DbCommand command = new SqlCommand();
            command.CommandText = cmdText;
            for (int i = 0; i < parameters.Length; i++)
            {
                command.Parameters.Add(parameters[i]);
            }
            command.Connection = LongConnection;
            object result = command.ExecuteScalar();
            LongConnection.Close();
            return result;
        }

        public DbDataReader ExecuteReader(string cmdText,params DbParameter[] parameters)
        {
            if (new DBHelper().LongConnection.State == ConnectionState.Closed)
            {
                LongConnection.Open();
            }
            DbCommand command = new SqlCommand();
            command.CommandText = cmdText;
            for (int i = 0; i < parameters.Length; i++)
            {
                command.Parameters.Add(parameters[i]);
            }
            command.Connection = LongConnection;
            DbDataReader dataReader= command.ExecuteReader();
            LongConnection.Close();
            return dataReader;
        }
    }
}
