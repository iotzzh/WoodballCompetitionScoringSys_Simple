namespace WoodballCompetitionScoringSys
{
    partial class SetScore
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
            this.buttonCancle = new DevComponents.DotNetBar.ButtonX();
            this.buttonOK = new DevComponents.DotNetBar.ButtonX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.InputScore = new DevComponents.Editors.DoubleInput();
            ((System.ComponentModel.ISupportInitialize)(this.InputScore)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancle
            // 
            this.buttonCancle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCancle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonCancle.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCancle.Location = new System.Drawing.Point(12, 105);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.Size = new System.Drawing.Size(115, 38);
            this.buttonCancle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonCancle.TabIndex = 15;
            this.buttonCancle.Text = "取消";
            this.buttonCancle.Click += new System.EventHandler(this.buttonCancle_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOK.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOK.Location = new System.Drawing.Point(207, 105);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(115, 38);
            this.buttonOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonOK.TabIndex = 14;
            this.buttonOK.Text = "确认";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX7.Location = new System.Drawing.Point(12, 30);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(145, 34);
            this.labelX7.TabIndex = 16;
            this.labelX7.Text = "请输入分数";
            // 
            // InputScore
            // 
            // 
            // 
            // 
            this.InputScore.BackgroundStyle.Class = "DateTimeInputBackground";
            this.InputScore.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.InputScore.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.InputScore.DisplayFormat = "0.0";
            this.InputScore.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InputScore.Increment = 1D;
            this.InputScore.Location = new System.Drawing.Point(163, 30);
            this.InputScore.Name = "InputScore";
            this.InputScore.ShowUpDown = true;
            this.InputScore.Size = new System.Drawing.Size(159, 34);
            this.InputScore.TabIndex = 18;
            // 
            // SetScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 177);
            this.Controls.Add(this.InputScore);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.buttonCancle);
            this.Controls.Add(this.buttonOK);
            this.Name = "SetScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置分数";
            this.Load += new System.EventHandler(this.SetScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InputScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX buttonCancle;
        private DevComponents.DotNetBar.ButtonX buttonOK;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.Editors.DoubleInput InputScore;
    }
}