using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NextBotCreator
{
    public partial class EndForm : Form
    {

        private Project project;
        private string gModPath;

        public EndForm(Project project)
        {

            this.project = project;
            this.gModPath = GetGMODPath();




            InitializeComponent();
            UpdateControls();
        }

        public string GetGMODPath()
        {
            return File.ReadAllText("modules/gmod_path.txt");
        }


        private void UpdateControls()
        {
            gModPathField.Text = gModPath;
        }

        private void PublishButtonClick(object sender, EventArgs e)
        {
            project.Publish();

            gModPathField.Size = new Size(527, 32);
            gModPathSelect.Hide();
            publishButton.Hide();

            label.Text = "Вы можете скопировать ссылку на NextBot`а ниже";
            gModPathField.Text = project.SteamID;

        }

        private void GMODPathSelectButtonClick(object sender, EventArgs e)
        {
            if (gModFolderDialog.ShowDialog() != DialogResult.OK) return;
            gModPath = gModFolderDialog.SelectedPath;
            File.WriteAllText("modules/gmod_path.txt", gModPath);
            UpdateControls();
        }
    }
}
