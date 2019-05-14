using System;
using System.Collections.Generic;
using System.Text;
using SystemMgr.DAL; 
using System.Data;
using System.Data.SqlClient;

namespace SystemMgr.BLL
{
    public class Common
    { 

        public static string GetWebTitle()
        {
            return "基于asp.net的初中信息技术教学平台设计与实现";
        }

        public static SqlConnection getConnection()//定义成静态的，很重要！
        {
            return SystemMgr.DAL.SqlHelper.getConnection();
        }
        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public void OpenDataBase()
        {
            SystemMgr.DAL.SqlHelper.OpenDataBase();
        }
        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void CloseDataBase()
        {
              SystemMgr.DAL.SqlHelper.CloseDataBase();
        }

        /// <summary>
        /// 返回DataSet数据集
        /// </summary>
        /// <param name="SqlStr">数据库查询字符串</param>
        /// <returns>dataset</returns>
        public static DataSet GetDs(string SqlStr, string TableName)
        {
            return  SystemMgr.DAL.SqlHelper.GetDs(SqlStr, TableName);
        }

        public static DataView GetDv(string SqlStr)
        {
            return  SystemMgr.DAL.SqlHelper.GetDv(SqlStr);
        }

        /// <summary>
        /// 返回Datareader对象
        /// </summary>
        /// <param name="Sqlstr">查询字符串</param>
        /// <returns>返回值</returns>
        public static SqlDataReader GetDataReader(string Sqlstr)
        {
            return  SystemMgr.DAL.SqlHelper.GetDataReader(Sqlstr);
        }

        /// <summary>
        /// 执行Sql语句方法没有返回值
        /// </summary>
        /// <param name="SqlStr">传入的查询参数</param>
        public static void RunSql(string SqlStr)
        {
              SystemMgr.DAL.SqlHelper.RunSql(SqlStr);
        }

        /// <summary>
        /// 执行Sql语句方法没有返回值
        /// </summary>
        /// <param name="SqlStr">传入的查询参数</param>
        public static bool RunSqlBool(string SqlStr)
        {
            return  SystemMgr.DAL.SqlHelper.RunSqlBool(SqlStr);
        }

        /// <summary>
        /// 返回查询结果的首行首列
        /// </summary>
        /// <param name="SqlStr">查询字符串</param>
        /// <returns>返回结果</returns>
        public static string ReturnSql(string SqlStr)
        {
            return  SystemMgr.DAL.SqlHelper.ReturnSql(SqlStr);
        }


        /// <summary>
        /// 返回党政思建列表记录 
        /// </summary>
        /// <returns>DateSet</returns>
        public static DataSet GetKejianList() 
        {
            return SystemMgr.DAL.DalCommon.GetKejianList();
        }

    }

}
