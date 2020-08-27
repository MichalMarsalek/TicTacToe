namespace TicTacToe
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.TabNewGame = new System.Windows.Forms.TabPage();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.RadioSwap2 = new System.Windows.Forms.RadioButton();
            this.RadioSwap1 = new System.Windows.Forms.RadioButton();
            this.RadioClassic = new System.Windows.Forms.RadioButton();
            this.labelOpening = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RadioStartsRandom = new System.Windows.Forms.RadioButton();
            this.RadioStartsX = new System.Windows.Forms.RadioButton();
            this.RadioStartsO = new System.Windows.Forms.RadioButton();
            this.labelStarts = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RadioXHuman = new System.Windows.Forms.RadioButton();
            this.RadioXComputer = new System.Windows.Forms.RadioButton();
            this.labelPlayerX = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NumberHeight = new System.Windows.Forms.NumericUpDown();
            this.NumberWidth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RadioOHuman = new System.Windows.Forms.RadioButton();
            this.RadioOComputer = new System.Windows.Forms.RadioButton();
            this.labelPlayerO = new System.Windows.Forms.Label();
            this.TabGameSettings = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.comboBoxLocalization = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownMoveDuration = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.SliderXDeffQ = new System.Windows.Forms.TrackBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.SliderODeffQ = new System.Windows.Forms.TrackBar();
            this.TabAbout = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.animatedIcon = new TicTacToe.AnimatedIcon();
            this.tabControl.SuspendLayout();
            this.TabNewGame.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberWidth)).BeginInit();
            this.panel1.SuspendLayout();
            this.TabGameSettings.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoveDuration)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderXDeffQ)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderODeffQ)).BeginInit();
            this.TabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.TabNewGame);
            this.tabControl.Controls.Add(this.TabGameSettings);
            this.tabControl.Controls.Add(this.TabAbout);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(326, 242);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // TabNewGame
            // 
            this.TabNewGame.Controls.Add(this.ButtonStart);
            this.TabNewGame.Controls.Add(this.panel9);
            this.TabNewGame.Controls.Add(this.panel3);
            this.TabNewGame.Controls.Add(this.panel2);
            this.TabNewGame.Controls.Add(this.panel4);
            this.TabNewGame.Controls.Add(this.panel1);
            this.TabNewGame.Location = new System.Drawing.Point(4, 22);
            this.TabNewGame.Name = "TabNewGame";
            this.TabNewGame.Padding = new System.Windows.Forms.Padding(3);
            this.TabNewGame.Size = new System.Drawing.Size(318, 216);
            this.TabNewGame.TabIndex = 0;
            this.TabNewGame.Text = "NewGame";
            this.TabNewGame.UseVisualStyleBackColor = true;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStart.Location = new System.Drawing.Point(10, 185);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(300, 23);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.RadioSwap2);
            this.panel9.Controls.Add(this.RadioSwap1);
            this.panel9.Controls.Add(this.RadioClassic);
            this.panel9.Controls.Add(this.labelOpening);
            this.panel9.Location = new System.Drawing.Point(10, 148);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(299, 31);
            this.panel9.TabIndex = 0;
            // 
            // RadioSwap2
            // 
            this.RadioSwap2.AutoSize = true;
            this.RadioSwap2.Location = new System.Drawing.Point(202, 4);
            this.RadioSwap2.Name = "RadioSwap2";
            this.RadioSwap2.Size = new System.Drawing.Size(58, 17);
            this.RadioSwap2.TabIndex = 1;
            this.RadioSwap2.Text = "Swap2";
            this.RadioSwap2.UseVisualStyleBackColor = true;
            // 
            // RadioSwap1
            // 
            this.RadioSwap1.AutoSize = true;
            this.RadioSwap1.Checked = true;
            this.RadioSwap1.Location = new System.Drawing.Point(137, 4);
            this.RadioSwap1.Name = "RadioSwap1";
            this.RadioSwap1.Size = new System.Drawing.Size(58, 17);
            this.RadioSwap1.TabIndex = 1;
            this.RadioSwap1.TabStop = true;
            this.RadioSwap1.Text = "Swap1";
            this.RadioSwap1.UseVisualStyleBackColor = true;
            // 
            // RadioClassic
            // 
            this.RadioClassic.AutoSize = true;
            this.RadioClassic.Location = new System.Drawing.Point(61, 4);
            this.RadioClassic.Name = "RadioClassic";
            this.RadioClassic.Size = new System.Drawing.Size(58, 17);
            this.RadioClassic.TabIndex = 1;
            this.RadioClassic.Text = "Classic";
            this.RadioClassic.UseVisualStyleBackColor = true;
            // 
            // labelOpening
            // 
            this.labelOpening.AutoSize = true;
            this.labelOpening.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpening.Location = new System.Drawing.Point(-1, 6);
            this.labelOpening.Name = "labelOpening";
            this.labelOpening.Size = new System.Drawing.Size(54, 13);
            this.labelOpening.TabIndex = 0;
            this.labelOpening.Text = "Opening";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.RadioStartsRandom);
            this.panel3.Controls.Add(this.RadioStartsX);
            this.panel3.Controls.Add(this.RadioStartsO);
            this.panel3.Controls.Add(this.labelStarts);
            this.panel3.Location = new System.Drawing.Point(10, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 31);
            this.panel3.TabIndex = 0;
            // 
            // RadioStartsRandom
            // 
            this.RadioStartsRandom.AutoSize = true;
            this.RadioStartsRandom.Checked = true;
            this.RadioStartsRandom.Location = new System.Drawing.Point(202, 4);
            this.RadioStartsRandom.Name = "RadioStartsRandom";
            this.RadioStartsRandom.Size = new System.Drawing.Size(65, 17);
            this.RadioStartsRandom.TabIndex = 1;
            this.RadioStartsRandom.TabStop = true;
            this.RadioStartsRandom.Text = "Random";
            this.RadioStartsRandom.UseVisualStyleBackColor = true;
            // 
            // RadioStartsX
            // 
            this.RadioStartsX.AutoSize = true;
            this.RadioStartsX.Location = new System.Drawing.Point(137, 4);
            this.RadioStartsX.Name = "RadioStartsX";
            this.RadioStartsX.Size = new System.Drawing.Size(61, 17);
            this.RadioStartsX.TabIndex = 1;
            this.RadioStartsX.Text = "PlayerX";
            this.RadioStartsX.UseVisualStyleBackColor = true;
            // 
            // RadioStartsO
            // 
            this.RadioStartsO.AutoSize = true;
            this.RadioStartsO.Location = new System.Drawing.Point(61, 4);
            this.RadioStartsO.Name = "RadioStartsO";
            this.RadioStartsO.Size = new System.Drawing.Size(62, 17);
            this.RadioStartsO.TabIndex = 1;
            this.RadioStartsO.Text = "PlayerO";
            this.RadioStartsO.UseVisualStyleBackColor = true;
            // 
            // labelStarts
            // 
            this.labelStarts.AutoSize = true;
            this.labelStarts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStarts.Location = new System.Drawing.Point(-1, 6);
            this.labelStarts.Name = "labelStarts";
            this.labelStarts.Size = new System.Drawing.Size(40, 13);
            this.labelStarts.TabIndex = 0;
            this.labelStarts.Text = "Starts";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RadioXHuman);
            this.panel2.Controls.Add(this.RadioXComputer);
            this.panel2.Controls.Add(this.labelPlayerX);
            this.panel2.Location = new System.Drawing.Point(10, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 31);
            this.panel2.TabIndex = 0;
            // 
            // RadioXHuman
            // 
            this.RadioXHuman.AutoSize = true;
            this.RadioXHuman.Checked = true;
            this.RadioXHuman.Location = new System.Drawing.Point(137, 4);
            this.RadioXHuman.Name = "RadioXHuman";
            this.RadioXHuman.Size = new System.Drawing.Size(59, 17);
            this.RadioXHuman.TabIndex = 1;
            this.RadioXHuman.TabStop = true;
            this.RadioXHuman.Text = "Human";
            this.RadioXHuman.UseVisualStyleBackColor = true;
            // 
            // RadioXComputer
            // 
            this.RadioXComputer.AutoSize = true;
            this.RadioXComputer.Location = new System.Drawing.Point(61, 4);
            this.RadioXComputer.Name = "RadioXComputer";
            this.RadioXComputer.Size = new System.Drawing.Size(70, 17);
            this.RadioXComputer.TabIndex = 1;
            this.RadioXComputer.Text = "Computer";
            this.RadioXComputer.UseVisualStyleBackColor = true;
            // 
            // labelPlayerX
            // 
            this.labelPlayerX.AutoSize = true;
            this.labelPlayerX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayerX.Location = new System.Drawing.Point(-1, 6);
            this.labelPlayerX.Name = "labelPlayerX";
            this.labelPlayerX.Size = new System.Drawing.Size(50, 13);
            this.labelPlayerX.TabIndex = 0;
            this.labelPlayerX.Text = "PlayerX";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.NumberHeight);
            this.panel4.Controls.Add(this.NumberWidth);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.labelSize);
            this.panel4.Location = new System.Drawing.Point(10, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(299, 31);
            this.panel4.TabIndex = 0;
            // 
            // NumberHeight
            // 
            this.NumberHeight.Location = new System.Drawing.Point(155, 4);
            this.NumberHeight.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NumberHeight.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumberHeight.Name = "NumberHeight";
            this.NumberHeight.Size = new System.Drawing.Size(65, 20);
            this.NumberHeight.TabIndex = 1;
            this.NumberHeight.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // NumberWidth
            // 
            this.NumberWidth.Location = new System.Drawing.Point(61, 4);
            this.NumberWidth.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NumberWidth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumberWidth.Name = "NumberWidth";
            this.NumberWidth.Size = new System.Drawing.Size(65, 20);
            this.NumberWidth.TabIndex = 1;
            this.NumberWidth.Value = new decimal(new int[] {
            34,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(133, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "×";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSize.Location = new System.Drawing.Point(-1, 6);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(31, 13);
            this.labelSize.TabIndex = 0;
            this.labelSize.Text = "Size";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RadioOHuman);
            this.panel1.Controls.Add(this.RadioOComputer);
            this.panel1.Controls.Add(this.labelPlayerO);
            this.panel1.Location = new System.Drawing.Point(10, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 31);
            this.panel1.TabIndex = 0;
            // 
            // RadioOHuman
            // 
            this.RadioOHuman.AutoSize = true;
            this.RadioOHuman.Location = new System.Drawing.Point(137, 4);
            this.RadioOHuman.Name = "RadioOHuman";
            this.RadioOHuman.Size = new System.Drawing.Size(59, 17);
            this.RadioOHuman.TabIndex = 1;
            this.RadioOHuman.Text = "Human";
            this.RadioOHuman.UseVisualStyleBackColor = true;
            // 
            // RadioOComputer
            // 
            this.RadioOComputer.AutoSize = true;
            this.RadioOComputer.Checked = true;
            this.RadioOComputer.Location = new System.Drawing.Point(61, 4);
            this.RadioOComputer.Name = "RadioOComputer";
            this.RadioOComputer.Size = new System.Drawing.Size(70, 17);
            this.RadioOComputer.TabIndex = 1;
            this.RadioOComputer.TabStop = true;
            this.RadioOComputer.Text = "Computer";
            this.RadioOComputer.UseVisualStyleBackColor = true;
            // 
            // labelPlayerO
            // 
            this.labelPlayerO.AutoSize = true;
            this.labelPlayerO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayerO.Location = new System.Drawing.Point(-1, 6);
            this.labelPlayerO.Name = "labelPlayerO";
            this.labelPlayerO.Size = new System.Drawing.Size(51, 13);
            this.labelPlayerO.TabIndex = 0;
            this.labelPlayerO.Text = "PlayerO";
            // 
            // TabGameSettings
            // 
            this.TabGameSettings.Controls.Add(this.panel8);
            this.TabGameSettings.Controls.Add(this.panel7);
            this.TabGameSettings.Controls.Add(this.panel6);
            this.TabGameSettings.Controls.Add(this.panel5);
            this.TabGameSettings.Location = new System.Drawing.Point(4, 22);
            this.TabGameSettings.Name = "TabGameSettings";
            this.TabGameSettings.Padding = new System.Windows.Forms.Padding(3);
            this.TabGameSettings.Size = new System.Drawing.Size(318, 216);
            this.TabGameSettings.TabIndex = 1;
            this.TabGameSettings.Text = "GameSettings";
            this.TabGameSettings.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.comboBoxLocalization);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Location = new System.Drawing.Point(9, 133);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(299, 31);
            this.panel8.TabIndex = 2;
            // 
            // comboBoxLocalization
            // 
            this.comboBoxLocalization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLocalization.FormattingEnabled = true;
            this.comboBoxLocalization.Location = new System.Drawing.Point(131, 5);
            this.comboBoxLocalization.Name = "comboBoxLocalization";
            this.comboBoxLocalization.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLocalization.Sorted = true;
            this.comboBoxLocalization.TabIndex = 1;
            this.comboBoxLocalization.Tag = "noLocatization";
            this.comboBoxLocalization.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocalization_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(-1, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Localization";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.numericUpDownMoveDuration);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Location = new System.Drawing.Point(9, 96);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(299, 31);
            this.panel7.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(159, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "ms";
            // 
            // numericUpDownMoveDuration
            // 
            this.numericUpDownMoveDuration.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownMoveDuration.Location = new System.Drawing.Point(132, 6);
            this.numericUpDownMoveDuration.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownMoveDuration.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownMoveDuration.Name = "numericUpDownMoveDuration";
            this.numericUpDownMoveDuration.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownMoveDuration.TabIndex = 1;
            this.numericUpDownMoveDuration.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(-1, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "MoveDuration";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.SliderXDeffQ);
            this.panel6.Location = new System.Drawing.Point(9, 53);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(299, 41);
            this.panel6.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(-1, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "CompXDeffensive";
            // 
            // SliderXDeffQ
            // 
            this.SliderXDeffQ.BackColor = System.Drawing.Color.White;
            this.SliderXDeffQ.Location = new System.Drawing.Point(123, 0);
            this.SliderXDeffQ.Minimum = 1;
            this.SliderXDeffQ.Name = "SliderXDeffQ";
            this.SliderXDeffQ.Size = new System.Drawing.Size(149, 45);
            this.SliderXDeffQ.TabIndex = 0;
            this.SliderXDeffQ.Value = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.SliderODeffQ);
            this.panel5.Location = new System.Drawing.Point(8, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(299, 41);
            this.panel5.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(-1, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "CompODeffensive";
            // 
            // SliderODeffQ
            // 
            this.SliderODeffQ.BackColor = System.Drawing.Color.White;
            this.SliderODeffQ.Location = new System.Drawing.Point(123, 0);
            this.SliderODeffQ.Minimum = 1;
            this.SliderODeffQ.Name = "SliderODeffQ";
            this.SliderODeffQ.Size = new System.Drawing.Size(149, 45);
            this.SliderODeffQ.TabIndex = 0;
            this.SliderODeffQ.Value = 1;
            // 
            // TabAbout
            // 
            this.TabAbout.Controls.Add(this.linkLabel1);
            this.TabAbout.Controls.Add(this.labelVersion);
            this.TabAbout.Controls.Add(this.label10);
            this.TabAbout.Controls.Add(this.animatedIcon);
            this.TabAbout.Location = new System.Drawing.Point(4, 22);
            this.TabAbout.Name = "TabAbout";
            this.TabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.TabAbout.Size = new System.Drawing.Size(318, 216);
            this.TabAbout.TabIndex = 2;
            this.TabAbout.Text = "About";
            this.TabAbout.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(222, 197);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "michalmarsalek.cz";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(8, 16);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(176, 25);
            this.labelVersion.TabIndex = 2;
            this.labelVersion.Text = "Tic Tac Toe v1.0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "CreatedByMichalMarsalekIn2015";
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // animatedIcon
            // 
            this.animatedIcon.Completion = 0F;
            this.animatedIcon.Location = new System.Drawing.Point(195, 16);
            this.animatedIcon.Name = "animatedIcon";
            this.animatedIcon.Size = new System.Drawing.Size(100, 100);
            this.animatedIcon.TabIndex = 1;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.ButtonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 241);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(340, 280);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabControl.ResumeLayout(false);
            this.TabNewGame.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberWidth)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabGameSettings.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoveDuration)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderXDeffQ)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderODeffQ)).EndInit();
            this.TabAbout.ResumeLayout(false);
            this.TabAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage TabNewGame;
        private System.Windows.Forms.TabPage TabGameSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RadioOHuman;
        private System.Windows.Forms.RadioButton RadioOComputer;
        private System.Windows.Forms.Label labelPlayerO;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RadioXHuman;
        private System.Windows.Forms.RadioButton RadioXComputer;
        private System.Windows.Forms.Label labelPlayerX;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton RadioStartsRandom;
        private System.Windows.Forms.RadioButton RadioStartsX;
        private System.Windows.Forms.RadioButton RadioStartsO;
        private System.Windows.Forms.Label labelStarts;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.NumericUpDown NumberHeight;
        private System.Windows.Forms.NumericUpDown NumberWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar SliderODeffQ;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar SliderXDeffQ;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.NumericUpDown numericUpDownMoveDuration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage TabAbout;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RadioButton RadioSwap2;
        private System.Windows.Forms.RadioButton RadioSwap1;
        private System.Windows.Forms.RadioButton RadioClassic;
        private System.Windows.Forms.Label labelOpening;
        private System.Windows.Forms.Timer timer;
        private AnimatedIcon animatedIcon;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox comboBoxLocalization;
    }
}