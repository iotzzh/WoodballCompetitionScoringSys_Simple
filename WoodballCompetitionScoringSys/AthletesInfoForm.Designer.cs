using System.Drawing;

namespace WoodballCompetitionScoringSys
{
    partial class AthletesInfoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AthletesInfoForm));
            this.buttonImportAthletesInfo = new DevComponents.DotNetBar.ButtonX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.BtnGenerateReport = new DevComponents.DotNetBar.ButtonX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.BtnSetScore = new DevComponents.DotNetBar.ButtonX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.ComboGroup = new System.Windows.Forms.ComboBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.LabelOpenReport = new DevComponents.DotNetBar.LabelX();
            this.LabelExport = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonImportAthletesInfo.SuspendLayout();
            // 
            // buttonImportAthletesInfo
            // 
            this.buttonImportAthletesInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonImportAthletesInfo.BackColor = System.Drawing.Color.Transparent;
            this.buttonImportAthletesInfo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonImportAthletesInfo.Controls.Add(this.labelX9);
            this.buttonImportAthletesInfo.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonImportAthletesInfo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonImportAthletesInfo.Location = new System.Drawing.Point(654, 76);
            this.buttonImportAthletesInfo.Margin = new System.Windows.Forms.Padding(0);
            this.buttonImportAthletesInfo.Name = "buttonImportAthletesInfo";
            this.buttonImportAthletesInfo.Size = new System.Drawing.Size(269, 61);
            this.buttonImportAthletesInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonImportAthletesInfo.TabIndex = 3;
            this.buttonImportAthletesInfo.Text = "导入参赛名单";
            this.buttonImportAthletesInfo.Click += new System.EventHandler(this.buttonImportAthletesInfo_Click);
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Enabled = false;
            this.labelX9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(0, 35);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(269, 23);
            this.labelX9.TabIndex = 0;
            this.labelX9.Text = "Import The List Of Participants";
            this.labelX9.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
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
            this.dataGridViewX1.Location = new System.Drawing.Point(13, 12);
            this.dataGridViewX1.MultiSelect = false;
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RowHeadersVisible = false;
            this.dataGridViewX1.RowHeadersWidth = 51;
            this.dataGridViewX1.RowTemplate.Height = 27;
            this.dataGridViewX1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(638, 450);
            this.dataGridViewX1.TabIndex = 1;
            this.dataGridViewX1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewX1_CellMouseDown);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(653, 334);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(266, 23);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "可导入样式（Excel Format）";
            // 
            // BtnGenerateReport
            // 
            this.BtnGenerateReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnGenerateReport.BackColor = System.Drawing.Color.Transparent;
            this.BtnGenerateReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnGenerateReport.Controls.Add(this.labelX13);
            this.BtnGenerateReport.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnGenerateReport.Location = new System.Drawing.Point(654, 207);
            this.BtnGenerateReport.Name = "BtnGenerateReport";
            this.BtnGenerateReport.Size = new System.Drawing.Size(269, 70);
            this.BtnGenerateReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnGenerateReport.TabIndex = 18;
            this.BtnGenerateReport.Text = "生成报表";
            this.BtnGenerateReport.Click += new System.EventHandler(this.BtnGenerateReport_Click);
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Enabled = false;
            this.labelX13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX13.Location = new System.Drawing.Point(19, 44);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(236, 23);
            this.labelX13.TabIndex = 0;
            this.labelX13.Text = "Generate Report";
            this.labelX13.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Enabled = false;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(0, 35);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(269, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Set The Score";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // BtnSetScore
            // 
            this.BtnSetScore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSetScore.BackColor = System.Drawing.Color.Transparent;
            this.BtnSetScore.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnSetScore.Controls.Add(this.labelX1);
            this.BtnSetScore.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSetScore.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.BtnSetScore.Location = new System.Drawing.Point(654, 140);
            this.BtnSetScore.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSetScore.Name = "BtnSetScore";
            this.BtnSetScore.Size = new System.Drawing.Size(269, 61);
            this.BtnSetScore.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnSetScore.TabIndex = 20;
            this.BtnSetScore.Text = "设置分数";
            this.BtnSetScore.Click += new System.EventHandler(this.BtnSetScore_Click);
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.Location = new System.Drawing.Point(658, 33);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(172, 19);
            this.labelX12.TabIndex = 25;
            this.labelX12.Text = "竞赛组别(Group)";
            // 
            // ComboGroup
            // 
            this.ComboGroup.DropDownWidth = 55;
            this.ComboGroup.FormattingEnabled = true;
            this.ComboGroup.Location = new System.Drawing.Point(658, 52);
            this.ComboGroup.Name = "ComboGroup";
            this.ComboGroup.Size = new System.Drawing.Size(73, 23);
            this.ComboGroup.TabIndex = 23;
            this.ComboGroup.SelectedValueChanged += new System.EventHandler(this.ComboGroup_SelectedValueChanged);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.Location = new System.Drawing.Point(654, 7);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(269, 32);
            this.labelX3.TabIndex = 21;
            this.labelX3.Text = "设置导入条件（conditions）";
            // 
            // LabelOpenReport
            // 
            // 
            // 
            // 
            this.LabelOpenReport.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelOpenReport.Font = new System.Drawing.Font("隶书", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelOpenReport.ForeColor = System.Drawing.Color.Gray;
            this.LabelOpenReport.Location = new System.Drawing.Point(654, 280);
            this.LabelOpenReport.Name = "LabelOpenReport";
            this.LabelOpenReport.Size = new System.Drawing.Size(269, 23);
            this.LabelOpenReport.TabIndex = 27;
            this.LabelOpenReport.Text = "打开历史报表";
            this.LabelOpenReport.Click += new System.EventHandler(this.LabelOpenReport_Click);
            this.LabelOpenReport.MouseLeave += new System.EventHandler(this.LabelOpenReport_MouseLeave);
            this.LabelOpenReport.MouseHover += new System.EventHandler(this.LabelOpenReport_MouseHover);
            // 
            // LabelExport
            // 
            // 
            // 
            // 
            this.LabelExport.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelExport.Font = new System.Drawing.Font("隶书", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelExport.ForeColor = System.Drawing.Color.Gray;
            this.LabelExport.Location = new System.Drawing.Point(653, 309);
            this.LabelExport.Name = "LabelExport";
            this.LabelExport.Size = new System.Drawing.Size(269, 19);
            this.LabelExport.TabIndex = 26;
            this.LabelExport.Text = "导出模板样式";
            this.LabelExport.Click += new System.EventHandler(this.LabelExport_Click);
            this.LabelExport.MouseLeave += new System.EventHandler(this.LabelExport_MouseLeave);
            this.LabelExport.MouseHover += new System.EventHandler(this.LabelExport_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(655, 364);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 83);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // AthletesInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(935, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelOpenReport);
            this.Controls.Add(this.LabelExport);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.ComboGroup);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.BtnSetScore);
            this.Controls.Add(this.BtnGenerateReport);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.buttonImportAthletesInfo);
            this.Controls.Add(this.dataGridViewX1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "AthletesInfoForm";
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "木球竞赛计分系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ImportPersonInfoForm_Load);
            this.SizeChanged += new System.EventHandler(this.ImportPersonInfoForm_SizeChanged);
            this.buttonImportAthletesInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.BtnGenerateReport.ResumeLayout(false);
            this.BtnSetScore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX buttonImportAthletesInfo;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.ButtonX BtnGenerateReport;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX BtnSetScore;
        private DevComponents.DotNetBar.LabelX labelX12;
        private System.Windows.Forms.ComboBox ComboGroup;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX LabelOpenReport;
        private DevComponents.DotNetBar.LabelX LabelExport;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

