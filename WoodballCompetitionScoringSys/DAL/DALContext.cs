using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Text;

namespace WoodballCompetitionScoringSys.DAL
{
    public class DALContext
    {
        private static string dbName = "SysDB";


        //数据库连接
        private static  SQLiteConnection sqlConnection = new SQLiteConnection(SQLiteHelper.LocalDbConnectionString);

        public static void Open()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dbName);
            // 如果数据库不存在就创建一个
            if (!File.Exists(path))
            {
                SQLiteConnection.CreateFile(dbName);
            }
            else
            {
                // 连接sqlite
                sqlConnection.Open();
            }

            CreateTables();
        }

        // 创建所有的表
        public static void CreateTables()
        {
            var createProjectTableSQL = @"
                                        create table PROJECT(
                                            ID varchar(255),
                                            NAME varchar(255),
                                            ORGANZIER varchar(255),
                                            DATE varchar(255),
                                            PLACE varchar(255),
                                            CREATE_TIME varchar(255),
                                            PROJECT_TYPE varchar(255)
                                        );            
                                      ";
            var createGroupTableSQL = @"
                                        create table GROUP_NAME(
                                            ID varchar(255),
                                            NAME varchar(255),
                                            CREATE_TIME varchar(255)
                                        );          
                                      ";

            var createAthletesTableSQL = @"
                                         create table ATHLETES(
                                             ID varchar(255),
                                             NAME varchar(255),
                                             SEX varchar(255),
                                             PROJECT_ID varchar(255),
                                             GROUP_NAME varchar(255),
                                             TEAM_NAME varchar(255),
                                             SCORE NUMERIC,
                                             CREATE_TIME varchar(255)
                                         );        
                                      ";
            if (!TableExist("PROJECT"))
            {
                // create PROJECT table
                SQLiteHelper.ExecuteNonQuery(SQLiteHelper.LocalDbConnectionString, createProjectTableSQL, CommandType.Text);
            }
            if (!TableExist("GROUP_NAME"))
            {
                // create GROUP_NAME table
                SQLiteHelper.ExecuteNonQuery(SQLiteHelper.LocalDbConnectionString, createGroupTableSQL, CommandType.Text);
            }
            if (!TableExist("ATHLETES"))
            {
                // create ATHLETES table
                SQLiteHelper.ExecuteNonQuery(SQLiteHelper.LocalDbConnectionString, createAthletesTableSQL, CommandType.Text);
            }

        }

        private static bool TableExist(string tableName)
        {
            var result = false;

            StringBuilder sql = new StringBuilder();
            sql.Append($"select * from sqlite_master where type = 'table' and name = '{tableName}'");
            var dataSet = SQLiteHelper.ExecuteDataSet(SQLiteHelper.LocalDbConnectionString, sql.ToString(), CommandType.Text);
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                result = true;
            }

            return result;
        }
    }
}