namespace RadioCSharp
{
    partial class MainRadio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainRadio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelBuffered = new ns1.BunifuCustomLabel();
            this.bunifuCircleProgressbar1 = new ns1.BunifuCircleProgressbar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton2 = new ns1.BunifuImageButton();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.btnBack = new ns1.BunifuImageButton();
            this.btnNext = new ns1.BunifuImageButton();
            this.btnAddUrl = new ns1.BunifuImageButton();
            this.btnClear = new ns1.BunifuImageButton();
            this.btnOpenFile = new ns1.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMini = new ns1.BunifuImageButton();
            this.lblTitle = new ns1.BunifuCustomLabel();
            this.btnClose = new ns1.BunifuImageButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPause = new ns1.BunifuImageButton();
            this.bunifuSlider1 = new ns1.BunifuSlider();
            this.btnStop = new ns1.BunifuImageButton();
            this.btnMute = new ns1.BunifuImageButton();
            this.btnPlay = new ns1.BunifuImageButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl2 = new ns1.BunifuDragControl(this.components);
            this.recordingPanelVLC1 = new RadioCSharp.RecordingPanelVLC();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFile)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panel1.Controls.Add(this.recordingPanelVLC1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnAddUrl);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 423);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(120)))), ((int)(((byte)(12)))));
            this.panel6.Controls.Add(this.labelBuffered);
            this.panel6.Controls.Add(this.bunifuCircleProgressbar1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 373);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(51, 50);
            this.panel6.TabIndex = 2;
            // 
            // labelBuffered
            // 
            this.labelBuffered.AutoSize = true;
            this.labelBuffered.BackColor = System.Drawing.Color.Transparent;
            this.labelBuffered.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.labelBuffered.ForeColor = System.Drawing.Color.White;
            this.labelBuffered.Location = new System.Drawing.Point(6, 37);
            this.labelBuffered.Name = "labelBuffered";
            this.labelBuffered.Size = new System.Drawing.Size(41, 12);
            this.labelBuffered.TabIndex = 13;
            this.labelBuffered.Text = "00:00:00";
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 3;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(1, -4);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(47, 47);
            this.bunifuCircleProgressbar1.TabIndex = 14;
            this.bunifuCircleProgressbar1.Value = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(120)))), ((int)(((byte)(12)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(51, 42);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(8, 313);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(32, 24);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(8, 343);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(32, 24);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageActive = null;
            this.btnBack.Location = new System.Drawing.Point(8, 177);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 24);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.btnBack.Zoom = 10;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageActive = null;
            this.btnNext.Location = new System.Drawing.Point(8, 151);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(32, 24);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNext.TabIndex = 1;
            this.btnNext.TabStop = false;
            this.btnNext.Zoom = 10;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddUrl
            // 
            this.btnAddUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnAddUrl.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUrl.Image")));
            this.btnAddUrl.ImageActive = null;
            this.btnAddUrl.Location = new System.Drawing.Point(8, 108);
            this.btnAddUrl.Name = "btnAddUrl";
            this.btnAddUrl.Size = new System.Drawing.Size(32, 24);
            this.btnAddUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddUrl.TabIndex = 1;
            this.btnAddUrl.TabStop = false;
            this.btnAddUrl.Zoom = 10;
            this.btnAddUrl.Click += new System.EventHandler(this.btnAddUrl_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageActive = null;
            this.btnClear.Location = new System.Drawing.Point(8, 82);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(32, 24);
            this.btnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClear.TabIndex = 1;
            this.btnClear.TabStop = false;
            this.btnClear.Zoom = 10;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.Image")));
            this.btnOpenFile.ImageActive = null;
            this.btnOpenFile.Location = new System.Drawing.Point(8, 56);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(32, 24);
            this.btnOpenFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.TabStop = false;
            this.btnOpenFile.Zoom = 10;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.panel3.Controls.Add(this.btnMini);
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(51, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 42);
            this.panel3.TabIndex = 1;
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.Image = ((System.Drawing.Image)(resources.GetObject("btnMini.Image")));
            this.btnMini.ImageActive = null;
            this.btnMini.Location = new System.Drawing.Point(150, 14);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(35, 32);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMini.TabIndex = 0;
            this.btnMini.TabStop = false;
            this.btnMini.Zoom = 10;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(6, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(179, 20);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "CSRadio ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(183, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 32);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panel4.Controls.Add(this.btnPause);
            this.panel4.Controls.Add(this.bunifuSlider1);
            this.panel4.Controls.Add(this.btnStop);
            this.panel4.Controls.Add(this.btnMute);
            this.panel4.Controls.Add(this.btnPlay);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(51, 373);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 50);
            this.panel4.TabIndex = 2;
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.ImageActive = null;
            this.btnPause.Location = new System.Drawing.Point(9, 12);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(28, 26);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPause.TabIndex = 0;
            this.btnPause.TabStop = false;
            this.btnPause.Zoom = 10;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // bunifuSlider1
            // 
            this.bunifuSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider1.BorderRadius = 5;
            this.bunifuSlider1.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.bunifuSlider1.Location = new System.Drawing.Point(147, 12);
            this.bunifuSlider1.MaximumValue = 100;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(71, 30);
            this.bunifuSlider1.TabIndex = 1;
            this.bunifuSlider1.Value = 100;
            this.bunifuSlider1.ValueChanged += new System.EventHandler(this.bunifuSlider1_ValueChanged);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageActive = null;
            this.btnStop.Location = new System.Drawing.Point(65, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(30, 26);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStop.TabIndex = 0;
            this.btnStop.TabStop = false;
            this.btnStop.Zoom = 10;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnMute
            // 
            this.btnMute.BackColor = System.Drawing.Color.Transparent;
            this.btnMute.Image = ((System.Drawing.Image)(resources.GetObject("btnMute.Image")));
            this.btnMute.ImageActive = null;
            this.btnMute.Location = new System.Drawing.Point(113, 12);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(30, 26);
            this.btnMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMute.TabIndex = 0;
            this.btnMute.TabStop = false;
            this.btnMute.Zoom = 10;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageActive = null;
            this.btnPlay.Location = new System.Drawing.Point(37, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(30, 26);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlay.TabIndex = 0;
            this.btnPlay.TabStop = false;
            this.btnPlay.Zoom = 10;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(51, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(224, 331);
            this.panel5.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.bunifuCustomLabel2);
            this.panel7.Controls.Add(this.bunifuCustomLabel1);
            this.panel7.Controls.Add(this.listBox1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(224, 331);
            this.panel7.TabIndex = 13;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(118)))), ((int)(((byte)(10)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(7, 27);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(161, 16);
            this.bunifuCustomLabel2.TabIndex = 13;
            this.bunifuCustomLabel2.Text = "Radios On Your Windows";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(6, 6);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(95, 20);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "PLAYLISTS";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(224, 280);
            this.listBox1.TabIndex = 12;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel3;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lblTitle;
            this.bunifuDragControl2.Vertical = true;
            // 
            // recordingPanelVLC1
            // 
            this.recordingPanelVLC1.Location = new System.Drawing.Point(6, 219);
            this.recordingPanelVLC1.Name = "recordingPanelVLC1";
            this.recordingPanelVLC1.Size = new System.Drawing.Size(39, 56);
            this.recordingPanelVLC1.TabIndex = 14;
            // 
            // MainRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 423);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainRadio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFile)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuImageButton btnOpenFile;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private ns1.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuImageButton btnClose;
        private ns1.BunifuImageButton btnMini;
        private ns1.BunifuImageButton btnClear;
        private ns1.BunifuImageButton btnStop;
        private ns1.BunifuImageButton btnPlay;
        private ns1.BunifuSlider bunifuSlider1;
        private ns1.BunifuImageButton btnMute;
        private ns1.BunifuImageButton btnPause;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ListBox listBox1;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuImageButton btnBack;
        private ns1.BunifuImageButton btnNext;
        private ns1.BunifuImageButton bunifuImageButton2;
        private ns1.BunifuImageButton bunifuImageButton1;
        private ns1.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private ns1.BunifuCustomLabel labelBuffered;
        private ns1.BunifuImageButton btnAddUrl;
        private ns1.BunifuCustomLabel lblTitle;
        private System.Windows.Forms.Timer timer1;
        private ns1.BunifuDragControl bunifuDragControl2;
        private RecordingPanelVLC recordingPanelVLC1;
    }
}