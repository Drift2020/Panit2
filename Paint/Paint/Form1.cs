﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Paint
{
    struct PointList {
        public int x;
        public int y;
        public int width;
        public int height;

       

        public void PointListE(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;

        }
    }
    public partial class Form1 : Form, Interface.IGlobal
    {
        #region event
        public event EventHandler<EventArgs> RadioButton;
        public event EventHandler<EventArgs> OpenImage;
        public event EventHandler<EventArgs> SaveImage;
        public event EventHandler<EventArgs> NewImage;

        #endregion event

        #region poleThisClass

        string nameRadioButton;
        string[] instrument = { "Pen", "Ruler", "Figure", "Text" };
       
        Graphics g;
        Pen pen;
        Color myColor;
        Color myColor2;
        SolidBrush myBrush;
        SolidBrush myBrushPen;
        Font tempFont;
        Font font;
        PointList myPointList = new PointList();



        bool Transparent { set { checkBox1.Checked = value; }get { return checkBox1.Checked; } }
        bool rectangle;
        float WidthPen { set { widthPen.Value = Decimal.Parse(value.ToString()); }get { return float.Parse(widthPen.Value.ToString()); } }
        int x;
        int y;
        int width = 1000;
        int height = 300;

        int widthNow = 0;
        int heightNow = 0;

        int widthPrev = 797;
        int heightPrev = 1127;

        int MaxPages = 0;
        int minPage = 0;
        int maxPage = 0;

        int countPage = 0;

        bool pageList = false;
        

        int numberStylePen=0;
        string str = "Transp.";
        int sizeStr = 10;
        int  dopSizeW =4;
        int dopSizeH = 6;
      
        #endregion poleThisClass

        #region pole
        public string NameRadioButton { set { nameRadioButton = value; } get { return nameRadioButton; } }
        public string[] Instrument { set { instrument = value; } get { return instrument; } }
        #endregion pole

        public Form1()
        {

            
            myPointList.PointListE(0, 0, widthPrev, heightPrev);
            InitializeComponent();
            myColor = Color.Black;
            myColor2 = Color.White;
            pen = new Pen(myColor, WidthPen);
            tempFont = new Font("Arial", sizeStr);
            rectangle = true;
            myBrush = new SolidBrush(myColor2);
            myBrushPen = new SolidBrush(myColor);
            font = new Font("Arial", sizeStr);
            openFileDialog1.InitialDirectory = saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
         
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Pen.Checked = true;
            radioButton1_CheckedChanged(this.Pen, EventArgs.Empty);
            comboBox1.SelectedIndex = 0;

           

            Image im = new Bitmap(width, height);
            g = Graphics.FromImage(im);
            g.Clear(Color.White);
            g.Dispose();
            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();
            pictureBox1.Image = im;

            PrintViewFigure();
            PalitresColor();


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
                    g.Dispose();
                    g = Graphics.FromHwnd(pictureBox1.Handle);
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
                if (nameRadioButton == Instrument[2]|| nameRadioButton == Instrument[1] || nameRadioButton == Instrument[3])
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
                    g.FillEllipse(myBrush, e.X, e.Y, WidthPen, WidthPen);
                   
                }
                else if (nameRadioButton == Instrument[1])
                {
                    g.Dispose();
                    g = Graphics.FromImage(pictureBox1.Image);
                    g.DrawLine(pen, e.X, e.Y, x, y);
                }
                else if (nameRadioButton == Instrument[2])
                {
                    g.Dispose();
                    g = Graphics.FromImage(pictureBox1.Image);
                    DravFigure(e);
                    
                }
                else if (nameRadioButton == Instrument[3])
                {
                    g.Dispose();
                    g = Graphics.FromImage(pictureBox1.Image);

                    g.DrawString(textBox1.Text, font, myBrushPen, x, y- font.Size);
                }
                pictureBox1.Invalidate();
            }
        }    
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                pictureBox1.Invalidate();
                if (nameRadioButton == Instrument[0])
                {
                    g.FillEllipse(myBrushPen, e.X, e.Y, WidthPen, WidthPen);
                    pictureBox1.Invalidate();
                }
                else if (nameRadioButton == Instrument[1])
                {
                    g.DrawLine(pen, e.X, e.Y,  x, y );
                }
                else if (nameRadioButton == Instrument[2])
                {
                    DravFigure(e);
                }
                else if (nameRadioButton == Instrument[3])
                {

                }
            }

             label1.Text="X: "+ e.X+" Y: " + e.Y;
          
        }

        private void DravFigure(MouseEventArgs e)
        {
            if (!Transparent)
            {
                if (rectangle)
                {
                    if (e.X < x && e.Y < y)
                    {
                        g.FillRectangle(myBrush, e.X, e.Y, x - e.X, y - e.Y);
                    }
                    else if (e.X < x)
                    {
                        g.FillRectangle(myBrush, e.X, y, x - e.X, e.Y - y);
                    }
                    else if (e.Y < y)
                    {
                        g.FillRectangle(myBrush, x, e.Y, e.X - x, y - e.Y);
                    }
                    else
                    {
                        g.FillRectangle(myBrush, x, y, e.X - x, e.Y - y);
                    }
                }
                else
                {
                    if (e.X < x && e.Y < y)
                    {
                        g.FillEllipse(myBrush, new Rectangle(e.X, e.Y, x - e.X, y - e.Y));

                    }
                    else if (e.X < x)
                    {
                        g.FillEllipse(myBrush, new Rectangle(e.X, y, x - e.X, e.Y - y));
                    }
                    else if (e.Y < y)
                    {
                        g.FillEllipse(myBrush, new Rectangle(x, e.Y, e.X - x, y - e.Y));
                    }
                    else
                    {
                        g.FillEllipse(myBrush, new Rectangle(x, y, e.X - x, e.Y - y));
                    }

                }

            }
            if (rectangle)
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
                else
                {
                    if (e.X < x && e.Y < y)
                    {
                        g.DrawEllipse(pen, new Rectangle(e.X, e.Y, x - e.X, y - e.Y));

                    }
                    else if (e.X < x)
                    {
                        g.DrawEllipse(pen, new Rectangle(e.X, y, x - e.X, e.Y - y));
                    }
                    else if (e.Y < y)
                    {
                        g.DrawEllipse(pen, new Rectangle(x, e.Y, e.X - x, y - e.Y));
                    }
                    else
                    {
                        g.DrawEllipse(pen, new Rectangle(x, y, e.X - x, e.Y - y));
                    }

                }

          
            
        }
        #endregion Paint

        #region Palitres
        private void PalitresColor()
        {
            onePalit.BackColor = myColor;
            tyPalit.BackColor = myColor2;
        }
        private void PrintViewFigure()
        {
           
            Image im = new Bitmap(viewFigure.Width, viewFigure.Height);
            using (Graphics temp = Graphics.FromImage(im))
            {
                if (!Transparent)
                    temp.Clear(myColor2);
                else              
                    using (SolidBrush b = new SolidBrush(Color.Black))
                        temp.DrawString(str, tempFont, b, viewFigure.Width / 2 - (str.Length + sizeStr + dopSizeW), viewFigure.Height / 2 - dopSizeH);


                if (rectangle)
                {
                    temp.DrawRectangle(pen, 0, 0, viewFigure.ClientSize.Width, viewFigure.ClientSize.Height);
                    using (GraphicsPath path = new GraphicsPath())
                    {
                        path.AddRectangle(new Rectangle(0, 0, viewFigure.ClientSize.Width, viewFigure.ClientSize.Height));
                        viewFigure.Region = new Region(path);
                    }
                }
                else
                {
                    temp.DrawEllipse(pen, new Rectangle(0, 0, viewFigure.ClientSize.Width, viewFigure.ClientSize.Height));
                    using (GraphicsPath path = new GraphicsPath())
                    {
                        path.AddEllipse(0, 0, viewFigure.ClientSize.Width, viewFigure.ClientSize.Height);
                        viewFigure.Region = new Region(path);
                    }
                }
                
                
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
                myColor = colorDialog1.Color;

                onePalit.BackColor = myColor;
                myBrushPen.Color = myColor;
                pen.Color= myColor;
                             
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
                myBrush.Color = myColor2;
                PrintViewFigure();
            }
        }

        private void widthPen_ValueChanged(object sender, EventArgs e)
        {

            pen.Width = WidthPen;
            PrintViewFigure();

        }
        private void StylePen()
        {
            pen.DashStyle = (DashStyle)numberStylePen;
        }
        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            using (Pen p = new Pen(e.ForeColor, 2))
            {
                numberStylePen = e.Index;
                pen.DashStyle = (DashStyle)e.Index;
                p.DashStyle = (DashStyle)e.Index;
                int y = (e.Bounds.Top + e.Bounds.Bottom) / 2;
                e.Graphics.DrawLine(p, e.Bounds.Left, y, e.Bounds.Right, y);
            }
            e.DrawFocusRectangle();
            PrintViewFigure();
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

            NewImage_form.Dispose();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to clear this picture?", "Сlear",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                g.Clear(myColor2);
                pictureBox1.Invalidate();
            }


        }

        #endregion ControlButt

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PrintViewFigure();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to exit this app?", "Exit",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
            
        }

        private void viewFigure_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rectangle = !rectangle;
                PrintViewFigure();
            }
        }

        private void Font_f_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                font = fontDialog1.Font;
                textBox1.Font = font;

            }
        }


        private void printPage(Image im ,PrintPageEventArgs e)
        {
            widthNow += e.MarginBounds.Width + 200;
            if (widthNow < im.Width)
            {             
                e.HasMorePages = true;
            }
            else
            {
              
                widthNow = 0;
                heightNow += e.MarginBounds.Height + 200;
                if (heightNow < im.Height)
                {
                    e.HasMorePages = true;
                }
                else
                    e.HasMorePages = false;

            }
        }
        private void SizePage(Image im, PrintPageEventArgs e, ref int MaxPages)
        {
            for (int widthNow = 0, heightNow = 0, end = 0; end != 1;)
            {
                widthNow += e.MarginBounds.Width + 200;
                if (widthNow < im.Width)
                {
                    MaxPages++;
                }
                else
                {
                    widthNow = 0;
                    heightNow += e.MarginBounds.Height + 200;
                    if (heightNow < im.Height)
                    {
                        MaxPages++;
                    }
                    else
                    {
                        MaxPages++;
                        end = 1;
                    }
                }
            }
        }
        private void StartPage(Image im, PrintPageEventArgs e)
        {
            for (int i=1 ;i<minPage; i++)
            {
                widthNow += e.MarginBounds.Width + 200;
                if (widthNow > im.Width)
                {
                    widthNow = 0;
                    heightNow += e.MarginBounds.Height + 200;
                    
                }
            }
        }
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                // Метод Print класса PrintDocument задает выводимые на печать данные, 
                // обрабатывая событие PrintPage и используя Graphics, включенный в класс PrintPageEventArgs.

                // загружаем изображение из файла
               

                Image im1 = new Bitmap(pictureBox1.Image);
              
                Graphics gr = e.Graphics;

                if (minPage != 0 && countPage <= maxPage)
                {

                    if (MaxPages == 0)
                    {
                        SizePage(im1, e, ref MaxPages);
                        StartPage(im1, e);
                    }
                    if (maxPage >= MaxPages)                                 
                    {
                        throw new Exception("You value max page is not correct.");
                    }

                    

                  
                    gr.DrawImage(im1, new Rectangle(myPointList.x, myPointList.y, e.MarginBounds.Width + 200, e.MarginBounds.Height + 200),
                    new Rectangle(widthNow, heightNow, e.MarginBounds.Width + 200, e.MarginBounds.Height + 200), GraphicsUnit.Pixel);
                    countPage++;
                    printPage(im1, e);
                }
                else if(minPage==0)
                {
                    gr.DrawImage(im1, new Rectangle(myPointList.x, myPointList.y, e.MarginBounds.Width + 200, e.MarginBounds.Height + 200),
                    new Rectangle(widthNow, heightNow, e.MarginBounds.Width + 200, e.MarginBounds.Height + 200), GraphicsUnit.Pixel);

                    printPage(im1, e);
                }
                else
                {
                    e.HasMorePages = false;
                }                          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PrintLists_Click(object sender, EventArgs e)
        {
            try
            {
                widthNow = 0;
                heightNow = 0;
                // Создаем документ и прикрепляем к нему обработчик события
                PrintDocument doc = new PrintDocument(); // новое задание печати

                //  Событие PrintPage происходит, когда необходимо вывести на печать текущую страницу
                doc.PrintPage += this.Doc_PrintPage;

                // Пользователь может выбирать принтер и его свойства через стандартное диалоговое окно
                // PrintDialog printDialog1 = new PrintDialog();

                printDialog1.Document = doc;
                DialogResult result = printDialog1.ShowDialog();
                // Если выбрана кнопка OK, то печатаем документ
                if (result == DialogResult.OK)// модальный диалог
                {
                    MaxPages = 0;
                    countPage = minPage = printDialog1.PrinterSettings.FromPage;
                    maxPage = printDialog1.PrinterSettings.ToPage;

                    doc.Print();

                    //for (int i=0;i < printDialog1.PrinterSettings.MaximumCopies;i++)
                    //doc.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PreviewLists_Click(object sender, EventArgs e)
        {
            try
            {
                widthNow = 0;
                heightNow = 0;
                // Создаем документ и прикрепляем к нему обработчик события
                PrintDocument doc = new PrintDocument(); // новое задание печати

                // Событие PrintPage происходит, когда необходимо вывести на печать текущую страницу.
                doc.PrintPage += this.Doc_PrintPage;

                // PrintPreviewDialog представляет стандартное диалоговое окно предварительного просмотра
                PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
                printPreviewDialog1.Document = doc; // Получает или задает документ для предварительного просмотра.
                printPreviewDialog1.Show();
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }
        }

    }
}
