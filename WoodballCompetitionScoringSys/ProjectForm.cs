using System;
using System.Data;
using System.Windows.Forms;
using WoodballCompetitionScoringSys.DAL;
using WoodballCompetitionScoringSys.Model;

namespace WoodballCompetitionScoringSys
{
    public partial class ProjectForm : Form
    {
        private IndexForm indexForm = null;
        private ProjectModel selectedProject = null;
        public ProjectForm(IndexForm form, ProjectModel selectedPeoject = null)
        {
            InitializeComponent();
            indexForm = form;
            if (selectedPeoject != null) 
            {
                this.selectedProject = selectedPeoject;
            }
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            if (selectedProject != null)
            {
                this.TBName.Text = selectedProject.Name;
                this.TBOrganzier.Text = selectedProject.Organzier;
                this.TBDate.Text = selectedProject.Date;
                this.TBPlace.Text = selectedProject.Place;
                this.ComboProjectType.SelectedItem = selectedProject.ProjectType;
            }

            this.ComboProjectType.SelectedIndex = 0;

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (selectedProject != null)
            {
                var projectModel = new ProjectModel();
                projectModel.Id = selectedProject.Id;
                projectModel.Name = this.TBName.Text;
                projectModel.Organzier = this.TBOrganzier.Text;
                projectModel.Date = this.TBDate.Text;
                projectModel.Place = this.TBPlace.Text;
                projectModel.ProjectType = this.ComboProjectType.SelectedItem.ToString();

                // Update DB info
                ProjectDAL.UpdateById(projectModel);
            }
            else
            {
                var projectModel = new ProjectModel();
                projectModel.Id = System.Guid.NewGuid().ToString();
                projectModel.Name = this.TBName.Text;
                projectModel.Organzier = this.TBOrganzier.Text;
                projectModel.Date = this.TBDate.Text;
                projectModel.Place = this.TBPlace.Text;
                projectModel.ProjectType = this.ComboProjectType.SelectedItem.ToString();

                // Save to DB
                ProjectDAL.Save(projectModel);
            }

            // Refresh DataGraid
            indexForm.RefreshProject();

            this.Close();
        }
    }
}