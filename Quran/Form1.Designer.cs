namespace Quran
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerPlayback = new System.Windows.Forms.Timer(this.components);
            this.comboBoxAya = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxSearchIn = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxReciter = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.comboBoxPage = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrevAya = new System.Windows.Forms.Button();
            this.btnNextAya = new System.Windows.Forms.Button();
            this.btnPrevSura = new System.Windows.Forms.Button();
            this.btnNextSura = new System.Windows.Forms.Button();
            this.comboBoxSura = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerLoadDocument = new System.Windows.Forms.Timer(this.components);
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            this.SuspendLayout();
            // 
            // timerPlayback
            // 
            this.timerPlayback.Interval = 1;
            this.timerPlayback.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBoxAya
            // 
            this.comboBoxAya.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.comboBoxAya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAya.ForeColor = System.Drawing.Color.Black;
            this.comboBoxAya.FormattingEnabled = true;
            this.comboBoxAya.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBoxAya.Location = new System.Drawing.Point(22, 18);
            this.comboBoxAya.Name = "comboBoxAya";
            this.comboBoxAya.Size = new System.Drawing.Size(48, 21);
            this.comboBoxAya.TabIndex = 1;
            this.comboBoxAya.Text = "1";
            this.comboBoxAya.SelectedIndexChanged += new System.EventHandler(this.comboBoxAya_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.label4.Location = new System.Drawing.Point(22, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Aya:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 33);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(42, 46);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 29);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10, 5, 5, 10);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(1280, 662);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 19;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxColor);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(10, 315);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(185, 81);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tools";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.comboBoxColor.DisplayMember = "0";
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Green",
            "Rose",
            "Blue",
            "Gray"});
            this.comboBoxColor.Location = new System.Drawing.Point(49, 17);
            this.comboBoxColor.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(126, 21);
            this.comboBoxColor.TabIndex = 0;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.label6.Location = new System.Drawing.Point(5, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Color:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.comboBoxSearchIn);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBoxSearch);
            this.groupBox3.Controls.Add(this.buttonSearch);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(10, 179);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(185, 136);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.label8.Location = new System.Drawing.Point(9, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Search in:";
            // 
            // comboBoxSearchIn
            // 
            this.comboBoxSearchIn.FormattingEnabled = true;
            this.comboBoxSearchIn.Items.AddRange(new object[] {
            "Whole Quran",
            "Current Sura"});
            this.comboBoxSearchIn.Location = new System.Drawing.Point(78, 47);
            this.comboBoxSearchIn.Name = "comboBoxSearchIn";
            this.comboBoxSearchIn.Size = new System.Drawing.Size(92, 21);
            this.comboBoxSearchIn.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.textBoxSearch.Location = new System.Drawing.Point(8, 20);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonSearch.Location = new System.Drawing.Point(112, 18);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(63, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxReciter);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.btnPlay);
            this.groupBox2.Controls.Add(this.axWMP);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(10, 526);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(185, 126);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Audio Player";
            // 
            // comboBoxReciter
            // 
            this.comboBoxReciter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxReciter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.comboBoxReciter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReciter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxReciter.ForeColor = System.Drawing.Color.Black;
            this.comboBoxReciter.FormattingEnabled = true;
            this.comboBoxReciter.Items.AddRange(new object[] {
            "Mishari Rashid Bin Alafasy",
            "Abdul Basit"});
            this.comboBoxReciter.Location = new System.Drawing.Point(49, 18);
            this.comboBoxReciter.Name = "comboBoxReciter";
            this.comboBoxReciter.Size = new System.Drawing.Size(126, 21);
            this.comboBoxReciter.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.label7.Location = new System.Drawing.Point(5, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Reciter:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.label2.Location = new System.Drawing.Point(135, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Volume";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(135, 56);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 65);
            this.trackBar1.TabIndex = 23;
            this.trackBar1.TickFrequency = 20;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnStop
            // 
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Location = new System.Drawing.Point(56, 44);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(45, 23);
            this.btnStop.TabIndex = 22;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.Black;
            this.btnPlay.Location = new System.Drawing.Point(8, 44);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(45, 23);
            this.btnPlay.TabIndex = 22;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnPrevSura);
            this.groupBox1.Controls.Add(this.btnNextSura);
            this.groupBox1.Controls.Add(this.comboBoxSura);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(10, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(185, 174);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            this.groupBox1.Resize += new System.EventHandler(this.groupBox1_Resize);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Original (Arabic)",
            "Bangla",
            "English"});
            this.checkedListBox1.Location = new System.Drawing.Point(24, 116);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(151, 47);
            this.checkedListBox1.TabIndex = 8;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            this.checkedListBox1.SelectedValueChanged += new System.EventHandler(this.checkedListBox1_SelectedValueChanged);
            this.checkedListBox1.Validated += new System.EventHandler(this.checkedListBox1_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.label1.Location = new System.Drawing.Point(21, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Languages:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnPrevPage);
            this.panel2.Controls.Add(this.btnNextPage);
            this.panel2.Controls.Add(this.comboBoxPage);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(92, 58);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(88, 41);
            this.panel2.TabIndex = 6;
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.btnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevPage.ForeColor = System.Drawing.Color.Black;
            this.btnPrevPage.Location = new System.Drawing.Point(0, 18);
            this.btnPrevPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(19, 21);
            this.btnPrevPage.TabIndex = 7;
            this.btnPrevPage.Text = "◄";
            this.btnPrevPage.UseVisualStyleBackColor = false;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.ForeColor = System.Drawing.Color.Black;
            this.btnNextPage.Location = new System.Drawing.Point(64, 18);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(19, 21);
            this.btnNextPage.TabIndex = 8;
            this.btnNextPage.Text = "►";
            this.btnNextPage.UseVisualStyleBackColor = false;
            // 
            // comboBoxPage
            // 
            this.comboBoxPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.comboBoxPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPage.ForeColor = System.Drawing.Color.Black;
            this.comboBoxPage.FormattingEnabled = true;
            this.comboBoxPage.Location = new System.Drawing.Point(18, 18);
            this.comboBoxPage.Name = "comboBoxPage";
            this.comboBoxPage.Size = new System.Drawing.Size(46, 21);
            this.comboBoxPage.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.label5.Location = new System.Drawing.Point(17, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Page:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrevAya);
            this.panel1.Controls.Add(this.comboBoxAya);
            this.panel1.Controls.Add(this.btnNextAya);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(2, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 41);
            this.panel1.TabIndex = 5;
            // 
            // btnPrevAya
            // 
            this.btnPrevAya.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.btnPrevAya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevAya.ForeColor = System.Drawing.Color.Black;
            this.btnPrevAya.Location = new System.Drawing.Point(4, 18);
            this.btnPrevAya.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevAya.Name = "btnPrevAya";
            this.btnPrevAya.Size = new System.Drawing.Size(19, 21);
            this.btnPrevAya.TabIndex = 4;
            this.btnPrevAya.Text = "◄";
            this.btnPrevAya.UseVisualStyleBackColor = false;
            this.btnPrevAya.Click += new System.EventHandler(this.btnPrevAya_Click);
            // 
            // btnNextAya
            // 
            this.btnNextAya.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextAya.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.btnNextAya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextAya.ForeColor = System.Drawing.Color.Black;
            this.btnNextAya.Location = new System.Drawing.Point(70, 18);
            this.btnNextAya.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextAya.Name = "btnNextAya";
            this.btnNextAya.Size = new System.Drawing.Size(19, 21);
            this.btnNextAya.TabIndex = 4;
            this.btnNextAya.Text = "►";
            this.btnNextAya.UseVisualStyleBackColor = false;
            this.btnNextAya.Click += new System.EventHandler(this.btnNextAya_Click);
            // 
            // btnPrevSura
            // 
            this.btnPrevSura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.btnPrevSura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevSura.ForeColor = System.Drawing.Color.Black;
            this.btnPrevSura.Location = new System.Drawing.Point(7, 32);
            this.btnPrevSura.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevSura.Name = "btnPrevSura";
            this.btnPrevSura.Size = new System.Drawing.Size(19, 21);
            this.btnPrevSura.TabIndex = 4;
            this.btnPrevSura.Text = "◄";
            this.btnPrevSura.UseVisualStyleBackColor = false;
            this.btnPrevSura.Click += new System.EventHandler(this.btnPrevSura_Click);
            // 
            // btnNextSura
            // 
            this.btnNextSura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextSura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.btnNextSura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextSura.ForeColor = System.Drawing.Color.Black;
            this.btnNextSura.Location = new System.Drawing.Point(158, 32);
            this.btnNextSura.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextSura.Name = "btnNextSura";
            this.btnNextSura.Size = new System.Drawing.Size(19, 21);
            this.btnNextSura.TabIndex = 4;
            this.btnNextSura.Text = "►";
            this.btnNextSura.UseVisualStyleBackColor = false;
            this.btnNextSura.Click += new System.EventHandler(this.btnNextSura_Click);
            // 
            // comboBoxSura
            // 
            this.comboBoxSura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.comboBoxSura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSura.ForeColor = System.Drawing.Color.Black;
            this.comboBoxSura.FormattingEnabled = true;
            this.comboBoxSura.Location = new System.Drawing.Point(25, 32);
            this.comboBoxSura.Name = "comboBoxSura";
            this.comboBoxSura.Size = new System.Drawing.Size(133, 21);
            this.comboBoxSura.TabIndex = 3;
            this.comboBoxSura.SelectedIndexChanged += new System.EventHandler(this.comboBoxSura_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(211)))));
            this.label3.Location = new System.Drawing.Point(26, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sura:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(5, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(10);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1072, 662);
            this.webBrowser1.TabIndex = 14;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1280, 29);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timerLoadDocument
            // 
            this.timerLoadDocument.Interval = 10;
            this.timerLoadDocument.Tick += new System.EventHandler(this.timerLoadDocument_Tick);
            // 
            // axWMP
            // 
            this.axWMP.Enabled = true;
            this.axWMP.Location = new System.Drawing.Point(8, 94);
            this.axWMP.Margin = new System.Windows.Forms.Padding(2);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new System.Drawing.Size(165, 32);
            this.axWMP.TabIndex = 21;
            this.axWMP.Visible = false;
            this.axWMP.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWMP.Enter += new System.EventHandler(this.axWMP_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1280, 691);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quran - The message, sent by Allah (swt.)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerPlayback;
        private System.Windows.Forms.ComboBox comboBoxAya;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxSura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPlay;
        private AxWMPLib.AxWindowsMediaPlayer axWMP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnPrevAya;
        private System.Windows.Forms.Button btnNextAya;
        private System.Windows.Forms.Button btnPrevSura;
        private System.Windows.Forms.Button btnNextSura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.ComboBox comboBoxPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxReciter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Timer timerLoadDocument;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxSearchIn;
    }
}

