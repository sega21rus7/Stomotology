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
            this.SearchBox.Location = new System.Drawing.Point(12, 79);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(342, 26);
            this.SearchBox.TabIndex = 3;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(377, 68);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(164, 37);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FilterValueBox
            // 
            this.FilterValueBox.Location = new System.Drawing.Point(943, 43);
            this.FilterValueBox.Name = "FilterValueBox";
            this.FilterValueBox.Size = new System.Drawing.Size(193, 26);
            this.FilterValueBox.TabIndex = 5;
            this.FilterValueBox.TextChanged += new System.EventHandler(this.FilterBox_TextChanged);
            // 
            // FilterKeyBox
            // 
            this.FilterKeyBox.FormattingEnabled = true;
            this.FilterKeyBox.Location = new System.Drawing.Point(686, 41);
            this.FilterKeyBox.Name = "FilterKeyBox";
            this.FilterKeyBox.Size = new System.Drawing.Size(214, 28);
            this.FilterKeyBox.TabIndex = 6;
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Location = new System.Drawing.Point(846, 9);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(136, 20);
            this.FilterLabel.TabIndex = 7;
            this.FilterLabel.Text = "Фильтр по полю";
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 702);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.FilterKeyBox);
            this.Controls.Add(this.FilterValueBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.MaximizeBox = false;
            this.Name = "FilterForm";
            this.Text = "Поиск/Фильтрация данных";
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