using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WoodballCompetitionScoringSys.DAL;

namespace WoodballCompetitionScoringSys
{
    public partial class SetScore : Form
    {
        private DataGridViewRow selectedRow = null;
        private string AthleteId = string.Empty;
        private string AthleteName = string.Empty;
        public SetScore(DataGridViewRow selectedRow)
        {
            InitializeComponent();
            this.AthleteId = selectedRow.Cells[0].Value.ToString();
            this.AthleteName = selectedRow.Cells[1].Value.ToString();
            this.selectedRow = selectedRow;
        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetScore_Load(object sender, EventArgs e)
        {
            this.Text = $"分数-{this.AthleteName}";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var score = string.IsNullOrWhiteSpace(this.InputScore.Text) ? 0 : Convert.ToDecimal(this.InputScore.Text);
            AthletesDAL.UpdateAthleteScore(this.AthleteId, score);
            this.selectedRow.Cells["分数(Score)"].Value = score;
            this.Close();
        }
    }
}
