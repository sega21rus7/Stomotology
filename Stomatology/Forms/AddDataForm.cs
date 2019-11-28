using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stomatology.Forms
{
    public partial class AddDataForm : Form
    {
        public AddDataForm()
        {
            InitializeComponent();
        }

        private void AddDataForm_Load(object sender, EventArgs e)
        {
            var box = new TextBox();
            box.Location = new Point(25, 25);
            Controls.Add(box);


            var v = new TextBox();
            v.Location = new Point(25, 55);
            Controls.Add(v);
        }
    }
}
