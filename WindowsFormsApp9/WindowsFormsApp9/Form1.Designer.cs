
namespace WindowsFormsApp9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_btnLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_btnCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_btnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tslTool = new System.Windows.Forms.ToolStripStatusLabel();
            this.sfdSaveImage = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.cdColor = new System.Windows.Forms.ColorDialog();
            this.pMainPanel = new System.Windows.Forms.Panel();
            this.gbBrush = new System.Windows.Forms.GroupBox();
            this.nudRadiusNumber = new System.Windows.Forms.NumericUpDown();
            this.pColor = new System.Windows.Forms.Panel();
            this.lRadius = new System.Windows.Forms.Label();
            this.lColor = new System.Windows.Forms.Label();
            this.msMenu.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.pMainPanel.SuspendLayout();
            this.gbBrush.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadiusNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(787, 24);
            this.msMenu.TabIndex = 1;
            this.msMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_btnLoad,
            this.ms_btnSave,
            this.ms_btnCreate});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // ms_btnLoad
            // 
            this.ms_btnLoad.Name = "ms_btnLoad";
            this.ms_btnLoad.Size = new System.Drawing.Size(180, 22);
            this.ms_btnLoad.Text = "Загрузить";
            this.ms_btnLoad.Click += new System.EventHandler(this.ms_btnLoad_Click);
            // 
            // ms_btnSave
            // 
            this.ms_btnSave.Name = "ms_btnSave";
            this.ms_btnSave.Size = new System.Drawing.Size(180, 22);
            this.ms_btnSave.Text = "Сохранить как";
            this.ms_btnSave.Click += new System.EventHandler(this.ms_btnSave_Click);
            // 
            // ms_btnCreate
            // 
            this.ms_btnCreate.Name = "ms_btnCreate";
            this.ms_btnCreate.Size = new System.Drawing.Size(180, 22);
            this.ms_btnCreate.Text = "Создать";
            this.ms_btnCreate.Click += new System.EventHandler(this.ms_btnCreate_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_btnOpen,
            this.ms_btnClose});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // ms_btnOpen
            // 
            this.ms_btnOpen.Name = "ms_btnOpen";
            this.ms_btnOpen.Size = new System.Drawing.Size(151, 22);
            this.ms_btnOpen.Text = "Открыть окно";
            // 
            // ms_btnClose
            // 
            this.ms_btnClose.Name = "ms_btnClose";
            this.ms_btnClose.Size = new System.Drawing.Size(151, 22);
            this.ms_btnClose.Text = "Закрыть окно";
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTool});
            this.ssStatus.Location = new System.Drawing.Point(0, 421);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ssStatus.Size = new System.Drawing.Size(787, 22);
            this.ssStatus.TabIndex = 2;
            this.ssStatus.Text = "statusStrip1";
            // 
            // tslTool
            // 
            this.tslTool.Name = "tslTool";
            this.tslTool.Size = new System.Drawing.Size(74, 17);
            this.tslTool.Text = "Инструмент";
            // 
            // ofdOpenImage
            // 
            this.ofdOpenImage.FileName = "openFileDialog1";
            // 
            // pMainPanel
            // 
            this.pMainPanel.Controls.Add(this.gbBrush);
            this.pMainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMainPanel.Location = new System.Drawing.Point(0, 24);
            this.pMainPanel.Name = "pMainPanel";
            this.pMainPanel.Size = new System.Drawing.Size(188, 397);
            this.pMainPanel.TabIndex = 3;
            // 
            // gbBrush
            // 
            this.gbBrush.Controls.Add(this.nudRadiusNumber);
            this.gbBrush.Controls.Add(this.pColor);
            this.gbBrush.Controls.Add(this.lRadius);
            this.gbBrush.Controls.Add(this.lColor);
            this.gbBrush.Location = new System.Drawing.Point(3, 3);
            this.gbBrush.Name = "gbBrush";
            this.gbBrush.Size = new System.Drawing.Size(182, 117);
            this.gbBrush.TabIndex = 0;
            this.gbBrush.TabStop = false;
            this.gbBrush.Text = "Кисть";
            // 
            // nudRadiusNumber
            // 
            this.nudRadiusNumber.Location = new System.Drawing.Point(13, 87);
            this.nudRadiusNumber.Name = "nudRadiusNumber";
            this.nudRadiusNumber.Size = new System.Drawing.Size(77, 20);
            this.nudRadiusNumber.TabIndex = 3;
            this.nudRadiusNumber.ValueChanged += new System.EventHandler(this.nudRadiusNumber_ValueChanged);
            // 
            // pColor
            // 
            this.pColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pColor.Location = new System.Drawing.Point(13, 36);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(77, 23);
            this.pColor.TabIndex = 2;
            this.pColor.Click += new System.EventHandler(this.pColor_Click);
            // 
            // lRadius
            // 
            this.lRadius.AutoSize = true;
            this.lRadius.Location = new System.Drawing.Point(10, 71);
            this.lRadius.Name = "lRadius";
            this.lRadius.Size = new System.Drawing.Size(43, 13);
            this.lRadius.TabIndex = 1;
            this.lRadius.Text = "Радиус";
            // 
            // lColor
            // 
            this.lColor.AutoSize = true;
            this.lColor.Location = new System.Drawing.Point(10, 20);
            this.lColor.Name = "lColor";
            this.lColor.Size = new System.Drawing.Size(32, 13);
            this.lColor.TabIndex = 0;
            this.lColor.Text = "Цвет";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 443);
            this.Controls.Add(this.pMainPanel);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.msMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.Name = "Form1";
            this.Text = "Граф. Редактор";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.pMainPanel.ResumeLayout(false);
            this.gbBrush.ResumeLayout(false);
            this.gbBrush.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadiusNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ms_btnLoad;
        private System.Windows.Forms.ToolStripMenuItem ms_btnSave;
        private System.Windows.Forms.ToolStripMenuItem ms_btnCreate;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ms_btnOpen;
        private System.Windows.Forms.ToolStripMenuItem ms_btnClose;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tslTool;
        private System.Windows.Forms.SaveFileDialog sfdSaveImage;
        private System.Windows.Forms.OpenFileDialog ofdOpenImage;
        private System.Windows.Forms.ColorDialog cdColor;
        private System.Windows.Forms.Panel pMainPanel;
        private System.Windows.Forms.GroupBox gbBrush;
        private System.Windows.Forms.Label lRadius;
        private System.Windows.Forms.Label lColor;
        private System.Windows.Forms.NumericUpDown nudRadiusNumber;
        private System.Windows.Forms.Panel pColor;
    }
}

