namespace UtilCrackTools
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbAddressRes = new System.Windows.Forms.TextBox();
            this.tbOffset = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EqualLabel = new System.Windows.Forms.Label();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbScreenWidth = new System.Windows.Forms.TextBox();
            this.tbScreenHeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMemoryArea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbRange = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.pnlCornerSelector = new System.Windows.Forms.Panel();
            this.btnRDCorner = new System.Windows.Forms.Button();
            this.btnRUCorner = new System.Windows.Forms.Button();
            this.btnLDCorner = new System.Windows.Forms.Button();
            this.btnLUCorner = new System.Windows.Forms.Button();
            this.tbCorrectWindow = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbResultNVTr2 = new System.Windows.Forms.TextBox();
            this.tbResultNVTr1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbResultNVDef2 = new System.Windows.Forms.TextBox();
            this.tbResultNVDef1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbResult3 = new System.Windows.Forms.TextBox();
            this.tbResult2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lResultType = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbResult1 = new System.Windows.Forms.TextBox();
            this.btnInspect = new System.Windows.Forms.Button();
            this.tbVector = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbOffsetDiff = new System.Windows.Forms.TextBox();
            this.tbAddressDiff2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbAddressDiff1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.pnlCornerSelector.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.dragPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address 1:";
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAddress.Location = new System.Drawing.Point(6, 50);
            this.tbAddress.MaxLength = 12;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(163, 32);
            this.tbAddress.TabIndex = 2;
            this.tbAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAddress.TextChanged += new System.EventHandler(this.addressTextBox1_TextChanged);
            // 
            // tbAddressRes
            // 
            this.tbAddressRes.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAddressRes.Location = new System.Drawing.Point(329, 50);
            this.tbAddressRes.MaxLength = 12;
            this.tbAddressRes.Name = "tbAddressRes";
            this.tbAddressRes.ReadOnly = true;
            this.tbAddressRes.Size = new System.Drawing.Size(163, 32);
            this.tbAddressRes.TabIndex = 5;
            this.tbAddressRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbOffset
            // 
            this.tbOffset.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOffset.Location = new System.Drawing.Point(219, 50);
            this.tbOffset.MaxLength = 4;
            this.tbOffset.Name = "tbOffset";
            this.tbOffset.Size = new System.Drawing.Size(76, 32);
            this.tbOffset.TabIndex = 4;
            this.tbOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbOffset.TextChanged += new System.EventHandler(this.offsetTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(333, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(223, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Offset:";
            // 
            // EqualLabel
            // 
            this.EqualLabel.AutoSize = true;
            this.EqualLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqualLabel.Location = new System.Drawing.Point(301, 53);
            this.EqualLabel.Name = "EqualLabel";
            this.EqualLabel.Size = new System.Drawing.Size(22, 24);
            this.EqualLabel.TabIndex = 7;
            this.EqualLabel.Text = "=";
            // 
            // cbOperator
            // 
            this.cbOperator.BackColor = System.Drawing.SystemColors.Window;
            this.cbOperator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperator.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cbOperator.Location = new System.Drawing.Point(175, 50);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(38, 32);
            this.cbOperator.TabIndex = 3;
            this.cbOperator.SelectedIndexChanged += new System.EventHandler(this.operatorComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Window Size:";
            // 
            // tbScreenWidth
            // 
            this.tbScreenWidth.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbScreenWidth.Location = new System.Drawing.Point(6, 50);
            this.tbScreenWidth.MaxLength = 4;
            this.tbScreenWidth.Name = "tbScreenWidth";
            this.tbScreenWidth.Size = new System.Drawing.Size(60, 26);
            this.tbScreenWidth.TabIndex = 10;
            this.tbScreenWidth.Text = "1280";
            this.tbScreenWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbScreenHeight
            // 
            this.tbScreenHeight.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbScreenHeight.Location = new System.Drawing.Point(94, 50);
            this.tbScreenHeight.MaxLength = 4;
            this.tbScreenHeight.Name = "tbScreenHeight";
            this.tbScreenHeight.Size = new System.Drawing.Size(60, 26);
            this.tbScreenHeight.TabIndex = 11;
            this.tbScreenHeight.Text = "720";
            this.tbScreenHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(72, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "X";
            // 
            // tbMemoryArea
            // 
            this.tbMemoryArea.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMemoryArea.Location = new System.Drawing.Point(6, 111);
            this.tbMemoryArea.MaxLength = 5000;
            this.tbMemoryArea.Name = "tbMemoryArea";
            this.tbMemoryArea.Size = new System.Drawing.Size(886, 26);
            this.tbMemoryArea.TabIndex = 19;
            this.tbMemoryArea.Text = "0.90 -0.04 -0.39 -0.39 0.00 1.73 -0.05 -0.05 0.38 0.09 0.92 0.92 18.50 -13.64 -7." +
    "67 -7.06";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(10, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Memory Area String:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.tbRange);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.pnlCornerSelector);
            this.groupBox1.Controls.Add(this.tbCorrectWindow);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.tbResultNVTr2);
            this.groupBox1.Controls.Add(this.tbResultNVTr1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbResultNVDef2);
            this.groupBox1.Controls.Add(this.tbResultNVDef1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbResult3);
            this.groupBox1.Controls.Add(this.tbResult2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lResultType);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbResult1);
            this.groupBox1.Controls.Add(this.btnInspect);
            this.groupBox1.Controls.Add(this.tbVector);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbMemoryArea);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbScreenWidth);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbScreenHeight);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 352);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Matrix Helper";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(487, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 45);
            this.label22.TabIndex = 107;
            this.label22.Text = "Target Point:";
            // 
            // tbRange
            // 
            this.tbRange.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRange.Location = new System.Drawing.Point(364, 50);
            this.tbRange.MaxLength = 4;
            this.tbRange.Name = "tbRange";
            this.tbRange.Size = new System.Drawing.Size(82, 26);
            this.tbRange.TabIndex = 13;
            this.tbRange.Text = "50";
            this.tbRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRange.Leave += new System.EventHandler(this.tbRange_Leave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(368, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 19);
            this.label21.TabIndex = 106;
            this.label21.Text = "Range:";
            // 
            // pnlCornerSelector
            // 
            this.pnlCornerSelector.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlCornerSelector.Controls.Add(this.btnRDCorner);
            this.pnlCornerSelector.Controls.Add(this.btnRUCorner);
            this.pnlCornerSelector.Controls.Add(this.btnLDCorner);
            this.pnlCornerSelector.Controls.Add(this.btnLUCorner);
            this.pnlCornerSelector.Location = new System.Drawing.Point(555, 26);
            this.pnlCornerSelector.Name = "pnlCornerSelector";
            this.pnlCornerSelector.Size = new System.Drawing.Size(128, 72);
            this.pnlCornerSelector.TabIndex = 14;
            // 
            // btnRDCorner
            // 
            this.btnRDCorner.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRDCorner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRDCorner.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRDCorner.Location = new System.Drawing.Point(108, 52);
            this.btnRDCorner.Name = "btnRDCorner";
            this.btnRDCorner.Size = new System.Drawing.Size(20, 20);
            this.btnRDCorner.TabIndex = 18;
            this.btnRDCorner.UseVisualStyleBackColor = false;
            this.btnRDCorner.Click += new System.EventHandler(this.btnRLCorner_Click);
            // 
            // btnRUCorner
            // 
            this.btnRUCorner.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRUCorner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRUCorner.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRUCorner.Location = new System.Drawing.Point(108, 0);
            this.btnRUCorner.Name = "btnRUCorner";
            this.btnRUCorner.Size = new System.Drawing.Size(20, 20);
            this.btnRUCorner.TabIndex = 17;
            this.btnRUCorner.UseVisualStyleBackColor = false;
            this.btnRUCorner.Click += new System.EventHandler(this.btnRUCorner_Click);
            // 
            // btnLDCorner
            // 
            this.btnLDCorner.BackColor = System.Drawing.Color.LightBlue;
            this.btnLDCorner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLDCorner.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLDCorner.Location = new System.Drawing.Point(0, 52);
            this.btnLDCorner.Name = "btnLDCorner";
            this.btnLDCorner.Size = new System.Drawing.Size(20, 20);
            this.btnLDCorner.TabIndex = 15;
            this.btnLDCorner.UseVisualStyleBackColor = false;
            this.btnLDCorner.Click += new System.EventHandler(this.btnLDCorner_Click);
            // 
            // btnLUCorner
            // 
            this.btnLUCorner.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLUCorner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLUCorner.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLUCorner.Location = new System.Drawing.Point(0, 0);
            this.btnLUCorner.Name = "btnLUCorner";
            this.btnLUCorner.Size = new System.Drawing.Size(20, 20);
            this.btnLUCorner.TabIndex = 16;
            this.btnLUCorner.UseVisualStyleBackColor = false;
            this.btnLUCorner.Click += new System.EventHandler(this.btnLUCorner_Click);
            // 
            // tbCorrectWindow
            // 
            this.tbCorrectWindow.BackColor = System.Drawing.SystemColors.Control;
            this.tbCorrectWindow.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCorrectWindow.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbCorrectWindow.Location = new System.Drawing.Point(4, 165);
            this.tbCorrectWindow.MaxLength = 5000;
            this.tbCorrectWindow.Name = "tbCorrectWindow";
            this.tbCorrectWindow.ReadOnly = true;
            this.tbCorrectWindow.Size = new System.Drawing.Size(886, 26);
            this.tbCorrectWindow.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(8, 143);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(252, 19);
            this.label20.TabIndex = 103;
            this.label20.Text = "Correct View Matrix Window:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(553, 275);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 19);
            this.label14.TabIndex = 32;
            this.label14.Text = "[Y]";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(338, 275);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 19);
            this.label15.TabIndex = 31;
            this.label15.Text = "Tr [X]";
            // 
            // tbResultNVTr2
            // 
            this.tbResultNVTr2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResultNVTr2.Location = new System.Drawing.Point(595, 268);
            this.tbResultNVTr2.MaxLength = 20;
            this.tbResultNVTr2.Name = "tbResultNVTr2";
            this.tbResultNVTr2.ReadOnly = true;
            this.tbResultNVTr2.Size = new System.Drawing.Size(140, 32);
            this.tbResultNVTr2.TabIndex = 101;
            this.tbResultNVTr2.Text = "0";
            this.tbResultNVTr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbResultNVTr1
            // 
            this.tbResultNVTr1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResultNVTr1.Location = new System.Drawing.Point(407, 268);
            this.tbResultNVTr1.MaxLength = 20;
            this.tbResultNVTr1.Name = "tbResultNVTr1";
            this.tbResultNVTr1.ReadOnly = true;
            this.tbResultNVTr1.Size = new System.Drawing.Size(140, 32);
            this.tbResultNVTr1.TabIndex = 100;
            this.tbResultNVTr1.Text = "0";
            this.tbResultNVTr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(553, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 19);
            this.label13.TabIndex = 28;
            this.label13.Text = "[Y]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(329, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 19);
            this.label12.TabIndex = 27;
            this.label12.Text = "Def [X]";
            // 
            // tbResultNVDef2
            // 
            this.tbResultNVDef2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResultNVDef2.Location = new System.Drawing.Point(595, 230);
            this.tbResultNVDef2.MaxLength = 20;
            this.tbResultNVDef2.Name = "tbResultNVDef2";
            this.tbResultNVDef2.ReadOnly = true;
            this.tbResultNVDef2.Size = new System.Drawing.Size(140, 32);
            this.tbResultNVDef2.TabIndex = 91;
            this.tbResultNVDef2.Text = "0";
            this.tbResultNVDef2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbResultNVDef1
            // 
            this.tbResultNVDef1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResultNVDef1.Location = new System.Drawing.Point(407, 230);
            this.tbResultNVDef1.MaxLength = 20;
            this.tbResultNVDef1.Name = "tbResultNVDef1";
            this.tbResultNVDef1.ReadOnly = true;
            this.tbResultNVDef1.Size = new System.Drawing.Size(140, 32);
            this.tbResultNVDef1.TabIndex = 90;
            this.tbResultNVDef1.Text = "0";
            this.tbResultNVDef1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(10, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "R[2]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(10, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "R[1]";
            // 
            // tbResult3
            // 
            this.tbResult3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResult3.Location = new System.Drawing.Point(61, 306);
            this.tbResult3.MaxLength = 20;
            this.tbResult3.Name = "tbResult3";
            this.tbResult3.ReadOnly = true;
            this.tbResult3.Size = new System.Drawing.Size(250, 32);
            this.tbResult3.TabIndex = 82;
            this.tbResult3.Text = "0";
            // 
            // tbResult2
            // 
            this.tbResult2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResult2.Location = new System.Drawing.Point(61, 268);
            this.tbResult2.MaxLength = 20;
            this.tbResult2.Name = "tbResult2";
            this.tbResult2.ReadOnly = true;
            this.tbResult2.Size = new System.Drawing.Size(250, 32);
            this.tbResult2.TabIndex = 81;
            this.tbResult2.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(10, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "R[0]";
            // 
            // lResultType
            // 
            this.lResultType.AutoSize = true;
            this.lResultType.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lResultType.Location = new System.Drawing.Point(88, 204);
            this.lResultType.Name = "lResultType";
            this.lResultType.Size = new System.Drawing.Size(18, 19);
            this.lResultType.TabIndex = 19;
            this.lResultType.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(10, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Result:";
            // 
            // tbResult1
            // 
            this.tbResult1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResult1.Location = new System.Drawing.Point(61, 230);
            this.tbResult1.MaxLength = 20;
            this.tbResult1.Name = "tbResult1";
            this.tbResult1.ReadOnly = true;
            this.tbResult1.Size = new System.Drawing.Size(250, 32);
            this.tbResult1.TabIndex = 80;
            this.tbResult1.Text = "0";
            // 
            // btnInspect
            // 
            this.btnInspect.BackColor = System.Drawing.Color.LightCyan;
            this.btnInspect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInspect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInspect.Location = new System.Drawing.Point(715, 34);
            this.btnInspect.Name = "btnInspect";
            this.btnInspect.Size = new System.Drawing.Size(155, 56);
            this.btnInspect.TabIndex = 20;
            this.btnInspect.Text = "Inspect";
            this.btnInspect.UseVisualStyleBackColor = false;
            this.btnInspect.Click += new System.EventHandler(this.btnInspect_Click);
            // 
            // tbVector
            // 
            this.tbVector.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbVector.Location = new System.Drawing.Point(196, 50);
            this.tbVector.MaxLength = 20;
            this.tbVector.Name = "tbVector";
            this.tbVector.Size = new System.Drawing.Size(145, 26);
            this.tbVector.TabIndex = 12;
            this.tbVector.Text = "-30 3 3";
            this.tbVector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(200, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Vector String:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(898, 235);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address Helper";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.tbOffsetDiff);
            this.groupBox4.Controls.Add(this.tbAddressDiff2);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.tbAddressDiff1);
            this.groupBox4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(6, 123);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(886, 100);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Offset Calculator";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(354, 52);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 24);
            this.label19.TabIndex = 8;
            this.label19.Text = "=>";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(398, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 19);
            this.label18.TabIndex = 9;
            this.label18.Text = "Offset:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(189, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 19);
            this.label17.TabIndex = 9;
            this.label17.Text = "Address 2:";
            // 
            // tbOffsetDiff
            // 
            this.tbOffsetDiff.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOffsetDiff.Location = new System.Drawing.Point(394, 49);
            this.tbOffsetDiff.MaxLength = 4;
            this.tbOffsetDiff.Name = "tbOffsetDiff";
            this.tbOffsetDiff.ReadOnly = true;
            this.tbOffsetDiff.Size = new System.Drawing.Size(76, 32);
            this.tbOffsetDiff.TabIndex = 8;
            this.tbOffsetDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAddressDiff2
            // 
            this.tbAddressDiff2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAddressDiff2.Location = new System.Drawing.Point(185, 49);
            this.tbAddressDiff2.MaxLength = 12;
            this.tbAddressDiff2.Name = "tbAddressDiff2";
            this.tbAddressDiff2.Size = new System.Drawing.Size(163, 32);
            this.tbAddressDiff2.TabIndex = 7;
            this.tbAddressDiff2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAddressDiff2.TextChanged += new System.EventHandler(this.tbAddressDiff2_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(10, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 19);
            this.label16.TabIndex = 8;
            this.label16.Text = "Address 1:";
            // 
            // tbAddressDiff1
            // 
            this.tbAddressDiff1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAddressDiff1.Location = new System.Drawing.Point(6, 49);
            this.tbAddressDiff1.MaxLength = 12;
            this.tbAddressDiff1.Name = "tbAddressDiff1";
            this.tbAddressDiff1.Size = new System.Drawing.Size(163, 32);
            this.tbAddressDiff1.TabIndex = 6;
            this.tbAddressDiff1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAddressDiff1.TextChanged += new System.EventHandler(this.tbAddressDiff1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbAddress);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbOffset);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.EqualLabel);
            this.groupBox3.Controls.Add(this.cbOperator);
            this.groupBox3.Controls.Add(this.tbAddressRes);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(6, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(886, 88);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Address Calculator";
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.dragPanel.Controls.Add(this.label23);
            this.dragPanel.Controls.Add(this.btnExit);
            this.dragPanel.Location = new System.Drawing.Point(-1, -1);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(924, 40);
            this.dragPanel.TabIndex = 10;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(9, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(190, 24);
            this.label23.TabIndex = 9;
            this.label23.Text = "Hack Util Tools";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Coral;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(875, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "⛌";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 656);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Util Tools";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlCornerSelector.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.dragPanel.ResumeLayout(false);
            this.dragPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbAddressRes;
        private System.Windows.Forms.TextBox tbOffset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EqualLabel;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbScreenWidth;
        private System.Windows.Forms.TextBox tbScreenHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMemoryArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbVector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInspect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lResultType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbResult3;
        private System.Windows.Forms.TextBox tbResult2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbResult1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbResultNVTr2;
        private System.Windows.Forms.TextBox tbResultNVTr1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbResultNVDef2;
        private System.Windows.Forms.TextBox tbResultNVDef1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbOffsetDiff;
        private System.Windows.Forms.TextBox tbAddressDiff2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbAddressDiff1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbCorrectWindow;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel pnlCornerSelector;
        private System.Windows.Forms.Button btnLUCorner;
        private System.Windows.Forms.Button btnRDCorner;
        private System.Windows.Forms.Button btnRUCorner;
        private System.Windows.Forms.Button btnLDCorner;
        private System.Windows.Forms.TextBox tbRange;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label23;
    }
}

