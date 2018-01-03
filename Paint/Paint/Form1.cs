using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form, Interface.IGlobal
    {
        #region event
        public event EventHandler<EventArgs> RadioButton;
        public event EventHandler<EventArgs> OpenImage;
        public event EventHandler<EventArgs> SaveImage;
        public event EventHandler<EventArgs> NewImage;
        #endregion event

        #region pole
        public string NameRadioButton{set;get;}
        #endregion pole

        public Form1()
        {
            InitializeComponent();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
          if(e.Button==MouseButtons.Left)
            {     
             Pen pen = new Pen(Color.Red, 5.0f);
             Graphics g = Graphics.FromImage(pictureBox1.Image);
             g.DrawRectangle(pen, e.X, e.Y, 90, 90);
             pictureBox1.Invalidate();
             pen.Dispose();
             g.Dispose();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap screenPicture = new Bitmap(pictureBox1.Width, pictureBox1.Height);            
            pictureBox1.Image = screenPicture;
            using (var g = Graphics.FromImage(pictureBox1.Image))
                g.Clear(Color.White); // g.FillRectangle(Brushes.Black, 0, 0, bmp.Width, bmp.Height);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "c:\\"; // зададим начальную папку, отображенную диалоговым окном файла
            openFileDialog1.Multiselect = false; // запретить множественный выбор файлов
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName, "Открытие файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
