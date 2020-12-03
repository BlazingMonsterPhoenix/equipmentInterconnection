using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace generalizedService
{
    class MySqlUtil
    {
        private static MySqlConnection connection = new MySqlConnection(GlobleParams.getConnectionString());

        /**
         * 执行sql语句
         * */
        public static void executeSql(string sql)
        {
            MySqlConnection conn = getConnection();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                MySqlCommand cmd1 = new MySqlCommand(sql, conn);
                cmd1.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                transaction.Rollback();
                closeConnection();
            }
            finally
            {
                //这样写是否会存在问题？
                transaction.Commit();
                closeConnection();
            }
        }

        /**
         * 进行数据库连接
         * */
        private static MySqlConnection getConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        /**
         * 关闭数据库连接
         * */
        private static void closeConnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        
    }
}
