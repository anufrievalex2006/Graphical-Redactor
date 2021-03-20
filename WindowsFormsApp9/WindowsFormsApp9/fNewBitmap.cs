﻿using System;
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
    public partial class fNewBitmap : Form
    {
        public fNewBitmap()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            Form1.digRes.isReady = false;
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            Form1.digRes.w = Convert.ToInt32(nudWidth.Value);
            Form1.digRes.h = Convert.ToInt32(nudHeight.Value);
            Form1.digRes.isReady = true;
            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
