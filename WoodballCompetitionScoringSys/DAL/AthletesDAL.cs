using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WoodballCompetitionScoringSys.Model;

namespace WoodballCompetitionScoringSys.DAL
{
    public static class AthletesDAL
    {
        public static void DeleteAllBySexAndGroup(string projectId, string groupName)
        {
            var sql = $"delete from athletes where project_id='{projectId}' and group_name='{groupName}'";
            SQLiteHelper.ExecuteNonQuery(SQLiteHelper.LocalDbConnectionString, sql, CommandType.Text);
        }

        public static void InsertBatch(List<AthleteModel> athletes)
        {
            var sql = new StringBuilder();
            sql.Append("insert into athletes(id, name, sex, project_id, group_name, team_name, create_time) values");
            foreach (var athlete in athletes)
            {
                sql.Append($"('{athlete.Id}','{athlete.Name}','{athlete.Sex}','{athlete.ProjectId}','{athlete.GroupName}','{athlete.TeamName}',datetime('now', 'localtime')),");
            }
            sql.Remove(sql.Length - 1, 1);
            SQLiteHelper.ExecuteNonQuery(SQLiteHelper.LocalDbConnectionString, sql.ToString(), CommandType.Text);
        }

        public static List<AthleteModel> FindAllByProjectIdGroupName(string projectId, string groupNmae)
        {
            var result = new List<AthleteModel>();
            var sql = $"select * from athletes where project_id = '{projectId}' and group_name='{groupNmae}'";
            var dataSet = SQLiteHelper.ExecuteDataSet(SQLiteHelper.LocalDbConnectionString, sql, CommandType.Text);

            var rows = dataSet.Tables[0].Rows;
            for (var i = 0; i < rows.Count; i++)
            {
                var model = new AthleteModel();
                model.Id = rows[i].ItemArray[0] != DBNull.Value ? (string)rows[i].ItemArray[0] : "";
                model.Name = rows[i].ItemArray[1] != DBNull.Value ? (string)rows[i].ItemArray[1] : "";
                model.Sex = rows[i].ItemArray[2] != DBNull.Value ? (string)rows[i].ItemArray[2] : "";
                model.ProjectId = rows[i].ItemArray[3] != DBNull.Value ? (string)rows[i].ItemArray[3] : "";
                model.GroupName = rows[i].ItemArray[4] != DBNull.Value ? (string)rows[i].ItemArray[4] : "";
                model.TeamName = rows[i].ItemArray[5] != DBNull.Value ? (string)rows[i].ItemArray[5] : "";
                model.Score = rows[i].ItemArray[6] != DBNull.Value ? (decimal)rows[i].ItemArray[6] : 0;

                result.Add(model);
            }

            return result;
        }

        public static void UpdateAthleteScore(string athleteId, decimal score)
        {
            var sql = $"update athletes set score = '{score}' where id = '{athleteId}'";
            SQLiteHelper.ExecuteNonQuery(SQLiteHelper.LocalDbConnectionString, sql, CommandType.Text);
        }
    }
}
