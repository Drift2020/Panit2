using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class NewImage : Form,Interface.INewDocument
    {
        public int HeightP { set { Height.Value=value; } get {return decimal.ToInt32(Height.Value); } }
        public int WidthP { set { Width.Value = value; } get { return decimal.ToInt32(Width.Value); } }
        public NewImage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
