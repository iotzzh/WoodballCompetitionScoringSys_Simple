namespace WoodballCompetitionScoringSys
{
    partial class ProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnConfirm = new DevComponents.DotNetBar.ButtonX();
            this.BtnCancel = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.TBName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TBDate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.TBPlace = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TBOrganzier = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.ComboProjectType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnConfirm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnConfirm.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnConfirm.Location = new System.Drawing.Point(239, 326);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(152, 57);
            this.BtnConfirm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnConfirm.TabIndex = 0;
            this.BtnConfirm.Text = "确认";
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(27, 326);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(166, 57);
            this.BtnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(203, 38);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "名称(Name)";
            // 
            // TBName
            // 
            // 
            // 
            // 
            this.TBName.Border.Class = "TextBoxBorder";
            this.TBName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TBName.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TBName.Location = new System.Drawing.Point(221, 12);
            this.TBName.Name = "TBName";
            this.TBName.PreventEnterBeep = true;
            this.TBName.Size = new System.Drawing.Size(178, 34);
            this.TBName.TabIndex = 3;
            // 
            // TBDate
            // 
            // 
            // 
            // 
            this.TBDate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TBDate.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TBDate.Location = new System.Drawing.Point(221, 188);
            this.TBDate.Name = "TBDate";
            this.TBDate.PreventEnterBeep = true;
            this.TBDate.Size = new System.Drawing.Size(178, 34);
            this.TBDate.TabIndex = 7;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.Location = new System.Drawing.Point(12, 188);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(203, 38);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "时间(Date)";
            // 
            // TBPlace
            // 
            // 
            // 
            // 
            this.TBPlace.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TBPlace.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TBPlace.Location = new System.Drawing.Point(221, 255);
            this.TBPlace.Name = "TBPlace";
            this.TBPlace.PreventEnterBeep = true;
            this.TBPlace.Size = new System.Drawing.Size(178, 34);
            this.TBPlace.TabIndex = 9;
            // 
            // TBOrganzier
            // 
            // 
            // 
            // 
            this.TBOrganzier.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TBOrganzier.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TBOrganzier.Location = new System.Drawing.Point(221, 119);
            this.TBOrganzier.Name = "TBOrganzier";
            this.TBOrganzier.PreventEnterBeep = true;
            this.TBOrganzier.Size = new System.Drawing.Size(178, 34);
            this.TBOrganzier.TabIndex = 11;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(12, 119);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(203, 38);
            this.labelX2.TabIndex = 10;
            this.labelX2.Text = "承办(Organzier)";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX4.Location = new System.Drawing.Point(12, 255);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(203, 38);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "地点(Place)";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.Location = new System.Drawing.Point(12, 66);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(203, 38);
            this.labelX5.TabIndex = 12;
            this.labelX5.Text = "项目类别(Type)";
            // 
            // ComboProjectType
            // 
            this.ComboProjectType.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboProjectType.FormattingEnabled = true;
            this.ComboProjectType.Items.AddRange(new object[] {
            "男子团体赛",
            "女子团体赛",
            "男子个人赛",
            "女子个人赛",
            "男子双打赛",
            "女子双打赛",
            "混合双打赛"});
            this.ComboProjectType.Location = new System.Drawing.Point(221, 66);
            this.ComboProjectType.Name = "ComboProjectType";
            this.ComboProjectType.Size = new System.Drawing.Size(178, 33);
            this.ComboProjectType.TabIndex = 13;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 435);
            this.Controls.Add(this.ComboProjectType);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.TBOrganzier);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.TBPlace);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.TBDate);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.Name = "ProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "项目信息(Project Info)";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX BtnConfirm;
        private DevComponents.DotNetBar.ButtonX BtnCancel;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX TBName;
        private DevComponents.DotNetBar.Controls.TextBoxX TBDate;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX TBPlace;
        private DevComponents.DotNetBar.Controls.TextBoxX TBOrganzier;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.ComboBox ComboProjectType;
    }
}