using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WoodballCompetitionScoringSys.Model;

namespace WoodballCompetitionScoringSys.DAL
{
    public class GroupDAL
    {
        public static List<GroupModel> FindAll()
        {
            var result = new List<GroupModel>();
            var sql = "select * from group_name;";
            var dataSet = SQLiteHelper.ExecuteDataSet(SQLiteHelper.LocalDbConnectionString, sql.ToString(), CommandType.Text);
            var rows = dataSet.Tables[0].Rows;
            for (var i = 0; i < rows.Count; i++)
            {
                var model = new GroupModel();
                model.Id = rows[i].ItemArray[0] != DBNull.Value ? (string)rows[i].ItemArray[0] : "";
                model.Name = rows[i].ItemArray[1] != DBNull.Value ? (string)rows[i].ItemArray[1] : "";
                model.CreateTime = rows[i].ItemArray[2] != DBNull.Value ? (string)rows[i].ItemArray[2] : "";

                result.Add(model);
            }

            return result.OrderBy(x => x.CreateTime).ToList();
        }

        public static void Insert(GroupModel model) 
        {
            var sql = $"insert into group_name(id, name, create_time) values ('{model.Id}','{model.Name}', datetime('now', 'localtime'))";
            SQLiteHelper.ExecuteNonQuery(SQLiteHelper.LocalDbConnectionString, sql, CommandType.Text);
        }

        public static void DeleteById(string id)
        {
            var sql = $"delete from group_name where id = '{id}'";
            SQLiteHelper.ExecuteNonQuery(SQLiteHelper.LocalDbConnectionString, sql, CommandType.Text);
        }
    }
}
