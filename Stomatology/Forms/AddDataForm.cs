using System.Drawing;
using System.Windows.Forms;

namespace Stomatology.Forms
{
    public partial class AddDataForm : Form
    {
        public AddDataForm()
        {
            InitializeComponent();

            Label label = new Label();
            label.Location = new Point(0, 10);
            label.Text = "text";
            label.TextAlign = ContentAlignment.MiddleCenter;

            TextBox box = new TextBox();
            box.Location = new Point(130, 10);

            TextBox box2 = new TextBox();
            box2.Location = new Point(130, 40);

            this.Controls.Add(label);
            this.Controls.Add(box);
            this.Controls.Add(box2);
        }
    }
}
