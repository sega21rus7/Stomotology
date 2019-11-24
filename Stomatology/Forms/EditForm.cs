using System.Windows.Forms;
using System.Data.OleDb;
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
            var path = @"..\..\..\Tables\Doctor.xls";
            var connPath = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path +
                ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            var conn = new OleDbConnection(connPath);
            var adapter = new OleDbDataAdapter("select * from [Лист1$]", conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            editView.DataSource = dt;
        }
    }
}
