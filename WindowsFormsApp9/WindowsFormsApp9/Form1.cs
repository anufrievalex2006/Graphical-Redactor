using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public struct crNewDialogRes
        {
            public int w, h;
            public bool isReady;
        }

        fImg imgField = null;
        public static imgEditor i_edit = new imgEditor();
        public static crNewDialogRes digRes = new crNewDialogRes();
        public static bool isFieldOpened = false;
        public Form1()
        {
            InitializeComponent();
            pColor.BackColor = Color.White;
            createField();
            ofdOpenImage.Filter = "Все файлы|*.png; *.jpg; *.jpeg";
            sfdSaveImage.Filter = "Все файлы|*.png; *.jpg; *.jpeg";
        }
        public void createField()
        {
            imgField = new fImg();
            imgField.MdiParent = this;
            imgField.Show();
            isFieldOpened = true;
        }

        private void pColor_Click(object sender, EventArgs e)
        {
            if (cdColor.ShowDialog() == DialogResult.OK)
            {
                pColor.BackColor = cdColor.Color;
                i_edit.setColor(cdColor.Color);
            }
        }

        private void ms_btnLoad_Click(object sender, EventArgs e)
        {
            if (ofdOpenImage.ShowDialog() == DialogResult.OK)
            {
                string path = ofdOpenImage.FileName;
                i_edit.loadImage(path);
                imgField.Refresh();
            }
        }

        private void ms_btnCreate_Click(object sender, EventArgs e)
        {
            fNewBitmap fnb = new fNewBitmap();
            fnb.ShowDialog();
            if (digRes.isReady)
            {
                i_edit = new imgEditor(digRes.w, digRes.h);
                imgField.Refresh();
                pColor.BackColor = Color.White;
                nudRadiusNumber.Value = 30;
            }
        }

        private void ms_btnSave_Click(object sender, EventArgs e)
        {
            if (sfdSaveImage.ShowDialog() == DialogResult.OK)
                imgField.savePbImage(sfdSaveImage.FileName);
        }

        private void nudRadiusNumber_ValueChanged(object sender, EventArgs e)
        {
            i_edit.setRadius(Convert.ToInt32(nudRadiusNumber.Value));
        }
    }
}
