
namespace NextBotCreator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.selectIconDialog = new System.Windows.Forms.OpenFileDialog();
            this.projectNameField = new System.Windows.Forms.TextBox();
            this.iconSelect = new System.Windows.Forms.Button();
            this.iconField = new System.Windows.Forms.TextBox();
            this.iconLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureTextBox = new System.Windows.Forms.TextBox();
            this.pictureSelect = new System.Windows.Forms.Button();
            this.selectPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.continueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.projectNameLabel.Location = new System.Drawing.Point(243, 23);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(332, 45);
            this.projectNameLabel.TabIndex = 0;
            this.projectNameLabel.Text = "Введите имя проекта";
            this.projectNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectIconDialog
            // 
            this.selectIconDialog.FileName = "icon";
            this.selectIconDialog.Filter = "Image Files|*.png; *.jpg; *.jpeg; *.bmp";
            // 
            // projectNameField
            // 
            this.projectNameField.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.projectNameField.Location = new System.Drawing.Point(229, 71);
            this.projectNameField.Name = "projectNameField";
            this.projectNameField.Size = new System.Drawing.Size(343, 32);
            this.projectNameField.TabIndex = 1;
            this.projectNameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iconSelect
            // 
            this.iconSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSelect.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F);
            this.iconSelect.Location = new System.Drawing.Point(543, 157);
            this.iconSelect.Name = "iconSelect";
            this.iconSelect.Size = new System.Drawing.Size(32, 32);
            this.iconSelect.TabIndex = 2;
            this.iconSelect.Text = "";
            this.iconSelect.UseVisualStyleBackColor = true;
            this.iconSelect.Click += new System.EventHandler(this.IconSelectClick);
            // 
            // iconField
            // 
            this.iconField.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iconField.Location = new System.Drawing.Point(224, 157);
            this.iconField.Name = "iconField";
            this.iconField.Size = new System.Drawing.Size(314, 32);
            this.iconField.TabIndex = 3;
            this.iconField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iconLabel
            // 
            this.iconLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconLabel.AutoSize = true;
            this.iconLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.iconLabel.Location = new System.Drawing.Point(212, 108);
            this.iconLabel.Name = "iconLabel";
            this.iconLabel.Size = new System.Drawing.Size(404, 45);
            this.iconLabel.TabIndex = 4;
            this.iconLabel.Text = "Выберите иконку проекта";
            this.iconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.label1.Location = new System.Drawing.Point(190, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите картинку NextBot`а";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureTextBox
            // 
            this.pictureTextBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.pictureTextBox.Location = new System.Drawing.Point(226, 252);
            this.pictureTextBox.Name = "pictureTextBox";
            this.pictureTextBox.Size = new System.Drawing.Size(314, 32);
            this.pictureTextBox.TabIndex = 6;
            this.pictureTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureSelect
            // 
            this.pictureSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pictureSelect.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F);
            this.pictureSelect.Location = new System.Drawing.Point(545, 252);
            this.pictureSelect.Name = "pictureSelect";
            this.pictureSelect.Size = new System.Drawing.Size(32, 32);
            this.pictureSelect.TabIndex = 5;
            this.pictureSelect.Text = "";
            this.pictureSelect.UseVisualStyleBackColor = true;
            this.pictureSelect.Click += new System.EventHandler(this.PictureSelectClick);
            // 
            // selectPictureDialog
            // 
            this.selectPictureDialog.FileName = "icon";
            this.selectPictureDialog.Filter = "Image Files|*.png; *.jpg; *.jpeg; *.bmp";
            // 
            // continueButton
            // 
            this.continueButton.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.continueButton.Location = new System.Drawing.Point(258, 314);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(285, 53);
            this.continueButton.TabIndex = 8;
            this.continueButton.Text = "Перейти к выбору звуков";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.Continue);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureTextBox);
            this.Controls.Add(this.pictureSelect);
            this.Controls.Add(this.iconLabel);
            this.Controls.Add(this.iconField);
            this.Controls.Add(this.iconSelect);
            this.Controls.Add(this.projectNameField);
            this.Controls.Add(this.projectNameLabel);
            this.Name = "MainForm";
            this.Text = "NextBotCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.OpenFileDialog selectIconDialog;
        private System.Windows.Forms.TextBox projectNameField;
        private System.Windows.Forms.Button iconSelect;
        private System.Windows.Forms.TextBox iconField;
        private System.Windows.Forms.Label iconLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pictureTextBox;
        private System.Windows.Forms.Button pictureSelect;
        private System.Windows.Forms.OpenFileDialog selectPictureDialog;
        private System.Windows.Forms.Button continueButton;
    }
}

