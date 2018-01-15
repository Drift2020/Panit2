namespace Paint
{
    partial class NewImage
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.w = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.NumericUpDown();
            this.Height = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // w
            // 
            this.w.AutoSize = true;
            this.w.Location = new System.Drawing.Point(10, 26);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(38, 13);
            this.w.TabIndex = 2;
            this.w.Text = "Width:";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Location = new System.Drawing.Point(10, 61);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(41, 13);
            this.h.TabIndex = 3;
            this.h.Text = "Height:";
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(79, 24);
            this.Width.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(96, 20);
            this.Width.TabIndex = 4;
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(79, 59);
            this.Height.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(96, 20);
            this.Height.TabIndex = 5;
            // 
            // NewImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 151);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.h);
            this.Controls.Add(this.w);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "NewImage";
            this.Text = "New Image";
            ((System.ComponentModel.ISupportInitialize)(this.Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label w;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.NumericUpDown Width;
        private System.Windows.Forms.NumericUpDown Height;
    }
}