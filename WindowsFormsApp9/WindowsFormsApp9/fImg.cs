using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class fImg : Form
    {
        Point curP;
        public fImg()
        {
            InitializeComponent();
            tDraw.Interval = 1;
        }

        private void fImg_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void fImg_Paint(object sender, PaintEventArgs e)
        {
            pbImage.Image = Form1.i_edit.Image;
        }
        private void pbImage_MouseMove(object sender, MouseEventArgs e)
        {
            curP = Form1.i_edit.convCoords(pbImage, e.X, e.Y);
            txtX.Text = curP.X.ToString();
            txtY.Text = curP.Y.ToString();
        }

        private void fImg_Load(object sender, EventArgs e)
        {
            Form1.isFieldOpened = false;
        }
        public void savePbImage(string p)
        {
            try
            {
                pbImage.Image.Save(p, getFormat(p));
            }
            catch
            {
                MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public ImageFormat getFormat(string p)
        {
            string ext = Path.GetExtension(p);
            switch (ext)
            {
                case ".jpg":
                    return ImageFormat.Jpeg;
                case ".jpeg":
                    return ImageFormat.Jpeg;
                case ".png":
                    return ImageFormat.Png;
                default:
                    return ImageFormat.Jpeg;
            }
        }

        private void tDraw_Tick(object sender, EventArgs e)
        {
            int bRad = Form1.i_edit.BrushRadius;
            for (int i = curP.X - bRad; i <= curP.X + bRad; i++)
            {
                for (int j = curP.Y - bRad; j <= curP.Y + bRad; j++)
                {
                    double dist = Math.Sqrt(Math.Pow(i - curP.X, 2) + Math.Pow(j - curP.Y, 2));
                    if (dist <= bRad && i >= 0 && j >= 0 && i < Form1.i_edit.Image.Width && j < Form1.i_edit.Image.Height)
                        Form1.i_edit.Image.SetPixel(i, j, Form1.i_edit.BrushColor);
                }
            }
            Invalidate();
        }

        private void pbImage_MouseDown(object sender, MouseEventArgs e)
        {
            tDraw.Start();
        }

        private void pbImage_MouseUp(object sender, MouseEventArgs e)
        {
            tDraw.Stop();
        }
    }
}
