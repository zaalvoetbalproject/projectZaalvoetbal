namespace Project_Fifa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.matchInput = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.scoreTeam1 = new System.Windows.Forms.NumericUpDown();
            this.scoreTeam2 = new System.Windows.Forms.NumericUpDown();
            this.winnerInput = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gambleButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.predictionsBox = new System.Windows.Forms.ListBox();
            this.topGamblersBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTeam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTeam2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wedstrijd:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Team 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Team 2";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(96, 13);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(121, 20);
            this.nameInput.TabIndex = 5;
            // 
            // matchInput
            // 
            this.matchInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matchInput.FormattingEnabled = true;
            this.matchInput.Items.AddRange(new object[] {
            "Test 1",
            "Test 2",
            "Test 3",
            "Test 4",
            "Test 5"});
            this.matchInput.Location = new System.Drawing.Point(96, 49);
            this.matchInput.Name = "matchInput";
            this.matchInput.Size = new System.Drawing.Size(121, 21);
            this.matchInput.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "-";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // scoreTeam1
            // 
            this.scoreTeam1.Location = new System.Drawing.Point(96, 102);
            this.scoreTeam1.Name = "scoreTeam1";
            this.scoreTeam1.Size = new System.Drawing.Size(34, 20);
            this.scoreTeam1.TabIndex = 12;
            // 
            // scoreTeam2
            // 
            this.scoreTeam2.Location = new System.Drawing.Point(170, 102);
            this.scoreTeam2.Name = "scoreTeam2";
            this.scoreTeam2.Size = new System.Drawing.Size(34, 20);
            this.scoreTeam2.TabIndex = 13;
            // 
            // winnerInput
            // 
            this.winnerInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.winnerInput.FormattingEnabled = true;
            this.winnerInput.Items.AddRange(new object[] {
            "Team 1",
            "Team 2",
            "Gelijkspel"});
            this.winnerInput.Location = new System.Drawing.Point(96, 138);
            this.winnerInput.Name = "winnerInput";
            this.winnerInput.Size = new System.Drawing.Size(121, 21);
            this.winnerInput.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Winnaar:";
            // 
            // gambleButton
            // 
            this.gambleButton.Location = new System.Drawing.Point(170, 174);
            this.gambleButton.Name = "gambleButton";
            this.gambleButton.Size = new System.Drawing.Size(47, 23);
            this.gambleButton.TabIndex = 16;
            this.gambleButton.Text = "Gok";
            this.gambleButton.UseVisualStyleBackColor = true;
            this.gambleButton.Click += new System.EventHandler(this.gambleButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Top 10  gokkers:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // predictionsBox
            // 
            this.predictionsBox.FormattingEnabled = true;
            this.predictionsBox.Location = new System.Drawing.Point(15, 248);
            this.predictionsBox.Name = "predictionsBox";
            this.predictionsBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.predictionsBox.Size = new System.Drawing.Size(469, 186);
            this.predictionsBox.TabIndex = 18;
            this.predictionsBox.TabStop = false;
            this.predictionsBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // topGamblersBox
            // 
            this.topGamblersBox.FormattingEnabled = true;
            this.topGamblersBox.Location = new System.Drawing.Point(250, 27);
            this.topGamblersBox.Name = "topGamblersBox";
            this.topGamblersBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.topGamblersBox.Size = new System.Drawing.Size(234, 186);
            this.topGamblersBox.TabIndex = 19;
            this.topGamblersBox.TabStop = false;
            this.topGamblersBox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Voorspellingen:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(499, 446);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.topGamblersBox);
            this.Controls.Add(this.predictionsBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gambleButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.winnerInput);
            this.Controls.Add(this.scoreTeam2);
            this.Controls.Add(this.scoreTeam1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.matchInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Project Fifa";
            ((System.ComponentModel.ISupportInitialize)(this.scoreTeam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTeam2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.ComboBox matchInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown scoreTeam1;
        private System.Windows.Forms.NumericUpDown scoreTeam2;
        private System.Windows.Forms.ComboBox winnerInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button gambleButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox predictionsBox;
        private System.Windows.Forms.ListBox topGamblersBox;
        private System.Windows.Forms.Label label9;
    }
}

