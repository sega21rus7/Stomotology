using System.Windows.Forms;
using System;
using System.Data;

namespace Stomatology.Forms
{
    public partial class FilterForm : EditForm
    {
        public FilterForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            var searchedRowNum = 0;
            for (int i = 0; i < editView.RowCount; i++)
            {
                editView.Rows[i].Selected = false;
                for (int j = 0; j < editView.ColumnCount; j++)
                    if (editView.Rows[i].Cells[j].Value != null)
                        if (editView.Rows[i].Cells[j].Value.ToString().IndexOf(
                            SearchBox.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {
                            searchedRowNum++;
                            if (searchedRowNum == 1)
                                editView.CurrentCell = editView.Rows[i].Cells[j];//перейти к 1-ой ячейке.
                            editView.Rows[i].Selected = true;
                            break;
                        }
                
            }
        }

        private void FilterBox_TextChanged(object sender, EventArgs e)
        {
            (editView.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("Convert({0},'System.String') like '%{1}%'", 
                FilterKeyBox.Text, FilterValueBox.Text);
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            var headers = new string[editView.ColumnCount];
            for (var i = 0; i < headers.Length; i++)
                headers[i] = editView.Columns[i].HeaderText;
            FillComboBox(FilterKeyBox, headers);
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            AddButton.Hide();
            EditButton.Hide();
        }
    }
}
