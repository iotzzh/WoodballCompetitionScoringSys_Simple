namespace WoodballCompetitionScoringSys
{
    partial class IndexForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.titleChinese = new System.Windows.Forms.Label();
            this.titleEnglish = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAddProject = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelUpdateProject = new DevComponents.DotNetBar.LabelX();
            this.BtnCreateCompetitionList = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btnCloseApp = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.BtnGroupManager = new DevComponents.DotNetBar.ButtonX();
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Location = new System.Drawing.Point(0, 0);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(0, 0);
            this.buttonX1.TabIndex = 0;
            // 
            // titleChinese
            // 
            this.titleChinese.AutoSize = true;
            this.titleChinese.BackColor = System.Drawing.Color.Transparent;
            this.titleChinese.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.titleChinese.Font = new System.Drawing.Font("华文彩云", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleChinese.ForeColor = System.Drawing.Color.Transparent;
            this.titleChinese.Location = new System.Drawing.Point(167, 23);
            this.titleChinese.Name = "titleChinese";
            this.titleChinese.Size = new System.Drawing.Size(346, 41);
            this.titleChinese.TabIndex = 1;
            this.titleChinese.Text = "木球竞赛计分系统";
            // 
            // titleEnglish
            // 
            this.titleEnglish.AutoSize = true;
            this.titleEnglish.BackColor = System.Drawing.Color.Transparent;
            this.titleEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.titleEnglish.Font = new System.Drawing.Font("Segoe Print", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleEnglish.ForeColor = System.Drawing.Color.Transparent;
            this.titleEnglish.Location = new System.Drawing.Point(262, 62);
            this.titleEnglish.Name = "titleEnglish";
            this.titleEnglish.Size = new System.Drawing.Size(602, 44);
            this.titleEnglish.TabIndex = 6;
            this.titleEnglish.Text = "The Wooden Ball Competition Scoring System";
            this.titleEnglish.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Controls.Add(this.titleChinese);
            this.pictureBox1.Controls.Add(this.titleEnglish);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(998, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelAddProject
            // 
            // 
            // 
            // 
            this.labelAddProject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelAddProject.Font = new System.Drawing.Font("楷体", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAddProject.ForeColor = System.Drawing.Color.Black;
            this.labelAddProject.Location = new System.Drawing.Point(12, 125);
            this.labelAddProject.Margin = new System.Windows.Forms.Padding(0);
            this.labelAddProject.Name = "labelAddProject";
            this.labelAddProject.Size = new System.Drawing.Size(308, 33);
            this.labelAddProject.TabIndex = 8;
            this.labelAddProject.Text = "添加比赛项目(Add Events)";
            this.labelAddProject.Click += new System.EventHandler(this.labelAddProject_Click);
            this.labelAddProject.MouseLeave += new System.EventHandler(this.labelAddProject_MouseLeave);
            this.labelAddProject.MouseHover += new System.EventHandler(this.labelAddProject_MouseHover);
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(12, 160);
            this.dataGridViewX1.MultiSelect = false;
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RowHeadersWidth = 51;
            this.dataGridViewX1.RowTemplate.Height = 27;
            this.dataGridViewX1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(684, 399);
            this.dataGridViewX1.TabIndex = 7;
            this.dataGridViewX1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewX1_CellMouseDown);
            // 
            // labelUpdateProject
            // 
            // 
            // 
            // 
            this.labelUpdateProject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelUpdateProject.Font = new System.Drawing.Font("楷体", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUpdateProject.ForeColor = System.Drawing.Color.Black;
            this.labelUpdateProject.Location = new System.Drawing.Point(326, 125);
            this.labelUpdateProject.Margin = new System.Windows.Forms.Padding(0);
            this.labelUpdateProject.Name = "labelUpdateProject";
            this.labelUpdateProject.Size = new System.Drawing.Size(348, 33);
            this.labelUpdateProject.TabIndex = 12;
            this.labelUpdateProject.Text = "更新比赛项目(Update Events)";
            this.labelUpdateProject.Click += new System.EventHandler(this.labelUpdateProject_Click);
            this.labelUpdateProject.MouseLeave += new System.EventHandler(this.labelUpdateProject_MouseLeave);
            this.labelUpdateProject.MouseHover += new System.EventHandler(this.labelUpdateProject_MouseHover);
            // 
            // BtnCreateCompetitionList
            // 
            this.BtnCreateCompetitionList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnCreateCompetitionList.BackColor = System.Drawing.Color.Transparent;
            this.BtnCreateCompetitionList.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnCreateCompetitionList.Controls.Add(this.labelX4);
            this.BtnCreateCompetitionList.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCreateCompetitionList.Location = new System.Drawing.Point(699, 241);
            this.BtnCreateCompetitionList.Name = "BtnCreateCompetitionList";
            this.BtnCreateCompetitionList.Size = new System.Drawing.Size(242, 75);
            this.BtnCreateCompetitionList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnCreateCompetitionList.TabIndex = 9;
            this.BtnCreateCompetitionList.Text = "设置参赛名单";
            this.BtnCreateCompetitionList.Click += new System.EventHandler(this.BtnCreateCompetitionList_Click);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Enabled = false;
            this.labelX4.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX4.Location = new System.Drawing.Point(3, 45);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(236, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Create Competition List";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCloseApp.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCloseApp.Controls.Add(this.labelX3);
            this.btnCloseApp.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCloseApp.Location = new System.Drawing.Point(699, 322);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(242, 75);
            this.btnCloseApp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCloseApp.TabIndex = 11;
            this.btnCloseApp.Text = "关闭程序";
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Enabled = false;
            this.labelX3.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.Location = new System.Drawing.Point(3, 45);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(236, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Close The Application";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Enabled = false;
            this.labelX1.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(3, 45);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(236, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Category Management";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // BtnGroupManager
            // 
            this.BtnGroupManager.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnGroupManager.BackColor = System.Drawing.Color.Transparent;
            this.BtnGroupManager.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnGroupManager.Controls.Add(this.labelX1);
            this.BtnGroupManager.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnGroupManager.Location = new System.Drawing.Point(699, 160);
            this.BtnGroupManager.Name = "BtnGroupManager";
            this.BtnGroupManager.Size = new System.Drawing.Size(242, 75);
            this.BtnGroupManager.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnGroupManager.TabIndex = 13;
            this.BtnGroupManager.Text = "组别管理";
            this.BtnGroupManager.Click += new System.EventHandler(this.BtnGroupManager_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(995, 677);
            this.Controls.Add(this.BtnGroupManager);
            this.Controls.Add(this.labelAddProject);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.labelUpdateProject);
            this.Controls.Add(this.BtnCreateCompetitionList);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "木球竞赛计分系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IndexForm_Load);
            this.SizeChanged += new System.EventHandler(this.IndexForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pictureBox1.ResumeLayout(false);
            this.pictureBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.BtnCreateCompetitionList.ResumeLayout(false);
            this.btnCloseApp.ResumeLayout(false);
            this.BtnGroupManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.Label titleChinese;
        private System.Windows.Forms.Label titleEnglish;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.LabelX labelAddProject;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.LabelX labelUpdateProject;
        private DevComponents.DotNetBar.ButtonX BtnCreateCompetitionList;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX btnCloseApp;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX BtnGroupManager;
    }
}

