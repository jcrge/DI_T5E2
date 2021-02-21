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

namespace DI_T5E2
{
    public enum ShapeType { Nothing, Cross, Circle, Image }

    public partial class IconLabel : Control
    {
        private Rectangle ShapeArea = new Rectangle(0, 0, 0, 0);

        private ShapeType shape;

        [Category("Appearance")]
        [Description("The shape that is shown next to the text.")]
        public ShapeType Shape
        {
            get => shape;
            set
            {
                if (!Enum.IsDefined(typeof(ShapeType), value))
                {
                    throw new InvalidEnumArgumentException();
                }

                shape = value;
                Refresh();
            }
        }

        private int circleWidth;

        [Category("Appearance")]
        [Description("The width of the circle icon.")]
        public int CircleWidth
        {
            get => circleWidth;
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentOutOfRangeException();
                }
                circleWidth = value;
                Refresh();
            }
        }

        private int crossWidth;

        [Category("Appearance")]
        [Description("The width of the cross lines.")]
        public int CrossLineWidth
        {
            get => crossWidth;
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentOutOfRangeException();
                }
                crossWidth = value;
                Refresh();
            }
        }

        private Image image;

        [Category("Appearance")]
        [Description("Image to be shown when the shape type is set to 'Image'.")]
        public Image Image
        {
            get => image;
            set
            {
                image = value;
                Refresh();
            }
        }

        private int separation;

        [Category("Appearance")]
        [Description("The number of pixels of separation between the icon and the text.")]
        public int Separation
        {
            get => separation;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                separation = value;
                Refresh();
            }
        }

        private Color gradientStartingColor;

        [Category("Appearance")]
        [Description("The starting color for the linear gradient.")]
        public Color GradientStartingColor
        {
            get => gradientStartingColor;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                gradientStartingColor = value;
                Refresh();
            }
        }

        private Color gradientEndingColor;

        [Category("Appearance")]
        [Description("The ending color for the linear gradient.")]
        public Color GradientEndingColor
        {
            get => gradientEndingColor;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                gradientEndingColor = value;
                Refresh();
            }
        }

        private bool linearGradient;

        [Category("Appearance")]
        [Description("Whether to have a linear gradient as background or not.")]
        public bool LinearGradient
        {
            get => linearGradient;
            set
            {
                linearGradient = value;
                Refresh();
            }
        }

        [Category("Action")]
        [Description("The shape has been clicked.")]
        public event EventHandler ShapeClicked;

        public IconLabel()
        {
            InitializeComponent();
            CircleWidth = 1;
            CrossLineWidth = 1;
            Separation = 2;
            LinearGradient = false;
            GradientStartingColor = Color.White;
            GradientEndingColor = Color.White;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Refresh();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnClick(e);

            if (Shape != ShapeType.Nothing)
            {
                if (ShapeArea.X <= e.X && e.X <= ShapeArea.X + ShapeArea.Width)
                {
                    if (ShapeArea.Y <= e.Y && e.Y <= ShapeArea.Y + ShapeArea.Height)
                    {
                        ShapeClicked?.Invoke(this, new EventArgs());
                    }
                }
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Size textSize = g.MeasureString(Text, Font).ToSize();

            ShapeType effectiveShape =
                Shape == ShapeType.Image && Image == null
                ? ShapeType.Nothing
                : Shape;

            // En caso de querer dibujar la cruz, este valor indica cuántos píxeles se
            // sobresale el dibujo hacia cada lado y en cada eje debido al efecto del
            // grosor. Situando el punto superior izquierdo en
            // (crossProtrusion, crossProtrusion), el rectángulo más pequeño que contiene
            // el dibujo completo de la cruz empieza en (0, 0).
            int crossProtrusion = (int)Math.Ceiling(Math.Sqrt(2) * CrossLineWidth / 4);

            int textX = 0;
            switch (effectiveShape)
            {
                case ShapeType.Circle:
                    // Se suma todo el CircleWidth porque el ancho crece la mitad por
                    // cada lado con respecto al rectángulo de la elipsis.
                    Height = CircleWidth + Font.Height;
                    textX = CircleWidth + Font.Height + Separation;
                    ShapeArea = new Rectangle(0, 0, Height, Height);
                    break;

                case ShapeType.Cross:
                    Height = Font.Height + crossProtrusion*4;
                    textX = Height + Separation;
                    ShapeArea = new Rectangle(0, 0, Height, Height);
                    break;

                case ShapeType.Image:
                    Height = Math.Max(Image.Height, Font.Height);
                    textX = Image.Width + Separation;
                    ShapeArea = new Rectangle(
                        0, (Height - Image.Height)/2, Image.Width, Image.Height);
                    break;
            }
            Width = textX + textSize.Width;

            if (LinearGradient)
            {
                using (Brush brush = new LinearGradientBrush(new Point(0, 0),
                    new Point(Width, Height), GradientStartingColor, GradientEndingColor))
                {
                    pe.Graphics.FillRectangle(brush, 0, 0, Width, Height);
                }
            }

            switch (effectiveShape)
            {
                case ShapeType.Circle:
                    using (Pen pen = new Pen(Color.Green, CircleWidth))
                    {
                        // En los apuntes pones CircleWidth en vez de CircleWidth/2 como
                        // valores de x e y. Esto es un error, porque el grosor crece por
                        // igual tanto hacia fuera de la elipsis como hacia dentro con
                        // respecto a la figura original de grosor 1. Utilizando
                        // CircleWidth/2 nos aseguramos de que la elipsis no se vaya
                        // metiendo más y más hacia dentro conforme crece el grosor.
                        g.DrawEllipse(pen, CircleWidth/2, CircleWidth/2, Font.Height,
                            Font.Height);
                    }
                    break;

                case ShapeType.Cross:
                    using (Pen pen = new Pen(Color.Red, CrossLineWidth))
                    {
                        g.DrawLine(pen,
                            crossProtrusion,
                            crossProtrusion,
                            2 * crossProtrusion + Font.Height + crossProtrusion,
                            2 * crossProtrusion + Font.Height + crossProtrusion);
                        g.DrawLine(pen,
                            crossProtrusion,
                            2 * crossProtrusion + Font.Height + crossProtrusion,
                            2 * crossProtrusion + Font.Height + crossProtrusion,
                            crossProtrusion);
                    }
                    break;

                case ShapeType.Image:
                    g.DrawImage(image, new Point(0, 0));
                    break;
            }

            using (Brush brush = new SolidBrush(ForeColor))
            {
                g.DrawString(Text, Font, brush, textX, Height/2 - textSize.Height/2);
            }
        }
    }
}
