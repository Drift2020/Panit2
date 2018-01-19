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
using System.IO;

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

        #region poleThis

        string nameRadioButton;
        string[] instrument = { "Pen", "Ruler", "Figure", "Text" };
       
        Graphics g;
        Pen pen;
        Color myColor;
        Color myColor2;
        SolidBrush myBrush;
        float WidthPen { set { widthPen.Value = Decimal.Parse(value.ToString()); }get { return float.Parse(widthPen.Value.ToString()); } }
        int x;
        int y;
        int width = 1000;
        int height = 300;
        #endregion poleThis

        #region pole
        public string NameRadioButton { set { nameRadioButton = value; } get { return nameRadioButton; } }
        public string[] Instrument { set { instrument = value; } get { return instrument; } }
        #endregion pole

        public Form1()
        {

            InitializeComponent();
            myColor = Color.Black;
            myColor2 = Color.White;
            pen = new Pen(myColor, WidthPen);
            myBrush = new SolidBrush(myColor);
            

            openFileDialog1.InitialDirectory = saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Pen.Checked = true;
            radioButton1_CheckedChanged(this.Pen, EventArgs.Empty);


            Image im = new Bitmap(width, height);
            g = Graphics.FromImage(im);
            g.Clear(Color.White);
            g.Dispose();
            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();
            pictureBox1.Image = im;

            PrintViewFigure();
            Palitres();


            g = Graphics.FromImage(pictureBox1.Image);
        }


        #region RadioButton
        private void MousSelect()
        {
            try
            {
                if (nameRadioButton == Instrument[0])
                {
                    pictureBox1.Cursor = new Cursor("../../Curkol/pen.cur");
                    g.Dispose();
                    g = Graphics.FromImage(pictureBox1.Image);
                }
                else if (nameRadioButton == Instrument[1])
                {
                    pictureBox1.Cursor = new Cursor("../../Curkol/brush.cur");
                }
                else if (nameRadioButton == Instrument[2])
                {
                    pictureBox1.Cursor = new Cursor("../../Curkol/cursor2.cur");
                    g.Dispose();
                    g = Graphics.FromHwnd(pictureBox1.Handle);
                }
                else if (nameRadioButton == Instrument[3])
                {
                    pictureBox1.Cursor = Cursors.Arrow;
                }
            }
            catch { }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nameRadioButton = (sender as RadioButton).Name;
            RadioButton?.Invoke(this, EventArgs.Empty);
            MousSelect();
        }
        #endregion RadioButton

       
       

        #region Paint
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
                if (nameRadioButton == Instrument[2])
                {
                    g.Dispose();
                    g = Graphics.FromHwnd(pictureBox1.Handle);

                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (nameRadioButton == Instrument[0])
                {
                    g.FillRectangle(myBrush, e.X, e.Y, WidthPen, WidthPen);
                    pictureBox1.Invalidate();
                }
                else if (nameRadioButton == Instrument[1])
                {

                }
                else if (nameRadioButton == Instrument[2])
                {
                    g.Dispose();
                    g = Graphics.FromImage(pictureBox1.Image);
                    if (e.X < x && e.Y < y)
                    {
                        g.DrawRectangle(pen, e.X, e.Y, x - e.X, y - e.Y);
                    }
                    else if (e.X < x)
                    {
                        g.DrawRectangle(pen, e.X, y, x - e.X, e.Y - y);
                    }
                    else if (e.Y < y)
                    {
                        g.DrawRectangle(pen, x, e.Y, e.X - x, y - e.Y);
                    }
                    else
                    {
                        g.DrawRectangle(pen, x, y, e.X - x, e.Y - y);
                    }
                    pictureBox1.Invalidate();
                }
                else if (nameRadioButton == Instrument[3])
                {
                }
            }
        }    
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                pictureBox1.Invalidate();
                if (nameRadioButton == Instrument[0])
                {
                    g.FillRectangle(myBrush, e.X, e.Y, WidthPen, WidthPen);
                    pictureBox1.Invalidate();
                }
                else if (nameRadioButton == Instrument[1])
                {

                }
                else if (nameRadioButton == Instrument[2])
                {
                    if (e.X < x && e.Y < y)
                    {
                        g.DrawRectangle(pen, e.X, e.Y, x - e.X, y - e.Y);

                     
                    }
                    else if (e.X < x)
                    {
                        g.DrawRectangle(pen, e.X, y, x - e.X, e.Y - y);
                    }
                    else if (e.Y < y)
                    {
                        g.DrawRectangle(pen, x, e.Y, e.X - x, y - e.Y);
                    }
                    else
                    {
                        g.DrawRectangle(pen, x, y, e.X - x, e.Y - y);
                    }
                    
                }
                else if (nameRadioButton == Instrument[3])
                {

                }
            }

        }
        #endregion Paint



        #region Palitres
        private void Palitres()
        {
            onePalit.BackColor = myColor;
            tyPalit.BackColor = myColor2;
        }
        private void PrintViewFigure()
        {
            Image im = new Bitmap(viewFigure.Width, viewFigure.Height);
            using (Graphics temp = Graphics.FromImage(im)) {                             
                temp.Clear(myColor2);
                temp.DrawRectangle(pen, 0, 0, viewFigure.ClientSize.Width, viewFigure.ClientSize.Height);
                temp.Dispose();
                if (viewFigure.Image != null)
                    viewFigure.Image.Dispose();
                viewFigure.Image = im;

               
            }
        }
        private void onePalit_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = myColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Dispose();
                myBrush.Dispose();
                myColor = colorDialog1.Color;

                onePalit.BackColor = myColor;

                pen = new Pen(myColor, WidthPen);
                myBrush = new SolidBrush(myColor);
               

                PrintViewFigure();
            }
        }
        private void tyPalit_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = myColor2;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
               
                myColor2 = colorDialog1.Color;
                tyPalit.BackColor = myColor2;

                PrintViewFigure();
            }
        }
        #endregion Palotres

        #region ControlButt
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string s0 = saveFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string s = saveFileDialog1.FileName;
                // .NET не даст сохранить изображение в тот же файл, из которого загружали
                if (s.ToUpper() == s0.ToUpper())// если пытаемся сохранять изображение в тот же файл, из которого загружали
                {
                    // сохраним изображение во временный файл
                    s0 = Path.GetDirectoryName(s0) + "\\($$##$$)";
                    pictureBox1.Image.Save(s0);
                    // разрушим объект Bitmap, связанный с данным изображением 
                    pictureBox1.Image.Dispose();
                    // удалим исходный файл
                    File.Delete(s);
                    // имя временного файла заменим на имя исходного файла
                    File.Move(s0, s);
                    // загрузим на PictureBox новый вариант файла
                    pictureBox1.Image = new Bitmap(s);
                }
                else if (pictureBox1.Image != null)
                    pictureBox1.Image.Save(s);
                //Text = "Image Editor - " + s;
            }
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "c:\\"; // зададим начальную папку, отображенную диалоговым окном файла
            openFileDialog1.Multiselect = false; // запретить множественный выбор файлов
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string s = openFileDialog1.FileName;
                try
                {
                    // класс Bitmap является производным от Image
                    Image im = new Bitmap(s); // присоединим изображение из указанного файла к объекту Bitmap
                    if (pictureBox1.Image != null)
                        pictureBox1.Image.Dispose(); // освободим предыдущий объект Image
                    pictureBox1.Image = im; // поместим на PictureBox выбранное изображение

                    g.Dispose();
                    g = Graphics.FromImage(pictureBox1.Image);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                //Text = "Image Viewer - " + s;
                saveFileDialog1.FileName = s;
                openFileDialog1.FileName = "";

            }

        }
        private void buttonNew_Click(object sender, EventArgs e)
        {

            NewImage NewImage_form = new NewImage();
            Presenter.PNewDocument NewImage_Presenter = new Presenter.PNewDocument(NewImage_form);

            if (NewImage_form.ShowDialog() == DialogResult.OK)
            {
                width = NewImage_form.WidthP;
                height = NewImage_form.HeightP;

                Image im = new Bitmap(width, height);
                g.Dispose();
                g = Graphics.FromImage(im);
                g.Clear(Color.White);

                if (pictureBox1.Image != null)
                    pictureBox1.Image.Dispose();
                pictureBox1.Image = im;
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
          
            g.Clear(Color.White);
            pictureBox1.Invalidate();


        }
        #endregion ControlButt
        private void widthPen_ValueChanged(object sender, EventArgs e)
        {
            pen.Dispose();
            pen = new Pen(myColor, WidthPen);
            PrintViewFigure();
        }
    }
}
