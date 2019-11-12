using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;

namespace Stomatology.Forms
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var excelApp = new Excel.Application();
            var workBook = excelApp.Workbooks.Open(Application.StartupPath + "\\Tables\\Patient.xlsx");
            var workSheet = workBook.Worksheets.get_Item(1); // первый лист
            var sheetRange = workSheet.UsedRange;// получаем все ячейки
            var rowsCount = sheetRange.Rows.Count;
            var columnsCount = sheetRange.Columns.Count;
            workBook.Close(false); //закрываем книгу, изменения не сохраняем
            excelApp.Quit(); //закрываем Excel

            //editView.DataSource = sheetRange;
        }
    }
}
