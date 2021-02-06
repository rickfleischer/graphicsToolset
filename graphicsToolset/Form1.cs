using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace graphicsToolset
{
    public partial class Form1 : Form
    {
        delegate Color munger(Bitmap inmap, int x, int y, int width, int height);
        StringBuilder stringBuilder = new StringBuilder();
        string openPath;
        public Form1()
        {
            InitializeComponent();
        }
        Form1 addMessage(string message)
        {
            stringBuilder.AppendLine(message);
            toolStatus.Text = stringBuilder.ToString();
            return this;
        }
        private void openFile_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = @"C:\Users\merle\Desktop\icons\big";
            openFileDialog.ShowDialog();
            addMessage($"Using file {openFileDialog.FileName}");
            openPath = openFileDialog.FileName; // @"C:\Users\merle\Desktop\icons\big\me.png";// 
        }
        private static void mungEachPixel(Bitmap inmap, Bitmap outmap, munger munger)
        {
            int height = inmap.Height;
            var width = inmap.Width;
            foreach(int x in Enumerable.Range(0, width - 1))
            {
                foreach(int y in Enumerable.Range(0, height - 1))
                {
                    outmap.SetPixel(x, y, munger(inmap, x, y, width, height));
                }
            }
        }
        private Bitmap extremes(Bitmap map, out Color maxColor, out int xMax, out int yMax, out Color minColor, out int xMin, out int yMin)
        {
            bigBitmap big = new bigBitmap(map);
            Bitmap shitsAndGrins = new Bitmap(map);
            xMax = int.MinValue;
            yMax = int.MinValue;
            xMin = int.MaxValue;
            yMin = int.MaxValue;
            int height = map.Height;
            var width = map.Width;
            double minimum = double.MaxValue;
            double maximum = double.MinValue;
            bigColor bigMaxColor=new bigColor();
            bigColor bigMinColor=new bigColor();
            foreach(int x in Enumerable.Range(0, width - 1))
                foreach(int y in Enumerable.Range(0, height - 1))
                {
                    bigColor bigColor = big.data[x,y];
                    double magnitude = bigColor.magnitude;
                    if(magnitude > maximum && magnitude < 250)
                    {
                        maximum = magnitude;
                        bigMaxColor = bigColor;
                        xMax = x;
                        yMax = y;
                    }
                    if(magnitude < minimum && magnitude > 6)
                    {
                        minimum = magnitude;
                        bigMinColor = bigColor;
                        xMin = x;
                        yMin = y;
                    }
                    shitsAndGrins.SetPixel(x, y, bigMaxColor.toColor());
                }
            maxColor = bigMaxColor.toColor();
            minColor = bigMinColor.toColor();
            addMessage($"Max {maxColor} at ({xMax},{yMax}); min {minColor} ({xMin},{yMin})");
            return shitsAndGrins;
        }
        static readonly double[,] scale = new double[3,3]
        {
            {-1.0, -1.0, -1.0},
            {-1.0, 8.0, -1.0},
            {-1.0, -1.0, -1.0}
        };
        class bigColor
        {
            public double R,G,B,A;
            public bigColor(double alpha = 1, double red = 0, double green = 0, double blue = 0)
            {
                A = alpha;
                B = blue;
                G = green;
                R = red;
            }
            public static bigColor operator +(bigColor to, bigColor addend) =>
                new bigColor(Math.Max(addend.A, to.A), addend.R + to.R, addend.G + to.G, addend.B + to.B);
            public static bigColor operator *(bigColor to, double scale) =>
                new bigColor(to.A, to.R * scale, scale * to.G, scale * to.B);
            public bigColor(Color from) : this(from.A, from.R, from.G, from.B) { }
            public double magnitude => R + G + B;
            public Color toColor() =>
                Color.FromArgb(
                    (int)Math.Min(255, Math.Max(0, A)),
                    (int)Math.Min(255, Math.Max(0, R)),
                    (int)Math.Min(255, Math.Max(0, G)),
                    (int)Math.Min(255, Math.Max(0, B)));
        }
        class bigBitmap
        {
            int width=0, height=0;
            public bigColor[,] data;
            public bigBitmap(Bitmap from)
            {
                width = from.Width;
                height = from.Height;
                data = new bigColor[width, height];
                foreach(int x in Enumerable.Range(0, width - 1))
                    foreach(int y in Enumerable.Range(0, height - 1))
                    {
                        data[x, y] = new bigColor(from.GetPixel(x, y));
                    }
            }
            public Bitmap getBitmap()
            {
                Bitmap working = new Bitmap(width,height);
                foreach(int x in Enumerable.Range(0, width - 1))
                    foreach(int y in Enumerable.Range(0, height - 1))
                        working.SetPixel(x, y, data[x, y].toColor());
                return working;
            }
        }
        private static void convolveBitmap(Bitmap bitmap)
        {
            Bitmap copy = new Bitmap(bitmap);
            foreach(int x in Enumerable.Range(0, bitmap.Width - 1))
                foreach(int y in Enumerable.Range(0, bitmap.Height - 1))
                {
                    bigColor accum = new bigColor();
                    if(x > 0 && y > 0)
                    {
                        accum += new bigColor(copy.GetPixel(x - 1, y - 1)) * scale[0, 0];
                        accum += new bigColor(copy.GetPixel(x, y - 1)) * scale[1, 0];
                        accum += new bigColor(copy.GetPixel(x + 1, y - 1)) * scale[2, 0];
                        accum += new bigColor(copy.GetPixel(x - 1, y)) * scale[0, 1];
                        accum += new bigColor(copy.GetPixel(x, y)) * scale[1, 1];
                        accum += new bigColor(copy.GetPixel(x + 1, y)) * scale[2, 1];
                        accum += new bigColor(copy.GetPixel(x - 1, y + 1)) * scale[0, 2];
                        accum += new bigColor(copy.GetPixel(x, y + 1)) * scale[1, 2];
                        accum += new bigColor(copy.GetPixel(x + 1, y + 1)) * scale[2, 2];
                        bitmap.SetPixel(x, y, accum.toColor());
                    }
                }
        }
        private void convolveAll()
        {
            using(Graphics windowGraphics = resultBox02.CreateGraphics())
            {
                Point point = new Point(0, 0);// inputPictureBox.Location;
                Size size = inputPictureBox.Size;
                Rectangle rectangle = new Rectangle(point, size);
                Bitmap bitmap = (Bitmap)Image.FromFile(openPath);
                convolveBitmap(bitmap);
                //windowGraphics.CopyFromScreen(new Point(0, 0), point, size);
                windowGraphics.DrawImage(bitmap, rectangle);
            }
        }
        static bool interested(int x, int y, int width, int height)
        {
            int wDivision = width / 3;
            int hDivision = height / 3;
            if(x < wDivision || x > 2 * wDivision) return false;
            if(y < hDivision || y > 2 * hDivision) return false;
            return (x == y);
        }
        private static Color invertBackslash(Bitmap inmap, int x, int y, int width, int height)
        {
            Color pixel = inmap.GetPixel(x, y);
            if(interested(x, y, width, height))
            {
                pixel = Color.FromArgb(alpha: 255, red: 255 - pixel.R, green: 255 - pixel.G, blue: 255 - pixel.B);
            }
            else
                pixel = Color.FromArgb(alpha: 255, red: pixel.R, green: pixel.G, blue: pixel.B);
            return pixel;
        }
        private void straightCopy(object sender, EventArgs e)
        {
            using(Graphics windowGraphics = inputPictureBox.CreateGraphics())
            {
                Point point = new Point(0, 0);
                Size size = inputPictureBox.Size;
                Rectangle pictureBox = new Rectangle(point, size);
                Bitmap bitmap = (Bitmap)Image.FromFile(openPath);
                trial(bitmap);
                Rectangle imageBox = new Rectangle(point, bitmap.Size);
                windowGraphics.DrawImage(bitmap, imageBox); // pictureBox
            }
        }
        private void markBackslash(object sender, EventArgs e)
        {
            using(Graphics windowGraphics = resultBox01.CreateGraphics())
            {
                Point point = new Point(0, 0);// inputPictureBox.Location;
                Size size = inputPictureBox.Size;
                Rectangle rectangle = new Rectangle(point, size);
                Bitmap bitmap = (Bitmap)Image.FromFile(openPath);
                bitmap = extremes(bitmap, out Color maxColor, out int xMax, out int yMax, out Color miinColor, out int xMin, out int yMin);
                //mungEachPixel(bitmap, bitmap, invertBackslash);
                //windowGraphics.CopyFromScreen(new Point(0, 0), point, size);
                windowGraphics.DrawImage(bitmap, rectangle);
            }
        }
        private void explodeSlash(object sender, EventArgs e)
        {
            convolveAll();
            //using(Graphics windowGraphics = resultBox02.CreateGraphics())
            //{
            //    Point point = new Point(0, 0);// inputPictureBox.Location;
            //    Size size = inputPictureBox.Size;
            //    Rectangle rectangle = new Rectangle(point, size);
            //    Bitmap inmap = (Bitmap)Image.FromFile(openPath);
            //    Bitmap outmap = new Bitmap(size.Width,size.Height);
            //    mungEachPixel(inmap, outmap, invertBackslash);
            //    windowGraphics.DrawImage(outmap, rectangle);
            //}
        }
        private void inputPictureBox_Click(object sender, EventArgs e)
        {
            straightCopy(sender, e);
        }
        private void resultBox01_Click(object sender, EventArgs e)
        {
            markBackslash(sender, e);
        }
        private void resultBox02_Click(object sender, EventArgs e)
        {
            explodeSlash(sender, e);
        }
        Color[] strip = new Color[40]
        {
            Color.Red,Color.Green,Color.Blue,
            Color.Red,Color.Green,Color.Brown,
            Color.Red,Color.Green,Color.Blue,
            Color.Red,Color.Green,Color.Blue,
            Color.Red,Color.Green,Color.Aquamarine,
            Color.Red,Color.Green,Color.Blue,
            Color.Red,Color.Green,Color.Blue,
            Color.Red,Color.Green,Color.DarkBlue,
            Color.Red,Color.Green,Color.Blue,
            Color.Red,Color.Green,Color.Blue,
            Color.Red,Color.Green,Color.Blue,
            Color.Red,Color.Green,Color.Blue,
            Color.Red,Color.Green,Color.Blue,
            Color.Red
        };
        private void resultStrip_Click(object sender, EventArgs e)
        {
            using(Graphics windowGraphics = resultStrip.CreateGraphics())
            {
                Size size = resultStrip.ClientSize;
                Bitmap outmap = new Bitmap(size.Width,size.Height);
                int count = 0;
                int colorIndex = 0;
                Color color;
                foreach(int x in Enumerable.Range(0, size.Width - 1))
                {
                    if(count % 21 == 20)
                    {
                        color = Color.Black;
                        colorIndex++;
                    }
                    else 
                    {
                        color = strip[colorIndex];
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
        void trial(Bitmap bitmap)
        {
            extract(bitmap, line(new Point(100, 100), new Point(1, 1), 40));
        }
        System.Collections.Generic.IEnumerable<Point> line(Point start, Point delta, int count)
        {
            for(Point trace = start; 0 < count--; trace.Offset(delta))
            {
                yield return trace;
            }
            yield break;
        }
        int extract(Bitmap bitmap, System.Collections.Generic.IEnumerable<Point> path)
        {
            int count = 0;
            foreach(Point where in path)
            {
                Color color = bitmap.GetPixel(where.X, where.Y);
                bitmap.SetPixel(where.X, where.Y, Color.FromArgb(color.A, 255 - color.R, 255 - color.G, 255 - color.B));
                strip[count++] = color;
                if(count >= strip.Length)
                {
                    break;
                }
            }
            return count;
        }
    }
}
