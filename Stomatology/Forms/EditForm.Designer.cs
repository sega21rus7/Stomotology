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
            this.showButton = new System.Windows.Forms.Button();
            this.choiceTableBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.editView)).BeginInit();
            this.SuspendLayout();
            // 
            // editView
            // 
            this.editView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editView.Location = new System.Drawing.Point(12, 155);
            this.editView.Name = "editView";
            this.editView.RowTemplate.Height = 28;
            this.editView.Size = new System.Drawing.Size(1257, 519);
            this.editView.TabIndex = 0;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(377, 31);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(164, 33);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Показать данные";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // choiceTableBox
            // 
            this.choiceTableBox.FormattingEnabled = true;
            this.choiceTableBox.Location = new System.Drawing.Point(12, 31);
            this.choiceTableBox.Name = "choiceTableBox";
            this.choiceTableBox.Size = new System.Drawing.Size(342, 28);
            this.choiceTableBox.TabIndex = 2;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 702);
            this.Controls.Add(this.choiceTableBox);
            this.Controls.Add(this.showButton);
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
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ComboBox choiceTableBox;
    }
}