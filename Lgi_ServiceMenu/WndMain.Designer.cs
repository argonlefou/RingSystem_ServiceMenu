namespace Lgi_ServiceMenu
{
    partial class WndMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WndMain));
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.Cbox_CreditContinue = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbox_CreditStart = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbox_FreePlay = new System.Windows.Forms.ComboBox();
            this.Cbox_DressCode = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Cbox_KidsMode = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Cbox_Region = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Cbox_Life = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Cbox_Difficulty = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Cbox_Advertise = new System.Windows.Forms.ComboBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "DRESS CODE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.Cbox_CreditContinue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Cbox_CreditStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cbox_FreePlay);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 169);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(61, -1);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(136, 16);
            this.label24.TabIndex = 22;
            this.label24.Text = "COIN ASSIGNMENTS";
            // 
            // Cbox_CreditContinue
            // 
            this.Cbox_CreditContinue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_CreditContinue.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox_CreditContinue.FormattingEnabled = true;
            this.Cbox_CreditContinue.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.Cbox_CreditContinue.Location = new System.Drawing.Point(202, 116);
            this.Cbox_CreditContinue.Name = "Cbox_CreditContinue";
            this.Cbox_CreditContinue.Size = new System.Drawing.Size(39, 24);
            this.Cbox_CreditContinue.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Credit(s) to continue";
            // 
            // Cbox_CreditStart
            // 
            this.Cbox_CreditStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_CreditStart.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox_CreditStart.FormattingEnabled = true;
            this.Cbox_CreditStart.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.Cbox_CreditStart.Location = new System.Drawing.Point(202, 86);
            this.Cbox_CreditStart.Name = "Cbox_CreditStart";
            this.Cbox_CreditStart.Size = new System.Drawing.Size(39, 24);
            this.Cbox_CreditStart.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Credit(s) to start";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Freeplay";
            // 
            // Cbox_FreePlay
            // 
            this.Cbox_FreePlay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_FreePlay.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox_FreePlay.FormattingEnabled = true;
            this.Cbox_FreePlay.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.Cbox_FreePlay.Location = new System.Drawing.Point(104, 32);
            this.Cbox_FreePlay.Name = "Cbox_FreePlay";
            this.Cbox_FreePlay.Size = new System.Drawing.Size(54, 24);
            this.Cbox_FreePlay.TabIndex = 0;
            // 
            // Cbox_DressCode
            // 
            this.Cbox_DressCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_DressCode.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox_DressCode.FormattingEnabled = true;
            this.Cbox_DressCode.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.Cbox_DressCode.Location = new System.Drawing.Point(215, 187);
            this.Cbox_DressCode.Name = "Cbox_DressCode";
            this.Cbox_DressCode.Size = new System.Drawing.Size(60, 24);
            this.Cbox_DressCode.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(12, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 82);
            this.panel1.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(78, -2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 16);
            this.label16.TabIndex = 21;
            this.label16.Text = "GAME ASSIGNMENTS";
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(441, 251);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(113, 36);
            this.Btn_Close.TabIndex = 31;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "KIDS MODE";
            // 
            // Cbox_KidsMode
            // 
            this.Cbox_KidsMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_KidsMode.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox_KidsMode.FormattingEnabled = true;
            this.Cbox_KidsMode.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.Cbox_KidsMode.Location = new System.Drawing.Point(215, 157);
            this.Cbox_KidsMode.Name = "Cbox_KidsMode";
            this.Cbox_KidsMode.Size = new System.Drawing.Size(60, 24);
            this.Cbox_KidsMode.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Cbox_Region);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Cbox_DressCode);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Cbox_KidsMode);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.Cbox_Life);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Cbox_Difficulty);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Cbox_Advertise);
            this.groupBox2.Location = new System.Drawing.Point(279, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 233);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // Cbox_Region
            // 
            this.Cbox_Region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_Region.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox_Region.FormattingEnabled = true;
            this.Cbox_Region.Items.AddRange(new object[] {
            "JPN",
            "CHN",
            "USA",
            "EXP"});
            this.Cbox_Region.Location = new System.Drawing.Point(215, 35);
            this.Cbox_Region.Name = "Cbox_Region";
            this.Cbox_Region.Size = new System.Drawing.Size(60, 24);
            this.Cbox_Region.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "CABINET REGION";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 16);
            this.label14.TabIndex = 10;
            this.label14.Text = "ADVERTISE SOUND";
            // 
            // Cbox_Life
            // 
            this.Cbox_Life.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_Life.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox_Life.FormattingEnabled = true;
            this.Cbox_Life.Items.AddRange(new object[] {
            "VERY EASY",
            "MEDIUM EASY",
            "NORMAL",
            "MEDIUM HARD",
            "VERY HARD"});
            this.Cbox_Life.Location = new System.Drawing.Point(154, 97);
            this.Cbox_Life.Name = "Cbox_Life";
            this.Cbox_Life.Size = new System.Drawing.Size(121, 24);
            this.Cbox_Life.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "LIFE";
            // 
            // Cbox_Difficulty
            // 
            this.Cbox_Difficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_Difficulty.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox_Difficulty.FormattingEnabled = true;
            this.Cbox_Difficulty.Items.AddRange(new object[] {
            "VERY EASY",
            "MEDIUM EASY",
            "NORMAL",
            "MEDIUM HARD",
            "VERY HARD"});
            this.Cbox_Difficulty.Location = new System.Drawing.Point(154, 65);
            this.Cbox_Difficulty.Name = "Cbox_Difficulty";
            this.Cbox_Difficulty.Size = new System.Drawing.Size(121, 24);
            this.Cbox_Difficulty.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "GAME DIFFICULTY";
            // 
            // Cbox_Advertise
            // 
            this.Cbox_Advertise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_Advertise.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox_Advertise.FormattingEnabled = true;
            this.Cbox_Advertise.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.Cbox_Advertise.Location = new System.Drawing.Point(215, 127);
            this.Cbox_Advertise.Name = "Cbox_Advertise";
            this.Cbox_Advertise.Size = new System.Drawing.Size(60, 24);
            this.Cbox_Advertise.TabIndex = 9;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(294, 251);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(113, 36);
            this.Btn_Save.TabIndex = 30;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // WndMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 298);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Btn_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WndMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Let\'s Go Island - Service Menu";
            this.Load += new System.EventHandler(this.WndMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox Cbox_CreditContinue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cbox_CreditStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbox_FreePlay;
        private System.Windows.Forms.ComboBox Cbox_DressCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cbox_KidsMode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox Cbox_Life;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Cbox_Difficulty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Cbox_Advertise;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.ComboBox Cbox_Region;
        private System.Windows.Forms.Label label4;
    }
}

