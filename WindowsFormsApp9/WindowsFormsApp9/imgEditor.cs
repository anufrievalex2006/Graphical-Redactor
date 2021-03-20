using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public class imgEditor
    {
        Bitmap img = null;
        Color bColor = Color.White;
        int bRad;
        public Bitmap Image { get => img; }
        public Color BrushColor { get => bColor; }
        public int BrushRadius { get => bRad; }
        public imgEditor()
        {
            img = new Bitmap(1024, 1024);
            for (int i = 0; i < 1024; i++)
            {
                for (int j = 0; j < 1024; j++)
                    img.SetPixel(i, j, Color.FromArgb(255, 255, 255, 255));
            }
            bRad = 30;
        }
        public imgEditor(int w, int h)
        {
            img = new Bitmap(w, h);
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                    img.SetPixel(i, j, Color.FromArgb(255, 255, 255, 255));
            }
            bRad = 30;
        }
        public Point convCoords(PictureBox p, int x, int y)
        {
            int pH = p.ClientSize.Height, pW = p.ClientSize.Width, iH = p.Image.Height, iW = p.Image.Width;
            Point res = new Point(x, y);
            float pAspect = pW / (float)pH, iAspect = iW / (float)iH;
            if (pAspect > iAspect)
            {
                res.Y = (int)(iH * y / (float)pH);
                float scaledW = iW * pH / iH, dx = (pW - scaledW) / 2;
                res.X = (int)((x - dx) * iH / (float)pH);
            }
            else
            {
                res.X = (int)(iW * x / (float)pW);
                float scaledH = iH * pW / iW, dy = (pH - scaledH) / 2;
                res.Y = (int)((y - dy) * iW / (float)pW);
            }
            if (res.X < 0) res.X = 0;
            if (res.Y < 0) res.Y = 0;
            if (res.X >= img.Width) res.X = img.Width - 1;
            if (res.Y >= img.Height) res.Y = img.Height - 1;
            return res;
        }
        public void loadImage(string p)
        {
            img = new Bitmap(p);
        }
        public void setColor(Color c)
        {
            bColor = c;
        }
        public void setRadius(int rad)
        {
            bRad = rad;
        }
    }
}
