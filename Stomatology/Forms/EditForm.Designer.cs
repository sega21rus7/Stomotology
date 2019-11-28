namespace Stomatology.Forms
{
    partial class EditForm
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
            this.editView = new System.Windows.Forms.DataGridView();
            this.ShowButton = new System.Windows.Forms.Button();
            this.ChoiceTableBox = new System.Windows.Forms.ComboBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.DelButton = new System.Windows.Forms.Button();
=======
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
>>>>>>> parent of beabcf4... Revert "Заготовки форм добавления и редактирования данных"
            ((System.ComponentModel.ISupportInitialize)(this.editView)).BeginInit();
            this.SuspendLayout();
            // 
            // editView
            // 
            this.editView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editView.Location = new System.Drawing.Point(8, 101);
<<<<<<< HEAD
            this.editView.Margin = new System.Windows.Forms.Padding(2);
=======
            this.editView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> parent of beabcf4... Revert "Заготовки форм добавления и редактирования данных"
            this.editView.Name = "editView";
            this.editView.RowTemplate.Height = 28;
            this.editView.Size = new System.Drawing.Size(838, 337);
            this.editView.TabIndex = 0;
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(251, 20);
<<<<<<< HEAD
            this.ShowButton.Margin = new System.Windows.Forms.Padding(2);
=======
            this.ShowButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> parent of beabcf4... Revert "Заготовки форм добавления и редактирования данных"
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(109, 21);
            this.ShowButton.TabIndex = 1;
            this.ShowButton.Text = "Показать данные";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // ChoiceTableBox
            // 
            this.ChoiceTableBox.FormattingEnabled = true;
            this.ChoiceTableBox.Location = new System.Drawing.Point(8, 20);
<<<<<<< HEAD
            this.ChoiceTableBox.Margin = new System.Windows.Forms.Padding(2);
=======
            this.ChoiceTableBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> parent of beabcf4... Revert "Заготовки форм добавления и редактирования данных"
            this.ChoiceTableBox.Name = "ChoiceTableBox";
            this.ChoiceTableBox.Size = new System.Drawing.Size(229, 21);
            this.ChoiceTableBox.TabIndex = 2;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(728, 18);
<<<<<<< HEAD
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
=======
            this.BackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> parent of beabcf4... Revert "Заготовки форм добавления и редактирования данных"
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(107, 21);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(728, 53);
<<<<<<< HEAD
            this.ExportButton.Margin = new System.Windows.Forms.Padding(2);
=======
            this.ExportButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> parent of beabcf4... Revert "Заготовки форм добавления и редактирования данных"
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(107, 21);
            this.ExportButton.TabIndex = 4;
            this.ExportButton.Text = "Экспорт в Excel";
            this.ExportButton.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(394, 20);
            this.DelButton.Margin = new System.Windows.Forms.Padding(2);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(109, 21);
            this.DelButton.TabIndex = 6;
            this.DelButton.Text = "Удалить данные";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
=======
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(11, 53);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(107, 21);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Добавить данные";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(146, 53);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(143, 21);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Редактировать данные";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
>>>>>>> parent of beabcf4... Revert "Заготовки форм добавления и редактирования данных"
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 456);
<<<<<<< HEAD
            this.Controls.Add(this.DelButton);
=======
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
>>>>>>> parent of beabcf4... Revert "Заготовки форм добавления и редактирования данных"
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ChoiceTableBox);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.editView);
            this.Cursor = System.Windows.Forms.Cursors.Default;
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(2);
=======
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> parent of beabcf4... Revert "Заготовки форм добавления и редактирования данных"
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод/Редактирование данных";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.DataGridView editView;
        protected System.Windows.Forms.Button ShowButton;
        protected System.Windows.Forms.ComboBox ChoiceTableBox;
        protected System.Windows.Forms.Button BackButton;
        protected System.Windows.Forms.Button ExportButton;
<<<<<<< HEAD
        protected System.Windows.Forms.Button DelButton;
=======
        protected System.Windows.Forms.Button AddButton;
        protected System.Windows.Forms.Button EditButton;
>>>>>>> parent of beabcf4... Revert "Заготовки форм добавления и редактирования данных"
    }
}