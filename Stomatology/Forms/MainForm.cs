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
            this.Hide();
            (new EditForm()).Show();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new FilterForm()).Show();
        }
    }
}
