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
            this.ShowDataButton = new System.Windows.Forms.Button();
            this.ChoiceTableBox = new System.Windows.Forms.ComboBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.DelDataButton = new System.Windows.Forms.Button();
            this.AddDataButton = new System.Windows.Forms.Button();
            this.EditDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.editView)).BeginInit();
            this.SuspendLayout();
            // 
            // editView
            // 
            this.editView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editView.Location = new System.Drawing.Point(8, 101);
            this.editView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editView.Name = "editView";
            this.editView.RowTemplate.Height = 28;
            this.editView.Size = new System.Drawing.Size(838, 337);
            this.editView.TabIndex = 0;
            this.editView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.editView_DataError);
            // 
            // ShowDataButton
            // 
            this.ShowDataButton.Location = new System.Drawing.Point(251, 20);
            this.ShowDataButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowDataButton.Name = "ShowDataButton";
            this.ShowDataButton.Size = new System.Drawing.Size(118, 21);
            this.ShowDataButton.TabIndex = 1;
            this.ShowDataButton.Text = "Показать таблицу";
            this.ShowDataButton.UseVisualStyleBackColor = true;
            this.ShowDataButton.Click += new System.EventHandler(this.ShowDataButton_Click);
            // 
            // ChoiceTableBox
            // 
            this.ChoiceTableBox.FormattingEnabled = true;
            this.ChoiceTableBox.Location = new System.Drawing.Point(8, 20);
            this.ChoiceTableBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChoiceTableBox.Name = "ChoiceTableBox";
            this.ChoiceTableBox.Size = new System.Drawing.Size(229, 21);
            this.ChoiceTableBox.TabIndex = 2;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(728, 18);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.ExportButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(107, 21);
            this.ExportButton.TabIndex = 4;
            this.ExportButton.Text = "Экспорт";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // DelDataButton
            // 
            this.DelDataButton.Location = new System.Drawing.Point(149, 59);
            this.DelDataButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DelDataButton.Name = "DelDataButton";
            this.DelDataButton.Size = new System.Drawing.Size(109, 21);
            this.DelDataButton.TabIndex = 6;
            this.DelDataButton.Text = "Удалить данные";
            this.DelDataButton.UseVisualStyleBackColor = true;
            this.DelDataButton.Click += new System.EventHandler(this.DelDataButton_Click);
            // 
            // AddDataButton
            // 
            this.AddDataButton.Location = new System.Drawing.Point(8, 59);
            this.AddDataButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddDataButton.Name = "AddDataButton";
            this.AddDataButton.Size = new System.Drawing.Size(109, 21);
            this.AddDataButton.TabIndex = 7;
            this.AddDataButton.Text = "Добавить данные";
            this.AddDataButton.UseVisualStyleBackColor = true;
            this.AddDataButton.Click += new System.EventHandler(this.AddDataButton_Click);
            // 
            // EditDataButton
            // 
            this.EditDataButton.Location = new System.Drawing.Point(293, 59);
            this.EditDataButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditDataButton.Name = "EditDataButton";
            this.EditDataButton.Size = new System.Drawing.Size(147, 21);
            this.EditDataButton.TabIndex = 8;
            this.EditDataButton.Text = "Редактировать данные";
            this.EditDataButton.UseVisualStyleBackColor = true;
            this.EditDataButton.Click += new System.EventHandler(this.EditDataButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 456);
            this.Controls.Add(this.EditDataButton);
            this.Controls.Add(this.AddDataButton);
            this.Controls.Add(this.DelDataButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ChoiceTableBox);
            this.Controls.Add(this.ShowDataButton);
            this.Controls.Add(this.editView);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление/Редактирование данных";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.DataGridView editView;
        protected System.Windows.Forms.Button ShowDataButton;
        protected System.Windows.Forms.ComboBox ChoiceTableBox;
        protected System.Windows.Forms.Button BackButton;
        protected System.Windows.Forms.Button ExportButton;
        protected System.Windows.Forms.Button DelDataButton;
        protected System.Windows.Forms.Button AddDataButton;
        protected System.Windows.Forms.Button EditDataButton;
    }
}