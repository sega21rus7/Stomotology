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
            this.editView.Location = new System.Drawing.Point(12, 155);
            this.editView.Name = "editView";
            this.editView.RowTemplate.Height = 28;
            this.editView.Size = new System.Drawing.Size(1257, 518);
            this.editView.TabIndex = 0;
            // 
            // ShowDataButton
            // 
            this.ShowDataButton.Location = new System.Drawing.Point(376, 31);
            this.ShowDataButton.Name = "ShowDataButton";
            this.ShowDataButton.Size = new System.Drawing.Size(164, 32);
            this.ShowDataButton.TabIndex = 1;
            this.ShowDataButton.Text = "Показать данные";
            this.ShowDataButton.UseVisualStyleBackColor = true;
            this.ShowDataButton.Click += new System.EventHandler(this.ShowDataButton_Click);
            // 
            // ChoiceTableBox
            // 
            this.ChoiceTableBox.FormattingEnabled = true;
            this.ChoiceTableBox.Location = new System.Drawing.Point(12, 31);
            this.ChoiceTableBox.Name = "ChoiceTableBox";
            this.ChoiceTableBox.Size = new System.Drawing.Size(342, 28);
            this.ChoiceTableBox.TabIndex = 2;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(1092, 28);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(160, 32);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(1092, 82);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(160, 32);
            this.ExportButton.TabIndex = 4;
            this.ExportButton.Text = "Экспорт в Excel";
            this.ExportButton.UseVisualStyleBackColor = true;
            // 
            // DelDataButton
            // 
            this.DelDataButton.Location = new System.Drawing.Point(224, 91);
            this.DelDataButton.Name = "DelDataButton";
            this.DelDataButton.Size = new System.Drawing.Size(164, 32);
            this.DelDataButton.TabIndex = 6;
            this.DelDataButton.Text = "Удалить данные";
            this.DelDataButton.UseVisualStyleBackColor = true;
            this.DelDataButton.Click += new System.EventHandler(this.DelDataButton_Click);
            // 
            // AddDataButton
            // 
            this.AddDataButton.Location = new System.Drawing.Point(12, 91);
            this.AddDataButton.Name = "AddDataButton";
            this.AddDataButton.Size = new System.Drawing.Size(164, 32);
            this.AddDataButton.TabIndex = 7;
            this.AddDataButton.Text = "Добавить данные";
            this.AddDataButton.UseVisualStyleBackColor = true;
            this.AddDataButton.Click += new System.EventHandler(this.AddDataButton_Click);
            // 
            // EditDataButton
            // 
            this.EditDataButton.Location = new System.Drawing.Point(440, 91);
            this.EditDataButton.Name = "EditDataButton";
            this.EditDataButton.Size = new System.Drawing.Size(164, 32);
            this.EditDataButton.TabIndex = 8;
            this.EditDataButton.Text = "Изменить данные";
            this.EditDataButton.UseVisualStyleBackColor = true;
            this.EditDataButton.Click += new System.EventHandler(this.EditDataButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 702);
            this.Controls.Add(this.EditDataButton);
            this.Controls.Add(this.AddDataButton);
            this.Controls.Add(this.DelDataButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ChoiceTableBox);
            this.Controls.Add(this.ShowDataButton);
            this.Controls.Add(this.editView);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод/Редактирование данных";
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