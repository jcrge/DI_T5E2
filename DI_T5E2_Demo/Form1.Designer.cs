namespace DI_T5E2_Demo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNothing = new System.Windows.Forms.RadioButton();
            this.radioButtonImage = new System.Windows.Forms.RadioButton();
            this.radioButtonCircle = new System.Windows.Forms.RadioButton();
            this.radioButtonCross = new System.Windows.Forms.RadioButton();
            this.checkBoxGradient = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxSeparation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxCrossWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCircleWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.iconLabel1 = new DI_T5E2.IconLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNothing);
            this.groupBox1.Controls.Add(this.radioButtonImage);
            this.groupBox1.Controls.Add(this.radioButtonCircle);
            this.groupBox1.Controls.Add(this.radioButtonCross);
            this.groupBox1.Location = new System.Drawing.Point(107, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shape type";
            // 
            // radioButtonNothing
            // 
            this.radioButtonNothing.AutoSize = true;
            this.radioButtonNothing.Location = new System.Drawing.Point(102, 43);
            this.radioButtonNothing.Name = "radioButtonNothing";
            this.radioButtonNothing.Size = new System.Drawing.Size(62, 17);
            this.radioButtonNothing.TabIndex = 3;
            this.radioButtonNothing.TabStop = true;
            this.radioButtonNothing.Text = "Nothing";
            this.radioButtonNothing.UseVisualStyleBackColor = true;
            this.radioButtonNothing.CheckedChanged += new System.EventHandler(this.ShapeTypeChanged);
            // 
            // radioButtonImage
            // 
            this.radioButtonImage.AutoSize = true;
            this.radioButtonImage.Location = new System.Drawing.Point(7, 43);
            this.radioButtonImage.Name = "radioButtonImage";
            this.radioButtonImage.Size = new System.Drawing.Size(54, 17);
            this.radioButtonImage.TabIndex = 2;
            this.radioButtonImage.TabStop = true;
            this.radioButtonImage.Text = "Image";
            this.radioButtonImage.UseVisualStyleBackColor = true;
            this.radioButtonImage.CheckedChanged += new System.EventHandler(this.ShapeTypeChanged);
            // 
            // radioButtonCircle
            // 
            this.radioButtonCircle.AutoSize = true;
            this.radioButtonCircle.Location = new System.Drawing.Point(102, 20);
            this.radioButtonCircle.Name = "radioButtonCircle";
            this.radioButtonCircle.Size = new System.Drawing.Size(51, 17);
            this.radioButtonCircle.TabIndex = 1;
            this.radioButtonCircle.TabStop = true;
            this.radioButtonCircle.Text = "Circle";
            this.radioButtonCircle.UseVisualStyleBackColor = true;
            this.radioButtonCircle.CheckedChanged += new System.EventHandler(this.ShapeTypeChanged);
            // 
            // radioButtonCross
            // 
            this.radioButtonCross.AutoSize = true;
            this.radioButtonCross.Location = new System.Drawing.Point(7, 20);
            this.radioButtonCross.Name = "radioButtonCross";
            this.radioButtonCross.Size = new System.Drawing.Size(51, 17);
            this.radioButtonCross.TabIndex = 0;
            this.radioButtonCross.TabStop = true;
            this.radioButtonCross.Text = "Cross";
            this.radioButtonCross.UseVisualStyleBackColor = true;
            this.radioButtonCross.CheckedChanged += new System.EventHandler(this.ShapeTypeChanged);
            // 
            // checkBoxGradient
            // 
            this.checkBoxGradient.AutoSize = true;
            this.checkBoxGradient.Location = new System.Drawing.Point(6, 19);
            this.checkBoxGradient.Name = "checkBoxGradient";
            this.checkBoxGradient.Size = new System.Drawing.Size(120, 17);
            this.checkBoxGradient.TabIndex = 2;
            this.checkBoxGradient.Text = "Draw linear gradient";
            this.checkBoxGradient.UseVisualStyleBackColor = true;
            this.checkBoxGradient.CheckedChanged += new System.EventHandler(this.checkBoxGradient_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.checkBoxGradient);
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 108);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gradient";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Set starting color";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.textBoxSeparation);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.textBoxCrossWidth);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBoxCircleWidth);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(154, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 108);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Integer parameters";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(123, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxSeparation
            // 
            this.textBoxSeparation.Location = new System.Drawing.Point(76, 79);
            this.textBoxSeparation.Name = "textBoxSeparation";
            this.textBoxSeparation.Size = new System.Drawing.Size(41, 20);
            this.textBoxSeparation.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Separation:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxCrossWidth
            // 
            this.textBoxCrossWidth.Location = new System.Drawing.Point(76, 50);
            this.textBoxCrossWidth.Name = "textBoxCrossWidth";
            this.textBoxCrossWidth.Size = new System.Drawing.Size(41, 20);
            this.textBoxCrossWidth.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cross width:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCircleWidth
            // 
            this.textBoxCircleWidth.Location = new System.Drawing.Point(76, 20);
            this.textBoxCircleWidth.Name = "textBoxCircleWidth";
            this.textBoxCircleWidth.Size = new System.Drawing.Size(41, 20);
            this.textBoxCircleWidth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Circle width:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Set ending color";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // iconLabel1
            // 
            this.iconLabel1.CircleWidth = 10;
            this.iconLabel1.CrossLineWidth = 10;
            this.iconLabel1.GradientEndingColor = System.Drawing.Color.White;
            this.iconLabel1.GradientStartingColor = System.Drawing.Color.Black;
            this.iconLabel1.Image = null;
            this.iconLabel1.LinearGradient = true;
            this.iconLabel1.Location = new System.Drawing.Point(12, 32);
            this.iconLabel1.Name = "iconLabel1";
            this.iconLabel1.Separation = 2;
            this.iconLabel1.Shape = DI_T5E2.ShapeType.Cross;
            this.iconLabel1.Size = new System.Drawing.Size(89, 29);
            this.iconLabel1.TabIndex = 0;
            this.iconLabel1.Text = "iconLabel1";
            this.iconLabel1.ShapeClicked += new System.EventHandler(this.iconLabel1_ShapeClicked);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Location = new System.Drawing.Point(12, 203);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(89, 52);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Image";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 20);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "Choose...";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 299);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iconLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DI_T5E2.IconLabel iconLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCircle;
        private System.Windows.Forms.RadioButton radioButtonCross;
        private System.Windows.Forms.RadioButton radioButtonNothing;
        private System.Windows.Forms.RadioButton radioButtonImage;
        private System.Windows.Forms.CheckBox checkBoxGradient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxSeparation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxCrossWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCircleWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button6;
    }
}

