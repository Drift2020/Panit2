namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Text = new System.Windows.Forms.RadioButton();
            this.Figure = new System.Windows.Forms.RadioButton();
            this.Ruler = new System.Windows.Forms.RadioButton();
            this.Pen = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Font_f = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.widthPen = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewFigure = new System.Windows.Forms.PictureBox();
            this.tyPalit = new System.Windows.Forms.PictureBox();
            this.onePalit = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrintLists = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.PreviewLists = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthPen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFigure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tyPalit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onePalit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(12, 12);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 41);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 70);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 99);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Text);
            this.groupBox1.Controls.Add(this.Figure);
            this.groupBox1.Controls.Add(this.Ruler);
            this.groupBox1.Controls.Add(this.Pen);
            this.groupBox1.Location = new System.Drawing.Point(12, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(75, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // Text
            // 
            this.Text.AutoSize = true;
            this.Text.Location = new System.Drawing.Point(6, 88);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(46, 17);
            this.Text.TabIndex = 3;
            this.Text.TabStop = true;
            this.Text.Text = "Text";
            this.Text.UseVisualStyleBackColor = true;
            this.Text.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Figure
            // 
            this.Figure.AutoSize = true;
            this.Figure.Location = new System.Drawing.Point(6, 65);
            this.Figure.Name = "Figure";
            this.Figure.Size = new System.Drawing.Size(54, 17);
            this.Figure.TabIndex = 2;
            this.Figure.TabStop = true;
            this.Figure.Text = "Figure";
            this.Figure.UseVisualStyleBackColor = true;
            this.Figure.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Ruler
            // 
            this.Ruler.AutoSize = true;
            this.Ruler.Location = new System.Drawing.Point(6, 42);
            this.Ruler.Name = "Ruler";
            this.Ruler.Size = new System.Drawing.Size(50, 17);
            this.Ruler.TabIndex = 1;
            this.Ruler.TabStop = true;
            this.Ruler.Text = "Ruler";
            this.Ruler.UseVisualStyleBackColor = true;
            this.Ruler.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Pen
            // 
            this.Pen.AutoSize = true;
            this.Pen.Location = new System.Drawing.Point(6, 19);
            this.Pen.Name = "Pen";
            this.Pen.Size = new System.Drawing.Size(44, 17);
            this.Pen.TabIndex = 0;
            this.Pen.TabStop = true;
            this.Pen.Text = "Pen";
            this.Pen.UseVisualStyleBackColor = true;
            this.Pen.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(552, 332);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(552, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Font_f
            // 
            this.Font_f.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Font_f.Location = new System.Drawing.Point(450, 359);
            this.Font_f.Name = "Font_f";
            this.Font_f.Size = new System.Drawing.Size(75, 23);
            this.Font_f.TabIndex = 7;
            this.Font_f.Text = "Font";
            this.Font_f.UseVisualStyleBackColor = true;
            this.Font_f.Click += new System.EventHandler(this.Font_f_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(450, 332);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Transparent";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Text:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Width:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Location = new System.Drawing.Point(304, 362);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Example";
            // 
            // widthPen
            // 
            this.widthPen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.widthPen.Location = new System.Drawing.Point(340, 329);
            this.widthPen.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.widthPen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthPen.Name = "widthPen";
            this.widthPen.Size = new System.Drawing.Size(49, 20);
            this.widthPen.TabIndex = 12;
            this.widthPen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthPen.ValueChanged += new System.EventHandler(this.widthPen_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // viewFigure
            // 
            this.viewFigure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.viewFigure.Location = new System.Drawing.Point(12, 319);
            this.viewFigure.Name = "viewFigure";
            this.viewFigure.Size = new System.Drawing.Size(91, 63);
            this.viewFigure.TabIndex = 14;
            this.viewFigure.TabStop = false;
            this.viewFigure.MouseUp += new System.Windows.Forms.MouseEventHandler(this.viewFigure_MouseUp);
            // 
            // tyPalit
            // 
            this.tyPalit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tyPalit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tyPalit.Location = new System.Drawing.Point(166, 332);
            this.tyPalit.Name = "tyPalit";
            this.tyPalit.Size = new System.Drawing.Size(51, 49);
            this.tyPalit.TabIndex = 15;
            this.tyPalit.TabStop = false;
            this.tyPalit.Click += new System.EventHandler(this.tyPalit_Click);
            // 
            // onePalit
            // 
            this.onePalit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.onePalit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.onePalit.Location = new System.Drawing.Point(136, 319);
            this.onePalit.Name = "onePalit";
            this.onePalit.Size = new System.Drawing.Size(51, 49);
            this.onePalit.TabIndex = 16;
            this.onePalit.TabStop = false;
            this.onePalit.Click += new System.EventHandler(this.onePalit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "*.bmp|*.bmp|*.jpg|*.jpg|*.png|*.png|*.gif|*.gif";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(93, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 301);
            this.panel1.TabIndex = 17;
            // 
            // PrintLists
            // 
            this.PrintLists.Location = new System.Drawing.Point(12, 129);
            this.PrintLists.Name = "PrintLists";
            this.PrintLists.Size = new System.Drawing.Size(75, 23);
            this.PrintLists.TabIndex = 18;
            this.PrintLists.Text = "Print";
            this.PrintLists.UseVisualStyleBackColor = true;
            this.PrintLists.Click += new System.EventHandler(this.PrintLists_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // PreviewLists
            // 
            this.PreviewLists.Location = new System.Drawing.Point(12, 158);
            this.PreviewLists.Name = "PreviewLists";
            this.PreviewLists.Size = new System.Drawing.Size(75, 23);
            this.PreviewLists.TabIndex = 19;
            this.PreviewLists.Text = "Preview";
            this.PreviewLists.UseVisualStyleBackColor = true;
            this.PreviewLists.Click += new System.EventHandler(this.PreviewLists_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 392);
            this.Controls.Add(this.PreviewLists);
            this.Controls.Add(this.PrintLists);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.onePalit);
            this.Controls.Add(this.tyPalit);
            this.Controls.Add(this.viewFigure);
            this.Controls.Add(this.widthPen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Font_f);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(699, 393);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthPen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFigure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tyPalit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onePalit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Text;
        private System.Windows.Forms.RadioButton Figure;
        private System.Windows.Forms.RadioButton Ruler;
        private System.Windows.Forms.RadioButton Pen;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Font_f;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown widthPen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox viewFigure;
        private System.Windows.Forms.PictureBox tyPalit;
        private System.Windows.Forms.PictureBox onePalit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PrintLists;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button PreviewLists;
    }
}

