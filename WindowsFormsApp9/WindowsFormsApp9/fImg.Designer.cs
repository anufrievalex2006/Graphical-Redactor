
namespace WindowsFormsApp9
{
    partial class fImg
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
            this.components = new System.ComponentModel.Container();
            this.lX = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lY = new System.Windows.Forms.Label();
            this.tDraw = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lX
            // 
            this.lX.AutoSize = true;
            this.lX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lX.Location = new System.Drawing.Point(69, 52);
            this.lX.Name = "lX";
            this.lX.Size = new System.Drawing.Size(21, 20);
            this.lX.TabIndex = 1;
            this.lX.Text = "X";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(28, 75);
            this.txtX.Name = "txtX";
            this.txtX.ReadOnly = true;
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 2;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(28, 180);
            this.txtY.Name = "txtY";
            this.txtY.ReadOnly = true;
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 4;
            // 
            // lY
            // 
            this.lY.AutoSize = true;
            this.lY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lY.Location = new System.Drawing.Point(69, 157);
            this.lY.Name = "lY";
            this.lY.Size = new System.Drawing.Size(21, 20);
            this.lY.TabIndex = 3;
            this.lY.Text = "Y";
            // 
            // tDraw
            // 
            this.tDraw.Interval = 1;
            this.tDraw.Tick += new System.EventHandler(this.tDraw_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbImage);
            this.panel1.Location = new System.Drawing.Point(134, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 369);
            this.panel1.TabIndex = 5;
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImage.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbImage.Location = new System.Drawing.Point(-1, -1);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(437, 369);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            this.pbImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseDown);
            this.pbImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseMove);
            this.pbImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseUp);
            // 
            // fImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 393);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.lY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lX);
            this.Name = "fImg";
            this.Text = "Холст 1";
            this.Load += new System.EventHandler(this.fImg_Load);
            this.Shown += new System.EventHandler(this.fImg_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.fImg_Paint);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lX;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lY;
        private System.Windows.Forms.Timer tDraw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbImage;
    }
}