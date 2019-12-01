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
            var choice = ChoiceTableBox.SelectedItem.ToString();
            var tableName = TableAttrs.Attrs[choice];
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
                MessageBox.Show("Ни одна из таблиц не открыта!");
            }
        }

        private void AddDataButton_Click(object sender, System.EventArgs e)
        {
            (new AddDataForm()).Show();
        }

        private void EditDataButton_Click(object sender, System.EventArgs e)
        {
            (new EditDataForm()).Show();
        }
    }
}
