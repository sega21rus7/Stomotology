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
            this.MaximizeBox = false;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var form = new EditForm();
            form.Show();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            var form = new FilterForm();
            form.Show();
        }
    }
}
