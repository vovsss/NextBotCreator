
namespace NextBotCreator
{
    partial class SoundsForm
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
            this.soundField = new System.Windows.Forms.TextBox();
            this.soundLabel = new System.Windows.Forms.Label();
            this.soundSelect = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.selectSoundDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // soundField
            // 
            this.soundField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.soundField.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.soundField.Location = new System.Drawing.Point(210, 178);
            this.soundField.Name = "soundField";
            this.soundField.Size = new System.Drawing.Size(343, 32);
            this.soundField.TabIndex = 3;
            this.soundField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // soundLabel
            // 
            this.soundLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.soundLabel.AutoSize = true;
            this.soundLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.soundLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.soundLabel.Location = new System.Drawing.Point(-8, 43);
            this.soundLabel.MaximumSize = new System.Drawing.Size(816, 50);
            this.soundLabel.MinimumSize = new System.Drawing.Size(816, 45);
            this.soundLabel.Name = "soundLabel";
            this.soundLabel.Size = new System.Drawing.Size(816, 45);
            this.soundLabel.TabIndex = 2;
            this.soundLabel.Text = "Выберите звук";
            this.soundLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // soundSelect
            // 
            this.soundSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.soundSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundSelect.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F);
            this.soundSelect.Location = new System.Drawing.Point(558, 178);
            this.soundSelect.Name = "soundSelect";
            this.soundSelect.Size = new System.Drawing.Size(32, 32);
            this.soundSelect.TabIndex = 4;
            this.soundSelect.Text = "";
            this.soundSelect.UseVisualStyleBackColor = true;
            this.soundSelect.Click += new System.EventHandler(this.SelectFile);
            // 
            // continueButton
            // 
            this.continueButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.continueButton.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.continueButton.Location = new System.Drawing.Point(268, 259);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(285, 53);
            this.continueButton.TabIndex = 9;
            this.continueButton.Text = "Дальше";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.Continue);
            // 
            // selectSoundDialog
            // 
            this.selectSoundDialog.FileName = "sound";
            this.selectSoundDialog.Filter = "MP3 File|*.mp3";
            // 
            // SoundsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.soundSelect);
            this.Controls.Add(this.soundField);
            this.Controls.Add(this.soundLabel);
            this.Name = "SoundsForm";
            this.Text = "NextBotCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox soundField;
        private System.Windows.Forms.Label soundLabel;
        private System.Windows.Forms.Button soundSelect;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.OpenFileDialog selectSoundDialog;
    }
}