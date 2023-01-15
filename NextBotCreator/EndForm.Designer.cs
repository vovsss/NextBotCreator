
namespace NextBotCreator
{
    partial class EndForm
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
            this.label = new System.Windows.Forms.Label();
            this.gModPathField = new System.Windows.Forms.TextBox();
            this.gModPathSelect = new System.Windows.Forms.Button();
            this.publishButton = new System.Windows.Forms.Button();
            this.gModFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(-20, 18);
            this.label.MaximumSize = new System.Drawing.Size(840, 0);
            this.label.MinimumSize = new System.Drawing.Size(840, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(840, 45);
            this.label.TabIndex = 7;
            this.label.Text = "Выберите путь к папке с Garry`s Mod";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gModPathField
            // 
            this.gModPathField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gModPathField.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gModPathField.Location = new System.Drawing.Point(137, 131);
            this.gModPathField.MinimumSize = new System.Drawing.Size(366, 32);
            this.gModPathField.Multiline = true;
            this.gModPathField.Name = "gModPathField";
            this.gModPathField.Size = new System.Drawing.Size(489, 32);
            this.gModPathField.TabIndex = 6;
            this.gModPathField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gModPathSelect
            // 
            this.gModPathSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gModPathSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gModPathSelect.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gModPathSelect.Location = new System.Drawing.Point(632, 131);
            this.gModPathSelect.Name = "gModPathSelect";
            this.gModPathSelect.Size = new System.Drawing.Size(32, 32);
            this.gModPathSelect.TabIndex = 5;
            this.gModPathSelect.Text = "";
            this.gModPathSelect.UseVisualStyleBackColor = true;
            this.gModPathSelect.Click += new System.EventHandler(this.GMODPathSelectButtonClick);
            // 
            // publishButton
            // 
            this.publishButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.publishButton.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.publishButton.Location = new System.Drawing.Point(137, 233);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(527, 164);
            this.publishButton.TabIndex = 8;
            this.publishButton.Text = "Публикация в Steam";
            this.publishButton.UseVisualStyleBackColor = true;
            this.publishButton.Click += new System.EventHandler(this.PublishButtonClick);
            // 
            // gModFolderDialog
            // 
            this.gModFolderDialog.Description = "Выбор папки GMOD";
            // 
            // EndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.publishButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.gModPathField);
            this.Controls.Add(this.gModPathSelect);
            this.Name = "EndForm";
            this.Text = "NextBotCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox gModPathField;
        private System.Windows.Forms.Button gModPathSelect;
        private System.Windows.Forms.Button publishButton;
        private System.Windows.Forms.FolderBrowserDialog gModFolderDialog;
    }
}