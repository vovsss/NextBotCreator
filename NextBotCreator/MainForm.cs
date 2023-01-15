using System;
using System.Collections.Generic;
using System.Windows.Forms;




namespace NextBotCreator
{

    public partial class MainForm : Form
    {



        public MainForm()
        {
            Logger.StartLog();
            InitializeComponent();
        }

        private void IconSelectClick(object sender, EventArgs e)
        {
            if (selectIconDialog.ShowDialog() == DialogResult.Cancel) return;
            iconField.Text = selectIconDialog.FileName;

        }

        private void PictureSelectClick(object sender, EventArgs e)
        {
            if (selectPictureDialog.ShowDialog() == DialogResult.Cancel) return;
            pictureTextBox.Text = selectPictureDialog.FileName;
        }

        private void Continue(object sender, EventArgs e)
        {
            if (!CheckFields())
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }

            Project p = new Project(projectNameField.Text, iconField.Text, pictureTextBox.Text);
            Form f = new SoundsForm(p);
            Program.Context.MainForm = f;
            f.Show();
            this.Close();
        }

        private bool CheckFields()
        {
            foreach (TextBox t in this.GetControls<TextBox>())
            {
                if (String.IsNullOrEmpty(t.Text)) return false;
            }

            return true;

        }

    }
    public static class FormExtensions
    {
        public static List<Control> GetControls<T>(this Form form) where T : Control
        {
            List<Control> controls = new List<Control>();
            foreach (Control c in form.Controls)
            {
                if (c is T) controls.Add(c);
            }
            return controls;
        }
    }
}
