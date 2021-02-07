using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace graphicsToolset
{
    public partial class Form1 : Form
    {
        ImageTool _imageTool;
        public Form1() => InitializeComponent();
        internal Form1 addMessage(string message)
        {
            _imageTool._stringBuilder.AppendLine(message);
            toolStatus.Text = _imageTool._stringBuilder.ToString();
            return this;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }
        private void openFile_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = @"C:\Users\merle\Desktop\icons\big";
            openFileDialog.ShowDialog();
            _imageTool.openBitmap(openFileDialog.FileName);
        }
        private void inputPictureBox_Click(object sender, EventArgs e) => _imageTool.straightCopy(inputPictureBox);
        private void resultBox01_Click(object sender, EventArgs e) => _imageTool.markBackslash(resultBox01);
        private void resultBox02_Click(object sender, EventArgs e) => _imageTool.explodeSlash(resultBox02);
        private void resultStrip_Click(object sender, EventArgs e) => _imageTool.stripTo(resultStrip);
    }
    internal class ImageTool
    {
        #region alternative color and bitmap
        private class BigColor
        {
            public double R,G,B,A;
            public BigColor(double alpha = 1, double red = 0, double green = 0, double blue = 0)
            {
                A = alpha;
                B = blue;
                G = green;
                R = red;
            }
            public static BigColor operator +(BigColor to, BigColor addend) =>
                new BigColor(Math.Max(addend.A, to.A), addend.R + to.R, addend.G + to.G, addend.B + to.B);
            public static BigColor operator *(BigColor to, double scale) =>
                new BigColor(to.A, to.R * scale, scale * to.G, scale * to.B);
            public BigColor(Color from) : this(from.A, from.R, from.G, from.B) { }
            public double magnitude => R + G + B;
            public Color toColor() =>
                Color.FromArgb(
                    (int)Math.Min(255, Math.Max(0, A)),
                    (int)Math.Min(255, Math.Max(0, R)),
                    (int)Math.Min(255, Math.Max(0, G)),
                    (int)Math.Min(255, Math.Max(0, B)));
        }
        private class BigBitmap
        {
            private readonly int _width = 0, _height = 0;
            public BigColor[,] data;
            public BigBitmap(Bitmap from)
            {
                _width = from.Width;
                _height = from.Height;
                data = new BigColor[_width, _height];
                foreach(int x in Enumerable.Range(0, _width - 1))
                {
                    foreach(int y in Enumerable.Range(0, _height - 1))
                    {
                        data[x, y] = new BigColor(from.GetPixel(x, y));
                    }
                }
            }
            public Bitmap getBitmap()
            {
                Bitmap working = new Bitmap(_width,_height);
                foreach(int x in Enumerable.Range(0, _width - 1))
                {
                    foreach(int y in Enumerable.Range(0, _height - 1))
                    {
                        working.SetPixel(x, y, data[x, y].toColor());
                    }
                }
                return working;
            }
        }
        #endregion
        #region locals
        readonly Form1 _form;
        Bitmap _bitmap;
        private static readonly double[,] _scale = new double[3,3]
        {
            {-1.0, -1.0, -1.0},
            {-1.0, 8.0, -1.0},
            {-1.0, -1.0, -1.0}
        };
        internal readonly StringBuilder _stringBuilder = new StringBuilder();
        private readonly Color[] _strip = new Color[40];
        #endregion
        internal ImageTool(Form connectTo)
        {
            _form = connectTo as Form1;
        }
        internal bool openBitmap(string where)
        {
            if(!(_bitmap is null))
            {
                _bitmap.Dispose();
            }
            _bitmap = (Bitmap)Image.FromFile(where);
            bool worked = !(_bitmap is null);
            const string loaded = "Loaded";
            const string couldnt = "Could not load";
            _form.addMessage($"{(worked ? loaded : couldnt)} {where}");
            return worked;
        }
        /// <summary>
        /// convolves the _scale matrix with _bitmap
        /// INVOKE IN "USING"
        /// </summary>
        /// <returns>the result of the convolution</returns>
        private Bitmap convolveBitmap()
        {
            Bitmap toReturn = new Bitmap(_bitmap);
            using(Bitmap copy = new Bitmap(_bitmap))
            {
                foreach(int x in Enumerable.Range(0, _bitmap.Width - 1))
                {
                    foreach(int y in Enumerable.Range(0, _bitmap.Height - 1))
                    {
                        BigColor accum = new BigColor();
                        if(x > 0 && y > 0)
                        {
                            accum += new BigColor(copy.GetPixel(x - 1, y - 1)) * _scale[0, 0];
                            accum += new BigColor(copy.GetPixel(x, y - 1)) * _scale[1, 0];
                            accum += new BigColor(copy.GetPixel(x + 1, y - 1)) * _scale[2, 0];
                            accum += new BigColor(copy.GetPixel(x - 1, y)) * _scale[0, 1];
                            accum += new BigColor(copy.GetPixel(x, y)) * _scale[1, 1];
                            accum += new BigColor(copy.GetPixel(x + 1, y)) * _scale[2, 1];
                            accum += new BigColor(copy.GetPixel(x - 1, y + 1)) * _scale[0, 2];
                            accum += new BigColor(copy.GetPixel(x, y + 1)) * _scale[1, 2];
                            accum += new BigColor(copy.GetPixel(x + 1, y + 1)) * _scale[2, 2];
                            toReturn.SetPixel(x, y, accum.toColor());
                        }
                    }
                }
            }
            return toReturn;
        }
        #region top service functions (Hint: they receive picture boxes)
        internal void straightCopy(PictureBox to)
        {
            using(Graphics windowGraphics = to.CreateGraphics())
            {
                    windowGraphics.DrawImage(_bitmap, new Rectangle(new Point(0, 0), to.Size));
            }
        }
        internal void markBackslash (PictureBox to)
        {
            using(Graphics windowGraphics = to.CreateGraphics())
            {
                using(Bitmap output = new Bitmap(_bitmap))
                {
                    mark(output, line(new Point(100, 100), new Point(1, 1), 40));
                    windowGraphics.DrawImage(output, new Rectangle(new Point(0, 0), output.Size)); // pictureBox
                }
            }
        }
        internal void explodeSlash(PictureBox to)
        {
            using(Graphics windowGraphics = to.CreateGraphics())
            {
                using(Bitmap convolved = convolveBitmap())
                {
                    windowGraphics.DrawImage(convolved, new Rectangle(new Point(0, 0), to.Size));
                }
            }
        }
        internal void stripTo(PictureBox to)
        {
            using(Graphics windowGraphics = to.CreateGraphics())
            {
                Size size = to.ClientSize;
                int count = 0;
                int colorIndex = 0;
                Color color;
                using(Bitmap outmap = new Bitmap(size.Width, size.Height))
                {
                    foreach(int x in Enumerable.Range(0, size.Width - 1))
                    {
                        if(count % 21 == 20)
                        {
                            color = Color.Black;
                            colorIndex++;
                        }
                        else
                        {
                            color = _strip[colorIndex];
                        }
                        foreach(int y in Enumerable.Range(0, size.Height - 1))
                        {
                            outmap.SetPixel(x, y, color);
                        }
                        count++;
                    }
                    windowGraphics.DrawImage(outmap, new Rectangle(new Point(0, 0), size));
                }
            }
        }
        #endregion
        private System.Collections.Generic.IEnumerable<Point> line(Point start, Point delta, int count)
        {
            for(Point trace = start; 0 < count--; trace.Offset(delta))
            {
                yield return trace;
            }
            yield break;
        }
        private int mark(Bitmap bitmap, System.Collections.Generic.IEnumerable<Point> path)
        {
            int count = 0;
            foreach(Point where in path)
            {
                Color color = bitmap.GetPixel(where.X, where.Y);
                bitmap.SetPixel(where.X, where.Y, Color.FromArgb(color.A, 255 - color.R, 255 - color.G, 255 - color.B));
                _strip[count++] = color;
                if(count >= _strip.Length)
                {
                    break;
                }
            }
            return count;
        }
    }
}
