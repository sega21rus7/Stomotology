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
        }

        private void ShowDataButton_Click(object sender, System.EventArgs e)
        {
            var tableName = ChoiceTableBox.SelectedItem.ToString();
            var className = TableAttrs.Attrs[tableName];
            editView.DataSource = GetExcelTable(className);
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

        private DataTable GetExcelTable(string fileName)
        {
            var path = @"..\..\..\Tables\" + fileName + ".xls";
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
            int index = editView.SelectedCells[0].RowIndex;
            editView.Rows.RemoveAt(index);
        }

        private void AddDataButton_Click(object sender, System.EventArgs e)
        {
            (new AddDataForm()).Show();
        }

        private void EditDataButton_Click(object sender, System.EventArgs e)
        {

        }
    }
}
