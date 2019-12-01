using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Stomatology.Forms
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void ShowDataButton_Click(object sender, System.EventArgs e)
        {
            var tableName = GetTableName();
            editView.DataSource = GetExcelTable(tableName);
            PrepareDataGridView();
        }

        private void EditForm_Load(object sender, System.EventArgs e)
        {
            this.MaximizeBox = false;
            var tables = new string[]{
                Address.TableName,
                Doctor.TableName,
                DoctorAssistent.TableName,
                DoctorAssistentPost.TableName,
                DoctorPost.TableName,
                Patient.TableName,
                PatientInsurancePolicy.TableName,
                PatientPassport.TableName,
                Service.TableName,
                ServiceType.TableName,
                Visit.TableName,
            };
            FillComboBox(ChoiceTableBox, tables);
        }

        protected static void FillComboBox(ComboBox box, string[] items)
        {
            box.Items.Clear();
            box.Items.AddRange(items);
            box.SelectedIndex = 0;
        }

        private void PrepareDataGridView()
        {
            editView.AutoResizeColumns();
            editView.AllowUserToAddRows = false;
        }

        private string GetTableName()
        {
            var choice = ChoiceTableBox.SelectedItem.ToString();
            return TableAttrs.Attrs[choice];
        }

        private DataTable GetExcelTable(string tableName)
        {
            var path = @"..\..\..\Tables\" + tableName + ".xls";
            var connPath = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path +
                ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            var conn = new OleDbConnection(connPath);
            var adapter = new OleDbDataAdapter("select * from [Лист1$]", conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        private void BackButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            (new MainForm()).Show();
        }

        private void DelDataButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                int index = editView.SelectedCells[0].RowIndex;
                editView.Rows.RemoveAt(index);
            }
            catch
            {
                MessageBox.Show("Ни одна из строк для удаления не выделена!");
            }
        }

        private void AddDataButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                var dt = (DataTable)editView.DataSource;
                DataRow drToAdd = dt.NewRow();
                dt.Rows.Add(drToAdd);
                dt.AcceptChanges();
                editView.DataSource = dt;
                editView.CurrentCell = editView.Rows[editView.RowCount - 1].Cells[0];
            }
            catch
            {
                MessageBox.Show("Ни одна из таблиц не открыта!");
            }
        }

        private void EditDataButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Отредактируйте строку в таблице и воспользуйтесь экспортом!");
        }

        private void ExportButton_Click(object sender, System.EventArgs e)
        {
            if (editView.DataSource == null)
            {
                MessageBox.Show("Ни одна из таблиц не открыта!");
                return;
            }
            string path = "";
            var res = MessageBox.Show("Экспортировать в тот же файл?(Выберите Да)\nВ новый файл?(Выберите Нет)", "Экспорт", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
                path = Directory.GetCurrentDirectory() + @"..\..\..\..\Tables\" + GetTableName() + ".xls";
            ExportTable(path);
        }

        private void ExportTable(string path = "")
        {
            Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int j = 0; j < editView.ColumnCount; j++)
                ExcelApp.Cells[1, j + 1] = editView.Columns[j].HeaderText;

            for (int i = 1; i < editView.Rows.Count; i++)
                for (int j = 0; j < editView.ColumnCount; j++)
                    ExcelApp.Cells[i + 1, j + 1] = editView.Rows[i].Cells[j].Value;

            ExcelWorkSheet.Columns.EntireColumn.AutoFit();

            if (path == "")
            {
                //Вызываем нашу созданную эксельку.
                ExcelApp.Visible = true;
                ExcelApp.UserControl = true;
            }
            else
            {
                ExcelApp.AlertBeforeOverwriting = false;
                ExcelWorkBook.SaveAs(path);
                ExcelApp.Quit();
            }
        }
    }
}
