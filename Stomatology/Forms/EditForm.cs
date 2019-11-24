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

        private void button1_Click(object sender, System.EventArgs e)
        {
            var tableName = choiceTableBox.SelectedItem.ToString();
            var className = TableAttrs.Attrs[tableName];
            editView.DataSource = GetExcelTable(className);
            PrepareDataGridView(editView);
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
            choiceTableBox.Items.AddRange(tables);
            choiceTableBox.SelectedIndex = 0;
        }

        private void PrepareDataGridView(DataGridView view)
        {
            view.AutoResizeColumns();
            view.AllowUserToAddRows = false;
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
    }
}
