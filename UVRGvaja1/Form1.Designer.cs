namespace UVRGvaja1
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
            this.label1 = new System.Windows.Forms.Label();
            this.point1x = new System.Windows.Forms.TextBox();
            this.point1y = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.point2x = new System.Windows.Forms.TextBox();
            this.point2y = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.point3x = new System.Windows.Forms.TextBox();
            this.point3y = new System.Windows.Forms.TextBox();
            this.point4x = new System.Windows.Forms.TextBox();
            this.point4y = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Point 1(x,y)";
            // 
            // point1x
            // 
            this.point1x.Enabled = false;
            this.point1x.Location = new System.Drawing.Point(634, 69);
            this.point1x.Name = "point1x";
            this.point1x.Size = new System.Drawing.Size(54, 22);
            this.point1x.TabIndex = 1;
            // 
            // point1y
            // 
            this.point1y.Enabled = false;
            this.point1y.Location = new System.Drawing.Point(695, 69);
            this.point1y.Name = "point1y";
            this.point1y.Size = new System.Drawing.Size(55, 22);
            this.point1y.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Point 2(x,y)";
            // 
            // point2x
            // 
            this.point2x.Enabled = false;
            this.point2x.Location = new System.Drawing.Point(634, 119);
            this.point2x.Name = "point2x";
            this.point2x.Size = new System.Drawing.Size(54, 22);
            this.point2x.TabIndex = 4;
            // 
            // point2y
            // 
            this.point2y.Enabled = false;
            this.point2y.Location = new System.Drawing.Point(695, 118);
            this.point2y.Name = "point2y";
            this.point2y.Size = new System.Drawing.Size(55, 22);
            this.point2y.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Location = new System.Drawing.Point(660, 404);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 36);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 528);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // point3x
            // 
            this.point3x.Enabled = false;
            this.point3x.Location = new System.Drawing.Point(637, 164);
            this.point3x.Name = "point3x";
            this.point3x.Size = new System.Drawing.Size(51, 22);
            this.point3x.TabIndex = 8;
            // 
            // point3y
            // 
            this.point3y.Enabled = false;
            this.point3y.Location = new System.Drawing.Point(695, 164);
            this.point3y.Name = "point3y";
            this.point3y.Size = new System.Drawing.Size(55, 22);
            this.point3y.TabIndex = 9;
            // 
            // point4x
            // 
            this.point4x.Enabled = false;
            this.point4x.Location = new System.Drawing.Point(637, 213);
            this.point4x.Name = "point4x";
            this.point4x.Size = new System.Drawing.Size(51, 22);
            this.point4x.TabIndex = 10;
            // 
            // point4y
            // 
            this.point4y.Enabled = false;
            this.point4y.Location = new System.Drawing.Point(695, 213);
            this.point4y.Name = "point4y";
            this.point4y.Size = new System.Drawing.Size(55, 22);
            this.point4y.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(634, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Point 3(x,y)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(637, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Point 4(x,y)";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(640, 251);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(142, 21);
            this.rb1.TabIndex = 14;
            this.rb1.TabStop = true;
            this.rb1.Text = "Distance, 2 points";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(640, 279);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(114, 21);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "1 line, 1 point";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(640, 307);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 21);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "2 lines";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.point4y);
            this.Controls.Add(this.point4x);
            this.Controls.Add(this.point3y);
            this.Controls.Add(this.point3x);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.point2y);
            this.Controls.Add(this.point2x);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.point1y);
            this.Controls.Add(this.point1x);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox point1x;
        private System.Windows.Forms.TextBox point1y;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox point2x;
        private System.Windows.Forms.TextBox point2y;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox point3x;
        private System.Windows.Forms.TextBox point3y;
        private System.Windows.Forms.TextBox point4x;
        private System.Windows.Forms.TextBox point4y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

