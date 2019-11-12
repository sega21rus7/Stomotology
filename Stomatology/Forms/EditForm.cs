using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Stomatology.Forms
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            var excelApp = new Excel.Application();
            var workBook = excelApp.Workbooks.Open(Application.StartupPath + "\\Tables\\Patient.xlsx");
            var workSheet = workBook.Worksheets["Лист1"];
            
            
            workBook.Close(false); //закрываем книгу, изменения не сохраняем
            excelApp.Quit(); //закрываем Excel
        }
    }
}
