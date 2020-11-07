using DevComponents.DotNetBar.Controls;
using System;
using System.Data;
using System.Windows.Forms;
using WoodballCompetitionScoringSys.DAL;
using WoodballCompetitionScoringSys.Model;

namespace WoodballCompetitionScoringSys
{
    public partial class IndexForm : Form
    {
        private AutoSizeFormClass asc = new AutoSizeFormClass();

        public IndexForm()
        {
            InitializeComponent();
        }

        private void IndexForm_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
            RefreshProject();
        }

        public void RefreshProject() 
        {
            var dt = addProjectData(); // clear origin data if data updated by add/update action
            var allProject = ProjectDAL.FindAll();
            for (var i = 0; i < allProject.Count; i++) 
            {
                var row = dt.NewRow();
                row["ID"] = allProject[i].Id;
                row["名称(Name)"] = allProject[i].Name;
                row["项目类别(Type)"] = allProject[i].ProjectType;
                row["承办(Organzier)"] = allProject[i].Organzier;
                row["时间(Date)"] = allProject[i].Date;
                row["地点(Place)"] = allProject[i].Place;
                dt.Rows.Add(row);
            }

            this.dataGridViewX1.DataSource = dt;
            this.dataGridViewX1.Columns["ID"].Visible = false;
        }



        private static DataTable addProjectData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("名称(Name)", typeof(string));
            dt.Columns.Add("项目类别(Type)", typeof(string));
            dt.Columns.Add("承办(Organzier)", typeof(string));
            dt.Columns.Add("时间(Date)", typeof(string));
            dt.Columns.Add("地点(Place)", typeof(string));

            return dt;
        }

        private void labelAddProject_MouseHover(object sender, EventArgs e)
        {
            this.labelAddProject.ForeColor = System.Drawing.Color.Red;
        }

        private void labelAddProject_MouseLeave(object sender, EventArgs e)
        {
            this.labelAddProject.ForeColor = System.Drawing.Color.Black;
        }

        private void labelUpdateProject_MouseHover(object sender, EventArgs e)
        {
            this.labelUpdateProject.ForeColor = System.Drawing.Color.Red;
        }

        private void labelUpdateProject_MouseLeave(object sender, EventArgs e)
        {
            this.labelUpdateProject.ForeColor = System.Drawing.Color.Black;
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelAddProject_Click(object sender, EventArgs e)
        {
            ProjectForm form = new ProjectForm(this);
            form.ShowDialog();
        }

        private void labelUpdateProject_Click(object sender, EventArgs e)
        {
            var selectedProject = GetSelectedProject();
            ProjectForm form = new ProjectForm(this, selectedProject);
            form.ShowDialog();
        }

        private ProjectModel GetSelectedProject() 
        {
            var result = new ProjectModel();
            var selectedRows = this.dataGridViewX1.SelectedRows;
            result.Id = selectedRows[0].Cells[0].Value != null ? selectedRows[0].Cells[0].Value.ToString(): "";
            result.Name = selectedRows[0].Cells[1].Value != null ? selectedRows[0].Cells[1].Value.ToString(): "";
            result.ProjectType = selectedRows[0].Cells[2].Value != null ? selectedRows[0].Cells[2].Value.ToString(): "";
            result.Organzier = selectedRows[0].Cells[3].Value != null ? selectedRows[0].Cells[3].Value.ToString(): "";
            result.Date = selectedRows[0].Cells[4].Value != null ? selectedRows[0].Cells[4].Value.ToString(): "";
            result.Place = selectedRows[0].Cells[5].Value != null ? selectedRows[0].Cells[5].Value.ToString(): "";

            return result;
        }

        private void dataGridViewX1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // 获取当前行
                var selectRows = dataGridViewX1.SelectedRows;
                if (MessageBox.Show("是否删除选中行？", "友情提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (selectRows.Count > 0)
                    {
                        ProjectDAL.DeleteById(selectRows[0].Cells[0].Value?.ToString());
                        RefreshProject();
                    }
                }
            }
        }

        private void BtnCreateCompetitionList_Click(object sender, EventArgs e)
        {
            var selectedProject = dataGridViewX1.SelectedRows.Count > 0 ? dataGridViewX1.SelectedRows[0] : null;
            if (selectedProject == null)
            {
                MessageBox.Show("没有项目被选中，请选择一个项目");
            }

            AthletesInfoForm form = AthletesInfoForm.GetInstance();
            form.ProjectId = selectedProject.Cells[0].Value?.ToString();
            form.ProjectType = selectedProject.Cells[2].Value?.ToString();
            form.ProjectName = selectedProject.Cells[1].Value?.ToString();
            form.ShowDialog();
        }

        private void BtnGroupManager_Click(object sender, EventArgs e)
        {
            GroupsManage form = new GroupsManage();
            form.ShowDialog();
        }
    }
}