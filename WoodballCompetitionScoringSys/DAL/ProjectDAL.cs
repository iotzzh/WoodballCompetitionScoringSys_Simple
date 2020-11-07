using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using WoodballCompetitionScoringSys.Model;

namespace WoodballCompetitionScoringSys.DAL
{
    public static class ProjectDAL
    {
        public static void Save(ProjectModel model) 
        {
            var sql = new StringBuilder();
            sql.Append($"insert into PROJECT (ID, NAME, ORGANZIER, DATE, PLACE, CREATE_TIME, PROJECT_TYPE) " +
                $"values('{model.Id}', '{model.Name}', '{model.Organzier}', '{model.Date}', '{model.Place}', datetime('now', 'localtime'), '{model.ProjectType}');");
            SQLiteHelper.ExecuteNonQuery(SQLiteHelper.LocalDbConnectionString, sql.ToString(), CommandType.Text);
        }

        public static void UpdateById(ProjectModel model)
        {
            var sql = new StringBuilder();
            sql.Append($"update project set name = '{model.Name}', organzier = '{model.Organzier}', date = '{model.Date}', place='{model.Place}', project_type='{model.ProjectType}' where id='{model.Id}';");
            SQLiteHelper.ExecuteNonQuery(SQLiteHelper.LocalDbConnectionString, sql.ToString(), CommandType.Text);
        }

        public static void DeleteById(string id)
        {
            var sql = string.Format("delete from project where id = '{0}'", id);
            SQLiteHelper.ExecuteNonQuery(SQLiteHelper.LocalDbConnectionString, sql, CommandType.Text);
        }

        public static List<ProjectModel> FindAll()
        {
            var result = new List<ProjectModel>();
            var sql = "select * from project;";
            var dataSet = SQLiteHelper.ExecuteDataSet(SQLiteHelper.LocalDbConnectionString, sql.ToString(), CommandType.Text);
            var rows = dataSet.Tables[0].Rows;
            for (var i = 0; i < rows.Count; i++ )
            {
                var model = new ProjectModel();
                model.Id = rows[i].ItemArray[0] != DBNull.Value ? (string)rows[i].ItemArray[0] : "";
                model.Name = rows[i].ItemArray[1] != DBNull.Value ? (string)rows[i].ItemArray[1] : "";
                model.Organzier = rows[i].ItemArray[2] != DBNull.Value ? (string)rows[i].ItemArray[2] : "";
                model.Date = rows[i].ItemArray[3] != DBNull.Value ? (string)rows[i].ItemArray[3] : "";
                model.Place = rows[i].ItemArray[4] != DBNull.Value ? (string)rows[i].ItemArray[4] : "";
                model.ProjectType = rows[i].ItemArray[6] != DBNull.Value ? (string)rows[i].ItemArray[6] : "";

                result.Add(model);
            }

            return result;
        }
    }
}