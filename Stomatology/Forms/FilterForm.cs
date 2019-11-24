using System.Windows.Forms;
using System;

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
                            searchBox.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {
                            searchedRowNum++;
                            if (searchedRowNum == 1)
                                editView.CurrentCell = editView.Rows[i].Cells[j];//перейти к 1-ой ячейке.
                            editView.Rows[i].Selected = true;
                            break;
                        }
                
            }
        }
    }
}
