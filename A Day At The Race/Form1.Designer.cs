namespace A_Day_At_The_Race
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.racetrackPictureBox = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.car3 = new System.Windows.Forms.PictureBox();
            this.car4 = new System.Windows.Forms.PictureBox();
            this.bettingGroup = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dogBet = new System.Windows.Forms.NumericUpDown();
            this.cashBet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.AhmedBetLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MhmdRadioButton = new System.Windows.Forms.RadioButton();
            this.AliRadioButton = new System.Windows.Forms.RadioButton();
            this.AhmedRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car4)).BeginInit();
            this.bettingGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBet)).BeginInit();
            this.SuspendLayout();
            // 
            // racetrackPictureBox
            // 
            this.racetrackPictureBox.BackColor = System.Drawing.Color.Red;
            this.racetrackPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("racetrackPictureBox.Image")));
            this.racetrackPictureBox.Location = new System.Drawing.Point(24, 23);
            this.racetrackPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.racetrackPictureBox.Name = "racetrackPictureBox";
            this.racetrackPictureBox.Size = new System.Drawing.Size(1171, 396);
            this.racetrackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrackPictureBox.TabIndex = 0;
            this.racetrackPictureBox.TabStop = false;
            // 
            // car1
            // 
            this.car1.Image = ((System.Drawing.Image)(resources.GetObject("car1.Image")));
            this.car1.Location = new System.Drawing.Point(24, 23);
            this.car1.Margin = new System.Windows.Forms.Padding(6);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(119, 80);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 1;
            this.car1.TabStop = false;
            // 
            // car2
            // 
            this.car2.Image = ((System.Drawing.Image)(resources.GetObject("car2.Image")));
            this.car2.Location = new System.Drawing.Point(24, 104);
            this.car2.Margin = new System.Windows.Forms.Padding(6);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(119, 110);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car2.TabIndex = 2;
            this.car2.TabStop = false;
            // 
            // car3
            // 
            this.car3.Image = ((System.Drawing.Image)(resources.GetObject("car3.Image")));
            this.car3.Location = new System.Drawing.Point(24, 215);
            this.car3.Margin = new System.Windows.Forms.Padding(6);
            this.car3.Name = "car3";
            this.car3.Size = new System.Drawing.Size(119, 110);
            this.car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.car3.TabIndex = 3;
            this.car3.TabStop = false;
            // 
            // car4
            // 
            this.car4.Image = ((System.Drawing.Image)(resources.GetObject("car4.Image")));
            this.car4.Location = new System.Drawing.Point(24, 325);
            this.car4.Margin = new System.Windows.Forms.Padding(6);
            this.car4.Name = "car4";
            this.car4.Size = new System.Drawing.Size(119, 94);
            this.car4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car4.TabIndex = 4;
            this.car4.TabStop = false;
            // 
            // bettingGroup
            // 
            this.bettingGroup.BackColor = System.Drawing.Color.NavajoWhite;
            this.bettingGroup.Controls.Add(this.button1);
            this.bettingGroup.Controls.Add(this.dogBet);
            this.bettingGroup.Controls.Add(this.cashBet);
            this.bettingGroup.Controls.Add(this.label2);
            this.bettingGroup.Controls.Add(this.button2);
            this.bettingGroup.Controls.Add(this.name);
            this.bettingGroup.Controls.Add(this.alBetLabel);
            this.bettingGroup.Controls.Add(this.bobBetLabel);
            this.bettingGroup.Controls.Add(this.AhmedBetLabel);
            this.bettingGroup.Controls.Add(this.label1);
            this.bettingGroup.Controls.Add(this.MhmdRadioButton);
            this.bettingGroup.Controls.Add(this.AliRadioButton);
            this.bettingGroup.Controls.Add(this.AhmedRadioButton);
            this.bettingGroup.Controls.Add(this.minimumBetLabel);
            this.bettingGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bettingGroup.Location = new System.Drawing.Point(24, 431);
            this.bettingGroup.Margin = new System.Windows.Forms.Padding(6);
            this.bettingGroup.Name = "bettingGroup";
            this.bettingGroup.Padding = new System.Windows.Forms.Padding(6);
            this.bettingGroup.Size = new System.Drawing.Size(1183, 326);
            this.bettingGroup.TabIndex = 5;
            this.bettingGroup.TabStop = false;
            this.bettingGroup.Text = "Betting";
            this.bettingGroup.Enter += new System.EventHandler(this.bettingGroup_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(344, -8);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 279);
            this.button1.TabIndex = 17;
            this.button1.Text = "Race!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dogBet
            // 
            this.dogBet.Location = new System.Drawing.Point(628, 277);
            this.dogBet.Margin = new System.Windows.Forms.Padding(6);
            this.dogBet.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogBet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogBet.Name = "dogBet";
            this.dogBet.Size = new System.Drawing.Size(94, 35);
            this.dogBet.TabIndex = 16;
            this.dogBet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cashBet
            // 
            this.cashBet.Location = new System.Drawing.Point(238, 273);
            this.cashBet.Margin = new System.Windows.Forms.Padding(6);
            this.cashBet.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.cashBet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cashBet.Name = "cashBet";
            this.cashBet.Size = new System.Drawing.Size(94, 35);
            this.cashBet.TabIndex = 15;
            this.cashBet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(364, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "bucks on car number";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 269);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 44);
            this.button2.TabIndex = 13;
            this.button2.Text = "Bets";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(20, 269);
            this.name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(73, 29);
            this.name.TabIndex = 12;
            this.name.Text = "name";
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(797, 198);
            this.alBetLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(386, 37);
            this.alBetLabel.TabIndex = 11;
            this.alBetLabel.Text = "MhmdBetLabel";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(797, 147);
            this.bobBetLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(386, 37);
            this.bobBetLabel.TabIndex = 10;
            this.bobBetLabel.Text = "AliBetLabel";
            // 
            // AhmedBetLabel
            // 
            this.AhmedBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AhmedBetLabel.Location = new System.Drawing.Point(797, 92);
            this.AhmedBetLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AhmedBetLabel.Name = "AhmedBetLabel";
            this.AhmedBetLabel.Size = new System.Drawing.Size(386, 37);
            this.AhmedBetLabel.TabIndex = 9;
            this.AhmedBetLabel.Text = "AhmedBetLabel";
            this.AhmedBetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(791, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bets";
            // 
            // MhmdRadioButton
            // 
            this.MhmdRadioButton.AutoSize = true;
            this.MhmdRadioButton.Location = new System.Drawing.Point(20, 202);
            this.MhmdRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.MhmdRadioButton.Name = "MhmdRadioButton";
            this.MhmdRadioButton.Size = new System.Drawing.Size(243, 33);
            this.MhmdRadioButton.TabIndex = 6;
            this.MhmdRadioButton.TabStop = true;
            this.MhmdRadioButton.Text = "MhmdRadioButton";
            this.MhmdRadioButton.UseVisualStyleBackColor = true;
            this.MhmdRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // AliRadioButton
            // 
            this.AliRadioButton.AutoSize = true;
            this.AliRadioButton.Location = new System.Drawing.Point(20, 146);
            this.AliRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.AliRadioButton.Name = "AliRadioButton";
            this.AliRadioButton.Size = new System.Drawing.Size(203, 33);
            this.AliRadioButton.TabIndex = 5;
            this.AliRadioButton.TabStop = true;
            this.AliRadioButton.Text = "AliRadioButton";
            this.AliRadioButton.UseVisualStyleBackColor = true;
            this.AliRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // AhmedRadioButton
            // 
            this.AhmedRadioButton.AutoSize = true;
            this.AhmedRadioButton.Location = new System.Drawing.Point(20, 96);
            this.AhmedRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.AhmedRadioButton.Name = "AhmedRadioButton";
            this.AhmedRadioButton.Size = new System.Drawing.Size(252, 33);
            this.AhmedRadioButton.TabIndex = 4;
            this.AhmedRadioButton.TabStop = true;
            this.AhmedRadioButton.Text = "AhmedRadioButton";
            this.AhmedRadioButton.UseVisualStyleBackColor = true;
            this.AhmedRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(14, 38);
            this.minimumBetLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(244, 31);
            this.minimumBetLabel.TabIndex = 3;
            this.minimumBetLabel.Text = "minimumBetLabel";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1248, 779);
            this.Controls.Add(this.bettingGroup);
            this.Controls.Add(this.car4);
            this.Controls.Add(this.car3);
            this.Controls.Add(this.car2);
            this.Controls.Add(this.car1);
            this.Controls.Add(this.racetrackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Car Race";
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car4)).EndInit();
            this.bettingGroup.ResumeLayout(false);
            this.bettingGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrackPictureBox;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car3;
        private System.Windows.Forms.PictureBox car4;
        private System.Windows.Forms.GroupBox bettingGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton MhmdRadioButton;
        private System.Windows.Forms.RadioButton AliRadioButton;
        private System.Windows.Forms.RadioButton AhmedRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label AhmedBetLabel;
        private System.Windows.Forms.NumericUpDown dogBet;
        private System.Windows.Forms.NumericUpDown cashBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

