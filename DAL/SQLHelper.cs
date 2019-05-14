using System;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using System.Collections.Generic;
namespace SystemMgr.DAL
{
    /// <summary>
    /// 数据访问抽象基础类
    /// Copyright (C) Maticsoft
    /// </summary>
    public abstract class SqlHelper
    {
        //数据库连接字符串(web.config来配置)，多数据库可使用SqlHelperP来实现.  

        public static readonly string connstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        private static Hashtable parmCache = Hashtable.Synchronized(new Hashtable());
        private static SqlConnection con;
        private static SqlCommand cmd;

        private static SqlDataAdapter sda;
        private static SqlDataReader sdr;
        private static DataSet ds;
        private static DataView dv;

        public SqlHelper()
        {            
        }
 
        public static SqlConnection getConnection()//定义成静态的，很重要！
        {
            return new SqlConnection(connstring);
        }
        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public static void OpenDataBase()
        {
            con = new SqlConnection(connstring);
            con.Open();
        }
        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public static void CloseDataBase()
        {

            con.Close();
            con.Dispose();

        }
        /// <summary>
        /// 返回DataSet数据集
        /// </summary>
        /// <param name="SqlStr">数据库查询字符串</param>
        /// <returns>dataset</returns>
        public static DataSet GetDs(string SqlStr, string TableName)
        {
            OpenDataBase();
            sda = new SqlDataAdapter(SqlStr, con);
            ds = new DataSet();
            sda.Fill(ds, TableName);
            CloseDataBase();
            return ds;
        }
        public static DataView GetDv(string SqlStr)
        {
            OpenDataBase();
            sda = new SqlDataAdapter(SqlStr, con);
            ds = new DataSet();
            sda.Fill(ds);
            dv = ds.Tables[0].DefaultView;
            CloseDataBase();
            return dv;

        }
        /// <summary>
        /// 返回Datareader对象
        /// </summary>
        /// <param name="Sqlstr">查询字符串</param>
        /// <returns>返回值</returns>
        public static SqlDataReader GetDataReader(string Sqlstr)
        {
            OpenDataBase();
            cmd = new SqlCommand(Sqlstr, con);
            sdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            return sdr;


        }

        /// <summary>
        /// 执行Sql语句方法没有返回值
        /// </summary>
        /// <param name="SqlStr">传入的查询参数</param>
        public static void RunSql(string SqlStr)
        {
            OpenDataBase();
            cmd = new SqlCommand(SqlStr, con);
            cmd.ExecuteNonQuery();
            CloseDataBase();
        }


        /// <summary>
        /// 执行Sql语句方法没有返回值
        /// </summary>
        /// <param name="SqlStr">传入的查询参数</param>
        public static bool RunSqlBool(string SqlStr)
        {
            bool b = true;
            OpenDataBase();
            cmd = new SqlCommand(SqlStr, con);
            if (cmd.ExecuteNonQuery() > 0)
            { }
            else
                b = false;
            CloseDataBase();

            return b;
        }

        /// <summary>
        /// 返回查询结果的首行首列
        /// </summary>
        /// <param name="SqlStr">查询字符串</param>
        /// <returns>返回结果</returns>
        public static string ReturnSql(string SqlStr)
        {
            OpenDataBase();
            string ReturnSql = "";
            try
            {
                cmd = new SqlCommand(SqlStr, con);
                ReturnSql = cmd.ExecuteScalar().ToString();
            }
            catch { }
            CloseDataBase();
            return ReturnSql;
        }
      
   
    }

}
