namespace Maine
{
    partial class MainForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.color_dialog = new System.Windows.Forms.ColorDialog();
            this.dda = new System.Windows.Forms.RadioButton();
            this.bresenham = new System.Windows.Forms.RadioButton();
            this.wu = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.initials = new System.Windows.Forms.RadioButton();
            this.circle = new System.Windows.Forms.RadioButton();
            this.ellipse = new System.Windows.Forms.RadioButton();
            this.line = new System.Windows.Forms.RadioButton();
            this.x1 = new System.Windows.Forms.NumericUpDown();
            this._x1 = new System.Windows.Forms.Label();
            this._y1 = new System.Windows.Forms.Label();
            this.y1 = new System.Windows.Forms.NumericUpDown();
            this._x2 = new System.Windows.Forms.Label();
            this.x2 = new System.Windows.Forms.NumericUpDown();
            this._y2 = new System.Windows.Forms.Label();
            this.y2 = new System.Windows.Forms.NumericUpDown();
            this.bSelectColor = new System.Windows.Forms.Button();
            this.cbox = new System.Windows.Forms.PictureBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.save_file = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(975, 626);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Draw";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbox
            // 
            this.pbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pbox.Location = new System.Drawing.Point(10, 12);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(1200, 600);
            this.pbox.TabIndex = 2;
            this.pbox.TabStop = false;
            this.pbox.Click += new System.EventHandler(this.pbox_Click);
            // 
            // color_dialog
            // 
            this.color_dialog.AnyColor = true;
            // 
            // dda
            // 
            this.dda.AutoSize = true;
            this.dda.Enabled = false;
            this.dda.Location = new System.Drawing.Point(15, 15);
            this.dda.Name = "dda";
            this.dda.Size = new System.Drawing.Size(48, 17);
            this.dda.TabIndex = 4;
            this.dda.TabStop = true;
            this.dda.Text = "DDA";
            this.dda.UseVisualStyleBackColor = true;
            this.dda.CheckedChanged += new System.EventHandler(this.DDA_CheckedChanged);
            // 
            // bresenham
            // 
            this.bresenham.AutoSize = true;
            this.bresenham.Enabled = false;
            this.bresenham.Location = new System.Drawing.Point(15, 38);
            this.bresenham.Name = "bresenham";
            this.bresenham.Size = new System.Drawing.Size(86, 17);
            this.bresenham.TabIndex = 5;
            this.bresenham.TabStop = true;
            this.bresenham.Text = "Bresenham`s";
            this.bresenham.UseVisualStyleBackColor = true;
            this.bresenham.CheckedChanged += new System.EventHandler(this.Bresenham_CheckedChanged);
            // 
            // wu
            // 
            this.wu.AutoSize = true;
            this.wu.Enabled = false;
            this.wu.Location = new System.Drawing.Point(15, 61);
            this.wu.Name = "wu";
            this.wu.Size = new System.Drawing.Size(50, 17);
            this.wu.TabIndex = 6;
            this.wu.TabStop = true;
            this.wu.Text = "Wu`s";
            this.wu.UseVisualStyleBackColor = true;
            this.wu.CheckedChanged += new System.EventHandler(this.Wu_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bresenham);
            this.panel1.Controls.Add(this.wu);
            this.panel1.Controls.Add(this.dda);
            this.panel1.Location = new System.Drawing.Point(179, 621);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 93);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.initials);
            this.panel2.Controls.Add(this.circle);
            this.panel2.Controls.Add(this.ellipse);
            this.panel2.Controls.Add(this.line);
            this.panel2.Location = new System.Drawing.Point(10, 621);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 118);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // initials
            // 
            this.initials.AutoSize = true;
            this.initials.Location = new System.Drawing.Point(15, 84);
            this.initials.Name = "initials";
            this.initials.Size = new System.Drawing.Size(54, 17);
            this.initials.TabIndex = 7;
            this.initials.TabStop = true;
            this.initials.Text = "Initials";
            this.initials.UseVisualStyleBackColor = true;
            this.initials.CheckedChanged += new System.EventHandler(this.initials_CheckedChanged);
            // 
            // circle
            // 
            this.circle.AutoSize = true;
            this.circle.Location = new System.Drawing.Point(15, 38);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(51, 17);
            this.circle.TabIndex = 5;
            this.circle.TabStop = true;
            this.circle.Text = "Circle";
            this.circle.UseVisualStyleBackColor = true;
            this.circle.CheckedChanged += new System.EventHandler(this.circle_CheckedChanged);
            // 
            // ellipse
            // 
            this.ellipse.AutoSize = true;
            this.ellipse.Location = new System.Drawing.Point(15, 61);
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(55, 17);
            this.ellipse.TabIndex = 6;
            this.ellipse.TabStop = true;
            this.ellipse.Text = "Ellipse";
            this.ellipse.UseVisualStyleBackColor = true;
            this.ellipse.CheckedChanged += new System.EventHandler(this.ellipse_CheckedChanged);
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Location = new System.Drawing.Point(15, 15);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(45, 17);
            this.line.TabIndex = 4;
            this.line.TabStop = true;
            this.line.Text = "Line";
            this.line.UseVisualStyleBackColor = true;
            this.line.CheckedChanged += new System.EventHandler(this.line_CheckedChanged);
            // 
            // x1
            // 
            this.x1.Enabled = false;
            this.x1.Location = new System.Drawing.Point(388, 628);
            this.x1.Maximum = new decimal(new int[] {
            1599,
            0,
            0,
            0});
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(120, 20);
            this.x1.TabIndex = 9;
            this.x1.Value = new decimal(new int[] {
            900,
            0,
            0,
            0});
            // 
            // _x1
            // 
            this._x1.AutoSize = true;
            this._x1.Location = new System.Drawing.Point(364, 630);
            this._x1.Name = "_x1";
            this._x1.Size = new System.Drawing.Size(18, 13);
            this._x1.TabIndex = 10;
            this._x1.Text = "x1";
            // 
            // _y1
            // 
            this._y1.AutoSize = true;
            this._y1.Location = new System.Drawing.Point(364, 656);
            this._y1.Name = "_y1";
            this._y1.Size = new System.Drawing.Size(18, 13);
            this._y1.TabIndex = 12;
            this._y1.Text = "y1";
            // 
            // y1
            // 
            this.y1.Enabled = false;
            this.y1.Location = new System.Drawing.Point(388, 654);
            this.y1.Maximum = new decimal(new int[] {
            599,
            0,
            0,
            0});
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(120, 20);
            this.y1.TabIndex = 11;
            this.y1.Value = new decimal(new int[] {
            599,
            0,
            0,
            0});
            // 
            // _x2
            // 
            this._x2.AutoSize = true;
            this._x2.Location = new System.Drawing.Point(364, 682);
            this._x2.Name = "_x2";
            this._x2.Size = new System.Drawing.Size(18, 13);
            this._x2.TabIndex = 14;
            this._x2.Text = "x2";
            // 
            // x2
            // 
            this.x2.Enabled = false;
            this.x2.Location = new System.Drawing.Point(388, 680);
            this.x2.Maximum = new decimal(new int[] {
            1599,
            0,
            0,
            0});
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(120, 20);
            this.x2.TabIndex = 13;
            this.x2.Value = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.x2.ValueChanged += new System.EventHandler(this.x2_ValueChanged);
            // 
            // _y2
            // 
            this._y2.AutoSize = true;
            this._y2.Location = new System.Drawing.Point(364, 708);
            this._y2.Name = "_y2";
            this._y2.Size = new System.Drawing.Size(18, 13);
            this._y2.TabIndex = 16;
            this._y2.Text = "y2";
            // 
            // y2
            // 
            this.y2.Enabled = false;
            this.y2.Location = new System.Drawing.Point(388, 706);
            this.y2.Maximum = new decimal(new int[] {
            1599,
            0,
            0,
            0});
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(120, 20);
            this.y2.TabIndex = 15;
            this.y2.Value = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.y2.ValueChanged += new System.EventHandler(this.y2_ValueChanged);
            // 
            // bSelectColor
            // 
            this.bSelectColor.Location = new System.Drawing.Point(894, 626);
            this.bSelectColor.Name = "bSelectColor";
            this.bSelectColor.Size = new System.Drawing.Size(75, 23);
            this.bSelectColor.TabIndex = 17;
            this.bSelectColor.Text = "Select color";
            this.bSelectColor.UseVisualStyleBackColor = true;
            this.bSelectColor.Click += new System.EventHandler(this.bSelectColor_Click);
            // 
            // cbox
            // 
            this.cbox.BackColor = System.Drawing.Color.Black;
            this.cbox.Location = new System.Drawing.Point(813, 626);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(75, 23);
            this.cbox.TabIndex = 18;
            this.cbox.TabStop = false;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(1137, 626);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 19;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(1056, 626);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 20;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // save_file
            // 
            this.save_file.Filter = "BitMap files (*.bmp)|*.*";
            this.save_file.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1224, 761);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.bSelectColor);
            this.Controls.Add(this._y2);
            this.Controls.Add(this.y2);
            this.Controls.Add(this._x2);
            this.Controls.Add(this.x2);
            this.Controls.Add(this._y1);
            this.Controls.Add(this.y1);
            this.Controls.Add(this._x1);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbox);
            this.Controls.Add(this.button2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maine project";
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.ColorDialog color_dialog;
        private System.Windows.Forms.RadioButton dda;
        private System.Windows.Forms.RadioButton bresenham;
        private System.Windows.Forms.RadioButton wu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton circle;
        private System.Windows.Forms.RadioButton ellipse;
        private System.Windows.Forms.RadioButton line;
        private System.Windows.Forms.RadioButton initials;
        private System.Windows.Forms.NumericUpDown x1;
        private System.Windows.Forms.Label _x1;
        private System.Windows.Forms.Label _y1;
        private System.Windows.Forms.NumericUpDown y1;
        private System.Windows.Forms.Label _x2;
        private System.Windows.Forms.NumericUpDown x2;
        private System.Windows.Forms.Label _y2;
        private System.Windows.Forms.NumericUpDown y2;
        private System.Windows.Forms.Button bSelectColor;
        private System.Windows.Forms.PictureBox cbox;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.SaveFileDialog save_file;
    }
}

