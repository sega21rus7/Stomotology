namespace Stomatology.Forms
{
    partial class FilterForm
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
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.FilterValueBox = new System.Windows.Forms.TextBox();
            this.FilterKeyBox = new System.Windows.Forms.ComboBox();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowButton
            // 
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // ChoiceTableBox
            // 
            this.ChoiceTableBox.Items.AddRange(new object[] {
            "Адреса пациентов",
            "Врачи",
            "Ассистенты врачей",
            "Должности ассистентов врачей",
            "Должности врачей",
            "Пациенты",
            "Страховые полисы пациентов",
            "Паспортные данные пациентов",
            "Услуги",
            "Типы услуг",
            "Приемы",
            "Адреса пациентов",
            "Врачи",
            "Ассистенты врачей",
            "Должности ассистентов врачей",
            "Должности врачей",
            "Пациенты",
            "Страховые полисы пациентов",
            "Паспортные данные пациентов",
            "Услуги",
            "Типы услуг",
            "Приемы"});
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(8, 51);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(229, 20);
            this.SearchBox.TabIndex = 3;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(251, 48);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(109, 24);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FilterValueBox
            // 
            this.FilterValueBox.Location = new System.Drawing.Point(586, 28);
            this.FilterValueBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FilterValueBox.Name = "FilterValueBox";
            this.FilterValueBox.Size = new System.Drawing.Size(130, 20);
            this.FilterValueBox.TabIndex = 5;
            this.FilterValueBox.TextChanged += new System.EventHandler(this.FilterBox_TextChanged);
            // 
            // FilterKeyBox
            // 
            this.FilterKeyBox.FormattingEnabled = true;
            this.FilterKeyBox.Location = new System.Drawing.Point(415, 27);
            this.FilterKeyBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FilterKeyBox.Name = "FilterKeyBox";
            this.FilterKeyBox.Size = new System.Drawing.Size(144, 21);
            this.FilterKeyBox.TabIndex = 6;
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Location = new System.Drawing.Point(521, 6);
            this.FilterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(91, 13);
            this.FilterLabel.TabIndex = 7;
            this.FilterLabel.Text = "Фильтр по полю";
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 456);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.FilterKeyBox);
            this.Controls.Add(this.FilterValueBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximizeBox = false;
            this.Name = "FilterForm";
            this.Text = "Поиск/Фильтрация данных";
            this.Load += new System.EventHandler(this.FilterForm_Load);
<<<<<<< HEAD
=======
            this.Controls.SetChildIndex(this.AddButton, 0);
            this.Controls.SetChildIndex(this.EditButton, 0);
>>>>>>> parent of beabcf4... Revert "Заготовки форм добавления и редактирования данных"
            this.Controls.SetChildIndex(this.ExportButton, 0);
            this.Controls.SetChildIndex(this.BackButton, 0);
            this.Controls.SetChildIndex(this.ShowButton, 0);
            this.Controls.SetChildIndex(this.ChoiceTableBox, 0);
            this.Controls.SetChildIndex(this.SearchBox, 0);
            this.Controls.SetChildIndex(this.SearchButton, 0);
            this.Controls.SetChildIndex(this.FilterValueBox, 0);
            this.Controls.SetChildIndex(this.FilterKeyBox, 0);
            this.Controls.SetChildIndex(this.FilterLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox FilterValueBox;
        private System.Windows.Forms.ComboBox FilterKeyBox;
        private System.Windows.Forms.Label FilterLabel;
    }
}