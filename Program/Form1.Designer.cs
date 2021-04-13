namespace Program
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.glControl1 = new OpenTK.GLControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.settingsTimer = new System.Windows.Forms.Timer(this.components);
            this.Burger = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.HistRadioButton = new System.Windows.Forms.RadioButton();
            this.PolyRadioButton = new System.Windows.Forms.RadioButton();
            this.currTrack = new System.Windows.Forms.Label();
            this.pointRadioButton = new System.Windows.Forms.RadioButton();
            this.maxTrack = new System.Windows.Forms.Label();
            this.minTrack = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaxTTextBox = new System.Windows.Forms.TextBox();
            this.MinTTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MaxYTextBox = new System.Windows.Forms.TextBox();
            this.EquaButton = new System.Windows.Forms.Button();
            this.MinYTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MaxXTextBox = new System.Windows.Forms.TextBox();
            this.MinXTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EquaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(0, -2);
            this.glControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(1177, 631);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Click += new System.EventHandler(this.glControl1_Click);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseMove);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text|*.txt|Excel|*.xslx";
            // 
            // settingsTimer
            // 
            this.settingsTimer.Enabled = true;
            this.settingsTimer.Interval = 5;
            this.settingsTimer.Tick += new System.EventHandler(this.settingsTimer_Tick);
            // 
            // Burger
            // 
            this.Burger.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Burger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Burger.Image = ((System.Drawing.Image)(resources.GetObject("Burger.Image")));
            this.Burger.Location = new System.Drawing.Point(264, -1);
            this.Burger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Burger.Name = "Burger";
            this.Burger.Size = new System.Drawing.Size(48, 44);
            this.Burger.TabIndex = 17;
            this.Burger.UseVisualStyleBackColor = false;
            this.Burger.Click += new System.EventHandler(this.Burger_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.settingsPanel.Controls.Add(this.panel2);
            this.settingsPanel.Controls.Add(this.label6);
            this.settingsPanel.Controls.Add(this.HistRadioButton);
            this.settingsPanel.Controls.Add(this.PolyRadioButton);
            this.settingsPanel.Controls.Add(this.currTrack);
            this.settingsPanel.Controls.Add(this.pointRadioButton);
            this.settingsPanel.Controls.Add(this.maxTrack);
            this.settingsPanel.Controls.Add(this.minTrack);
            this.settingsPanel.Controls.Add(this.trackBar1);
            this.settingsPanel.Controls.Add(this.panel1);
            this.settingsPanel.Controls.Add(this.label1);
            this.settingsPanel.Controls.Add(this.radioButton2);
            this.settingsPanel.Controls.Add(this.radioButton1);
            this.settingsPanel.Controls.Add(this.button1);
            this.settingsPanel.Controls.Add(this.button3);
            this.settingsPanel.Controls.Add(this.button2);
            this.settingsPanel.Location = new System.Drawing.Point(0, -2);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(265, 631);
            this.settingsPanel.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(56, 338);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "Тип диаграммы";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HistRadioButton
            // 
            this.HistRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.HistRadioButton.AutoSize = true;
            this.HistRadioButton.BackColor = System.Drawing.Color.Gainsboro;
            this.HistRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HistRadioButton.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HistRadioButton.Location = new System.Drawing.Point(127, 379);
            this.HistRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HistRadioButton.Name = "HistRadioButton";
            this.HistRadioButton.Size = new System.Drawing.Size(125, 30);
            this.HistRadioButton.TabIndex = 33;
            this.HistRadioButton.TabStop = true;
            this.HistRadioButton.Text = "Гистограмма";
            this.HistRadioButton.UseVisualStyleBackColor = false;
            this.HistRadioButton.CheckedChanged += new System.EventHandler(this.HistRadioButton_CheckedChanged);
            // 
            // PolyRadioButton
            // 
            this.PolyRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.PolyRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PolyRadioButton.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PolyRadioButton.Location = new System.Drawing.Point(59, 416);
            this.PolyRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PolyRadioButton.Name = "PolyRadioButton";
            this.PolyRadioButton.Size = new System.Drawing.Size(157, 28);
            this.PolyRadioButton.TabIndex = 32;
            this.PolyRadioButton.TabStop = true;
            this.PolyRadioButton.Text = "Полигональная";
            this.PolyRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PolyRadioButton.UseVisualStyleBackColor = true;
            this.PolyRadioButton.CheckedChanged += new System.EventHandler(this.PolyRadioButton_CheckedChanged);
            // 
            // currTrack
            // 
            this.currTrack.AutoSize = true;
            this.currTrack.BackColor = System.Drawing.Color.Transparent;
            this.currTrack.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currTrack.Location = new System.Drawing.Point(119, 452);
            this.currTrack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currTrack.Name = "currTrack";
            this.currTrack.Size = new System.Drawing.Size(24, 26);
            this.currTrack.TabIndex = 30;
            this.currTrack.Text = "0";
            this.currTrack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pointRadioButton
            // 
            this.pointRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.pointRadioButton.AutoSize = true;
            this.pointRadioButton.BackColor = System.Drawing.Color.Gainsboro;
            this.pointRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pointRadioButton.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pointRadioButton.Location = new System.Drawing.Point(16, 379);
            this.pointRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pointRadioButton.Name = "pointRadioButton";
            this.pointRadioButton.Size = new System.Drawing.Size(98, 30);
            this.pointRadioButton.TabIndex = 31;
            this.pointRadioButton.TabStop = true;
            this.pointRadioButton.Text = "Точечная";
            this.pointRadioButton.UseVisualStyleBackColor = false;
            this.pointRadioButton.CheckedChanged += new System.EventHandler(this.pointRadioButton_CheckedChanged);
            // 
            // maxTrack
            // 
            this.maxTrack.AutoSize = true;
            this.maxTrack.BackColor = System.Drawing.Color.Transparent;
            this.maxTrack.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxTrack.Location = new System.Drawing.Point(200, 452);
            this.maxTrack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxTrack.Name = "maxTrack";
            this.maxTrack.Size = new System.Drawing.Size(48, 26);
            this.maxTrack.TabIndex = 29;
            this.maxTrack.Text = "100";
            this.maxTrack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minTrack
            // 
            this.minTrack.AutoSize = true;
            this.minTrack.BackColor = System.Drawing.Color.Transparent;
            this.minTrack.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minTrack.Location = new System.Drawing.Point(23, 452);
            this.minTrack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minTrack.Name = "minTrack";
            this.minTrack.Size = new System.Drawing.Size(24, 26);
            this.minTrack.TabIndex = 28;
            this.minTrack.Text = "0";
            this.minTrack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(16, 474);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(236, 61);
            this.trackBar1.TabIndex = 18;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.MaxTTextBox);
            this.panel1.Controls.Add(this.MinTTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.MaxYTextBox);
            this.panel1.Controls.Add(this.EquaButton);
            this.panel1.Controls.Add(this.MinYTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.MaxXTextBox);
            this.panel1.Controls.Add(this.MinXTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.EquaTextBox);
            this.panel1.Location = new System.Drawing.Point(4, 108);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 222);
            this.panel1.TabIndex = 17;
            // 
            // MaxTTextBox
            // 
            this.MaxTTextBox.Location = new System.Drawing.Point(168, 137);
            this.MaxTTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxTTextBox.Name = "MaxTTextBox";
            this.MaxTTextBox.Size = new System.Drawing.Size(76, 22);
            this.MaxTTextBox.TabIndex = 27;
            this.MaxTTextBox.Text = "100";
            this.MaxTTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaxTTextBox.TextChanged += new System.EventHandler(this.MaxTTextBox_TextChanged);
            // 
            // MinTTextBox
            // 
            this.MinTTextBox.Location = new System.Drawing.Point(12, 135);
            this.MinTTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinTTextBox.Name = "MinTTextBox";
            this.MinTTextBox.Size = new System.Drawing.Size(76, 22);
            this.MinTTextBox.TabIndex = 26;
            this.MinTTextBox.Text = "0";
            this.MinTTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinTTextBox.TextChanged += new System.EventHandler(this.MinTTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(100, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 26);
            this.label5.TabIndex = 25;
            this.label5.Text = "⩽ t ⩽";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaxYTextBox
            // 
            this.MaxYTextBox.Location = new System.Drawing.Point(168, 105);
            this.MaxYTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxYTextBox.Name = "MaxYTextBox";
            this.MaxYTextBox.Size = new System.Drawing.Size(76, 22);
            this.MaxYTextBox.TabIndex = 24;
            this.MaxYTextBox.Text = "10";
            this.MaxYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EquaButton
            // 
            this.EquaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EquaButton.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EquaButton.Location = new System.Drawing.Point(55, 176);
            this.EquaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EquaButton.Name = "EquaButton";
            this.EquaButton.Size = new System.Drawing.Size(145, 32);
            this.EquaButton.TabIndex = 13;
            this.EquaButton.Text = "Рассчёт";
            this.EquaButton.UseVisualStyleBackColor = true;
            this.EquaButton.Click += new System.EventHandler(this.EquaButton_Click);
            // 
            // MinYTextBox
            // 
            this.MinYTextBox.Location = new System.Drawing.Point(12, 103);
            this.MinYTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinYTextBox.Name = "MinYTextBox";
            this.MinYTextBox.Size = new System.Drawing.Size(76, 22);
            this.MinYTextBox.TabIndex = 23;
            this.MinYTextBox.Text = "-10";
            this.MinYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(100, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "⩽ Y ⩽";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaxXTextBox
            // 
            this.MaxXTextBox.Location = new System.Drawing.Point(168, 73);
            this.MaxXTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxXTextBox.Name = "MaxXTextBox";
            this.MaxXTextBox.Size = new System.Drawing.Size(76, 22);
            this.MaxXTextBox.TabIndex = 21;
            this.MaxXTextBox.Text = "10";
            this.MaxXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MinXTextBox
            // 
            this.MinXTextBox.Location = new System.Drawing.Point(12, 71);
            this.MinXTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinXTextBox.Name = "MinXTextBox";
            this.MinXTextBox.Size = new System.Drawing.Size(76, 22);
            this.MinXTextBox.TabIndex = 20;
            this.MinXTextBox.Text = "-10";
            this.MinXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(100, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "⩽ X ⩽";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(81, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Уравнение";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquaTextBox
            // 
            this.EquaTextBox.Location = new System.Drawing.Point(12, 31);
            this.EquaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EquaTextBox.Name = "EquaTextBox";
            this.EquaTextBox.Size = new System.Drawing.Size(232, 22);
            this.EquaTextBox.TabIndex = 0;
            this.EquaTextBox.Text = "x * y + t * y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Параметры импорта";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioButton2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(147, 71);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 28);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Таблица";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioButton1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton1.Location = new System.Drawing.Point(21, 71);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(108, 30);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Уравнение";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(147, 537);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Пуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(89, 577);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(21, 537);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Стоп";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 20;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.comboBox4);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(3, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 222);
            this.panel2.TabIndex = 19;
            this.panel2.Visible = false;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(16, 6);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(229, 33);
            this.button4.TabIndex = 1;
            this.button4.Text = "Выбрать файл";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(17, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "X - ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(17, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Y -";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(17, 113);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Z -";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(17, 150);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "T -";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(54, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(54, 77);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(191, 24);
            this.comboBox2.TabIndex = 17;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(54, 114);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(191, 24);
            this.comboBox3.TabIndex = 17;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(54, 150);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(191, 24);
            this.comboBox4.TabIndex = 17;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(16, 181);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(229, 33);
            this.button5.TabIndex = 1;
            this.button5.Text = "Загрузить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1173, 624);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.Burger);
            this.Controls.Add(this.glControl1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "CourseWork";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer settingsTimer;
        private System.Windows.Forms.Button Burger;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Button EquaButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox EquaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaxTTextBox;
        private System.Windows.Forms.TextBox MinTTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MaxYTextBox;
        private System.Windows.Forms.TextBox MinYTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MaxXTextBox;
        private System.Windows.Forms.TextBox MinXTextBox;
        private System.Windows.Forms.Label currTrack;
        private System.Windows.Forms.Label maxTrack;
        private System.Windows.Forms.Label minTrack;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton HistRadioButton;
        private System.Windows.Forms.RadioButton PolyRadioButton;
        private System.Windows.Forms.RadioButton pointRadioButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
    }
}

