using NPOI.HSSF.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WoodballCompetitionScoringSys.DAL;
using WoodballCompetitionScoringSys.Model;

namespace WoodballCompetitionScoringSys
{
    public partial class GroupsManage : Form
    {
        public GroupsManage()
        {
            InitializeComponent();
        }

        private void GroupsManage_Load(object sender, EventArgs e)
        {
            RefreshGroup();
        }

        public void RefreshGroup()
        {
            var dt = addGroupData(); // clear origin data if data updated by add/update action
            var allGroup = GroupDAL.FindAll();
            for (var i = 0; i < allGroup.Count; i++)
            {
                var row = dt.NewRow();
                row["ID"] = allGroup[i].Id;
                row["名称(Name)"] = allGroup[i].Name;
                dt.Rows.Add(row);
            }

            this.dataGridViewX1.DataSource = dt;
            this.dataGridViewX1.Columns["ID"].Visible = false;
        }

        private static DataTable addGroupData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("名称(Name)", typeof(string));
            return dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbGroup.Text))
            {
                var model = new GroupModel();
                model.Id = Guid.NewGuid().ToString();
                model.Name = tbGroup.Text;
                GroupDAL.Insert(model);
                RefreshGroup();
                this.tbGroup.Text = "";
            }
        }

        private void dataGridViewX1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // 获取当前行
                var selectRows = dataGridViewX1.SelectedRows[0];
                var dt = dataGridViewX1.DataSource as DataTable;
                if (MessageBox.Show("删除选中行？", "友情提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var id = selectRows.Cells[0].Value?.ToString();
                    GroupDAL.DeleteById(id);
                    RefreshGroup();
                }
            }
        }

        private void GroupsManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
