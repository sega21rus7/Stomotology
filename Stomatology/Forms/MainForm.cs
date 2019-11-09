using System;
using System.Windows.Forms;
using Stomatology.Forms;

namespace Stomatology
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var form = new EditForm();
            //this.Hide();
            form.Show();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            var form = new FilterForm();
            //this.Hide();
            form.Show();
        }
    }
}
