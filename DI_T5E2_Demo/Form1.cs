using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_T5E2_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            radioButtonCross.Tag = DI_T5E2.ShapeType.Cross;
            radioButtonCircle.Tag = DI_T5E2.ShapeType.Circle;
            radioButtonImage.Tag = DI_T5E2.ShapeType.Image;
            radioButtonNothing.Tag = DI_T5E2.ShapeType.Nothing;

            switch (iconLabel1.Shape)
            {
                case DI_T5E2.ShapeType.Cross:
                    radioButtonCross.Checked = true;
                    break;
                case DI_T5E2.ShapeType.Circle:
                    radioButtonCircle.Checked = true;
                    break;
                case DI_T5E2.ShapeType.Image:
                    radioButtonImage.Checked = true;
                    break;
                case DI_T5E2.ShapeType.Nothing:
                    radioButtonNothing.Checked = true;
                    break;
            }

            checkBoxGradient.Checked = iconLabel1.LinearGradient;
            textBoxCircleWidth.Text = iconLabel1.CircleWidth + "";
            textBoxCrossWidth.Text = iconLabel1.CrossLineWidth + "";
            textBoxSeparation.Text = iconLabel1.Separation + "";
        }

        private void iconLabel1_ShapeClicked(object sender, EventArgs e)
        {
            MessageBox.Show(null,
                "The shape has just been clicked.",
                "ShapeClicked event",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShapeTypeChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                iconLabel1.Shape = (DI_T5E2.ShapeType)rb.Tag;
            }
        }

        private void checkBoxGradient_CheckedChanged(object sender, EventArgs e)
        {
            iconLabel1.LinearGradient = checkBoxGradient.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                iconLabel1.CircleWidth = int.Parse(textBoxCircleWidth.Text);
            }
            catch
            {
                MessageBox.Show(null,
                    "Please specify a valid width for the circle's circumference.",
                    "Invalid value",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                iconLabel1.CrossLineWidth = int.Parse(textBoxCrossWidth.Text);
            }
            catch
            {
                MessageBox.Show(null,
                    "Please specify a valid width for cross lines.",
                    "Invalid value",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                iconLabel1.Separation = int.Parse(textBoxSeparation.Text);
            }
            catch
            {
                MessageBox.Show(null,
                    "Please specify a valid separation between the shape and the text.",
                    "Invalid value",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = iconLabel1.GradientStartingColor;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    iconLabel1.GradientStartingColor = colorDialog.Color;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = iconLabel1.GradientEndingColor;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    iconLabel1.GradientEndingColor = colorDialog.Color;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter =
                    "JPEG (*.jpg; *.jpeg)|*.jpg;*.jpeg"
                    + "|Bitmap (*.bmp)|*.bmp"
                    + "|Portable network graphics (*.png)|*.png"
                    + "|Icon (*.ico)|*.ico"
                    + "|GIF (*.gif)|*.gif"
                    + "|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        iconLabel1.Image = Image.FromFile(openFileDialog.FileName);
                    }
                    catch
                    {
                        MessageBox.Show(null,
                            "The image selected is invalid.",
                            "Invalid image",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
