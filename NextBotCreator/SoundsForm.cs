using System;
using System.Windows.Forms;

namespace NextBotCreator
{
    public partial class SoundsForm : Form
    {
        private Project project;
        private int soundIndex = 0;

        private string sound;

        private string[] sounds;

        public SoundsForm(Project project)
        {
            this.project = project;
            sounds = project.GetPathsToSound();

            InitializeComponent();

            LoadSound(0);

        }

        private void LoadSound(int index)
        {
            this.soundIndex = index;

            if (soundIndex == sounds.Length - 1) continueButton.Text = "Завершить";
            if (sounds.Length <= soundIndex)
            {
                End();
                return;
            }
            sound = sounds[soundIndex];

            System.IO.File.Delete(sound);

            var parts = sound.Split('\\');

            sound = parts[parts.Length - 1];


            soundLabel.Text = "Выберите звук " + sound;
        }


        private void Continue(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(soundField.Text)) project.SaveSound(soundField.Text, sound);
            LoadSound(soundIndex + 1);
        }

        private void SelectFile(object sender, EventArgs e)
        {
            if (selectSoundDialog.ShowDialog() != DialogResult.OK) return;
            soundField.Text = selectSoundDialog.FileName;
        }

        private void End()
        {
            var endForm = new EndForm(project);
            endForm.Show();

            Program.Context.MainForm = endForm;
            this.Hide();
        }
    }
}
