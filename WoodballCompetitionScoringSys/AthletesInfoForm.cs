using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WoodballCompetitionScoringSys.Common;
using WoodballCompetitionScoringSys.DAL;
using WoodballCompetitionScoringSys.Model;

namespace WoodballCompetitionScoringSys
{
    public partial class AthletesInfoForm : Form
    {
        public readonly string AssetDirecotory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets");
        public string ProjectId { get; set; }

        public string ProjectType { get; set; }

        public string ProjectName { get; set; }

        public string GroupName { get; set; }

        // 设置自适应屏幕
        private AutoSizeFormClass asc = new AutoSizeFormClass();

        // 单例模式，每次点击都只是打开一个窗口
        private static AthletesInfoForm instance;

        public static AthletesInfoForm GetInstance()
        {
            if (instance == null)
            {
                instance = new AthletesInfoForm();
            }
            return instance;
        }

        private AthletesInfoForm()
        {
            InitializeComponent();
        }

        private void ImportPersonInfoForm_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);

            this.Text = $"木球竞赛计分系统 - {this.ProjectType}";

            // 设置组别
            SetComboGrop();

            RefreshAthletes();

            if (ProjectType == "男子团体赛" || ProjectType == "女子团体赛")
            {
                if (this.dataGridViewX1 != null && 
                    this.dataGridViewX1.Columns[1] != null &&
                    this.dataGridViewX1.Columns[1].Width != 480)
                {
                    this.dataGridViewX1.Columns[1].Width = 480;
                }
            }

            //"男子团体赛",
            //"女子团体赛",
            //"男子个人赛",
            //"女子个人赛",
            //"男子双打赛",
            //"女子双打赛",
            //"混合双打赛"

            if (ProjectType == "男子双打赛")
            {
                this.pictureBox1.ImageLocation = Path.Combine(AssetDirecotory, "男双.jpg");
            }
            else if (ProjectType == "女子双打赛")
            {
                this.pictureBox1.ImageLocation = Path.Combine(AssetDirecotory, "女双.jpg");
            }
            else if (ProjectType == "混合双打赛")
            {
                this.pictureBox1.ImageLocation = Path.Combine(AssetDirecotory, "混打.jpg");
            }
            else
            {
                this.pictureBox1.ImageLocation = Path.Combine(AssetDirecotory, "团体赛和个人赛.jpg");
            }
        }

        private void SetComboGrop()
        {
            var groupNames = GroupDAL.FindAll();

            foreach (var group in groupNames)
            {
                if (!this.ComboGroup.Items.Contains(group.Name))
                {
                    this.ComboGroup.Items.Add(group.Name);
                }
            }

            if (this.ComboGroup.SelectedIndex == -1)
            {
                this.ComboGroup.SelectedIndex = 0;
            }
            this.GroupName = this.ComboGroup.SelectedItem.ToString();
        }

        public void RefreshAthletes()
        {
            var dt = addProjectData(); // clear origin data if data updated by add/update action
            var allAthletes = AthletesDAL.FindAllByProjectIdGroupName(this.ProjectId, GroupName);
            allAthletes.Sort((x,y) => string.Compare(x.TeamName, y.TeamName));
            for (var i = 0; i < allAthletes.Count; i++)
            {
                var row = dt.NewRow();
                row["ID"] = allAthletes[i].Id;
                row["姓名(Name)"] = allAthletes[i].Name;
                row["性别(Sex)"] = allAthletes[i].Sex;
                row["队伍名称(Team Name)"] = allAthletes[i].TeamName;
                row["组别(Group Name)"] = allAthletes[i].GroupName;
                row["分数(Score)"] = allAthletes[i].Score;
                dt.Rows.Add(row);
            }

            this.dataGridViewX1.DataSource = dt;
            this.dataGridViewX1.Columns["ID"].Visible = false;
        }

        private static DataTable addProjectData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("姓名(Name)", typeof(string));
            dt.Columns.Add("性别(Sex)", typeof(string));
            dt.Columns.Add("队伍名称(Team Name)", typeof(string));
            dt.Columns.Add("组别(Group Name)", typeof(string));
            dt.Columns.Add("分数(Score)", typeof(string));

            return dt;
        }

        private void ImportPersonInfoForm_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }

        private void buttonImportAthletesInfo_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            var path = file.FileName;

            if (string.IsNullOrWhiteSpace(path))
                return;
            var athletes = new List<AthleteModel>();
            try
            {
                athletes = ExcelHelper.GetAllAthletesInfo(path, GroupName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("文件无法打开，请检查文件是否已被打开或被破坏。");
                return;
            }

            // save data into db
            if (athletes.Count > 0)
            {
                // 删除数据库已有数据
                AthletesDAL.DeleteAllBySexAndGroup(this.ProjectId, GroupName);

                // 添加新数据
                athletes.ForEach(x => { x.ProjectId = this.ProjectId; x.Id = System.Guid.NewGuid().ToString(); });

                if (ProjectType == "男子团体赛" || ProjectType == "女子团体赛")
                {
                    var newAthletes = CombineNameByTeamName(athletes);
                    AthletesDAL.InsertBatch(newAthletes);
                }
                else
                {
                    AthletesDAL.InsertBatch(athletes);
                }
            }

            // refresh datagridview
            RefreshAthletes();
        }

        private List<AthleteModel> CombineNameByTeamName(List<AthleteModel> athletes)
        {
            var result = new List<AthleteModel>();
            var teamNames = athletes.Select(x => x.TeamName).Distinct();

            foreach (var team in teamNames)
            {
                if (result.Where(x => x.TeamName == team).FirstOrDefault() == null)
                {
                    AthleteModel model = new AthleteModel();
                    model = athletes.Where(x => x.TeamName == team).FirstOrDefault();
                    model.Name = string.Join(",", athletes.Where(x => x.TeamName == team).Select(y => y.Name));
                    result.Add(model);
                }
            }
            return result;
        }

        private void dataGridViewX1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // 获取当前行
                var selectRows = dataGridViewX1.SelectedRows;
                if (selectRows.Count > 0)
                {
                    SetScore form = new SetScore(selectRows[0]);
                    form.ShowDialog();
                }
            }
        }

        private void BtnSetScore_Click(object sender, EventArgs e)
        {
            // 获取当前行
            var selectRows = dataGridViewX1.SelectedRows;
            if (selectRows.Count > 0)
            {
                SetScore form = new SetScore(selectRows[0]);
                form.ShowDialog();
            }
        }

        private void ComboGroup_SelectedValueChanged(object sender, EventArgs e)
        {
            this.GroupName = this.ComboGroup.SelectedItem.ToString();
            RefreshAthletes();
        }

        private void LabelOpenReport_MouseHover(object sender, EventArgs e)
        {
            this.LabelOpenReport.ForeColor = Color.Red;
        }

        private void LabelOpenReport_MouseLeave(object sender, EventArgs e)
        {
            this.LabelOpenReport.ForeColor = Color.Gray;
        }

        private void LabelExport_MouseHover(object sender, EventArgs e)
        {
            this.LabelExport.ForeColor = Color.Red;
        }

        private void LabelExport_MouseLeave(object sender, EventArgs e)
        {
            this.LabelExport.ForeColor = Color.Gray;
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            var allAthletes = AthletesDAL.FindAllByProjectIdGroupName(this.ProjectId, GroupName);
            var fileName = $"{ProjectName}-{ProjectType}-{DateTime.Now.ToString("yyyyMMddHHmmss")}";
            ExcelHelper.ExportReport(allAthletes, fileName, ProjectType);
        }

        private void LabelOpenReport_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Report\");
        }

        private void LabelExport_Click(object sender, EventArgs e)
        {
            var path = "";
            if (ProjectType == "男子双打赛")
            {
                path = Path.Combine(AssetDirecotory, "男双.xls");
            }
            else if (ProjectType == "女子双打赛")
            {
                path = Path.Combine(AssetDirecotory, "女双.xls");
            }
            else if (ProjectType == "混合双打赛")
            {
                path = Path.Combine(AssetDirecotory, "混打.xls");
            }
            else
            {
                path = Path.Combine(AssetDirecotory, "团体赛和个人赛.xls");
            }

            System.Diagnostics.Process.Start(path);
        }
    }
}