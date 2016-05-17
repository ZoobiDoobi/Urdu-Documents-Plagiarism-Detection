namespace UPlagSolution
{
    partial class InputForm
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
            this.txtInputQuery = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAnalyze = new MetroFramework.Controls.MetroButton();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtResult7 = new System.Windows.Forms.TextBox();
            this.txtResult6 = new System.Windows.Forms.TextBox();
            this.txtResult5 = new System.Windows.Forms.TextBox();
            this.txtResult4 = new System.Windows.Forms.TextBox();
            this.txtResult3 = new System.Windows.Forms.TextBox();
            this.txtResult2 = new System.Windows.Forms.TextBox();
            this.txtResult1 = new System.Windows.Forms.TextBox();
            this.btnShowAlgorithmSteps = new MetroFramework.Controls.MetroButton();
            this.rankValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearAll = new MetroFramework.Controls.MetroButton();
            this.btnInputClear = new MetroFramework.Controls.MetroButton();
            this.btnResultsClear = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rankValueNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInputQuery
            // 
            // 
            // 
            // 
            this.txtInputQuery.CustomButton.Image = null;
            this.txtInputQuery.CustomButton.Location = new System.Drawing.Point(861, 2);
            this.txtInputQuery.CustomButton.Name = "";
            this.txtInputQuery.CustomButton.Size = new System.Drawing.Size(153, 153);
            this.txtInputQuery.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInputQuery.CustomButton.TabIndex = 1;
            this.txtInputQuery.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInputQuery.CustomButton.UseSelectable = true;
            this.txtInputQuery.CustomButton.Visible = false;
            this.txtInputQuery.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtInputQuery.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtInputQuery.Lines = new string[0];
            this.txtInputQuery.Location = new System.Drawing.Point(23, 83);
            this.txtInputQuery.MaxLength = 32767;
            this.txtInputQuery.Multiline = true;
            this.txtInputQuery.Name = "txtInputQuery";
            this.txtInputQuery.PasswordChar = '\0';
            this.txtInputQuery.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInputQuery.SelectedText = "";
            this.txtInputQuery.SelectionLength = 0;
            this.txtInputQuery.SelectionStart = 0;
            this.txtInputQuery.Size = new System.Drawing.Size(1017, 158);
            this.txtInputQuery.TabIndex = 0;
            this.txtInputQuery.UseSelectable = true;
            this.txtInputQuery.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInputQuery.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 55);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(210, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Paste Your Content Here:";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAnalyze.Location = new System.Drawing.Point(833, 247);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(207, 37);
            this.btnAnalyze.TabIndex = 2;
            this.btnAnalyze.Text = "Analyze It";
            this.btnAnalyze.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAnalyze.UseSelectable = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Green;
            this.btnBrowse.Location = new System.Drawing.Point(625, 247);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(202, 37);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse Document";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResult7);
            this.groupBox1.Controls.Add(this.txtResult6);
            this.groupBox1.Controls.Add(this.txtResult5);
            this.groupBox1.Controls.Add(this.txtResult4);
            this.groupBox1.Controls.Add(this.txtResult3);
            this.groupBox1.Controls.Add(this.txtResult2);
            this.groupBox1.Controls.Add(this.txtResult1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1017, 276);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // txtResult7
            // 
            this.txtResult7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtResult7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult7.Location = new System.Drawing.Point(6, 224);
            this.txtResult7.Name = "txtResult7";
            this.txtResult7.ReadOnly = true;
            this.txtResult7.Size = new System.Drawing.Size(1005, 27);
            this.txtResult7.TabIndex = 6;
            // 
            // txtResult6
            // 
            this.txtResult6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtResult6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult6.Location = new System.Drawing.Point(6, 191);
            this.txtResult6.Name = "txtResult6";
            this.txtResult6.ReadOnly = true;
            this.txtResult6.Size = new System.Drawing.Size(1005, 27);
            this.txtResult6.TabIndex = 5;
            // 
            // txtResult5
            // 
            this.txtResult5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtResult5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult5.Location = new System.Drawing.Point(6, 158);
            this.txtResult5.Name = "txtResult5";
            this.txtResult5.ReadOnly = true;
            this.txtResult5.Size = new System.Drawing.Size(1005, 27);
            this.txtResult5.TabIndex = 4;
            // 
            // txtResult4
            // 
            this.txtResult4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtResult4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult4.Location = new System.Drawing.Point(6, 125);
            this.txtResult4.Name = "txtResult4";
            this.txtResult4.ReadOnly = true;
            this.txtResult4.Size = new System.Drawing.Size(1005, 27);
            this.txtResult4.TabIndex = 3;
            // 
            // txtResult3
            // 
            this.txtResult3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtResult3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult3.Location = new System.Drawing.Point(6, 92);
            this.txtResult3.Name = "txtResult3";
            this.txtResult3.ReadOnly = true;
            this.txtResult3.Size = new System.Drawing.Size(1005, 27);
            this.txtResult3.TabIndex = 2;
            // 
            // txtResult2
            // 
            this.txtResult2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtResult2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult2.Location = new System.Drawing.Point(6, 59);
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.ReadOnly = true;
            this.txtResult2.Size = new System.Drawing.Size(1005, 27);
            this.txtResult2.TabIndex = 1;
            // 
            // txtResult1
            // 
            this.txtResult1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtResult1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult1.Location = new System.Drawing.Point(6, 26);
            this.txtResult1.Name = "txtResult1";
            this.txtResult1.ReadOnly = true;
            this.txtResult1.Size = new System.Drawing.Size(1005, 27);
            this.txtResult1.TabIndex = 0;
            this.txtResult1.TextChanged += new System.EventHandler(this.txtResult1_TextChanged);
            // 
            // btnShowAlgorithmSteps
            // 
            this.btnShowAlgorithmSteps.Location = new System.Drawing.Point(833, 299);
            this.btnShowAlgorithmSteps.Name = "btnShowAlgorithmSteps";
            this.btnShowAlgorithmSteps.Size = new System.Drawing.Size(207, 42);
            this.btnShowAlgorithmSteps.TabIndex = 6;
            this.btnShowAlgorithmSteps.Text = "Algorithm Steps";
            this.btnShowAlgorithmSteps.UseSelectable = true;
            this.btnShowAlgorithmSteps.Click += new System.EventHandler(this.btnShowAlgorithmSteps_Click);
            // 
            // rankValueNumericUpDown
            // 
            this.rankValueNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankValueNumericUpDown.Location = new System.Drawing.Point(140, 247);
            this.rankValueNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.rankValueNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rankValueNumericUpDown.Name = "rankValueNumericUpDown";
            this.rankValueNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.rankValueNumericUpDown.TabIndex = 7;
            this.rankValueNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rank K Value";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(625, 299);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(202, 42);
            this.btnClearAll.TabIndex = 9;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseSelectable = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnInputClear
            // 
            this.btnInputClear.Location = new System.Drawing.Point(417, 247);
            this.btnInputClear.Name = "btnInputClear";
            this.btnInputClear.Size = new System.Drawing.Size(202, 42);
            this.btnInputClear.TabIndex = 10;
            this.btnInputClear.Text = "Clear Input";
            this.btnInputClear.UseSelectable = true;
            this.btnInputClear.Click += new System.EventHandler(this.btnInputClear_Click);
            // 
            // btnResultsClear
            // 
            this.btnResultsClear.Location = new System.Drawing.Point(417, 299);
            this.btnResultsClear.Name = "btnResultsClear";
            this.btnResultsClear.Size = new System.Drawing.Size(202, 42);
            this.btnResultsClear.TabIndex = 11;
            this.btnResultsClear.Text = "Clear Results";
            this.btnResultsClear.UseSelectable = true;
            this.btnResultsClear.Click += new System.EventHandler(this.btnResultsClear_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 644);
            this.Controls.Add(this.btnResultsClear);
            this.Controls.Add(this.btnInputClear);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rankValueNumericUpDown);
            this.Controls.Add(this.btnShowAlgorithmSteps);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtInputQuery);
            this.Name = "InputForm";
            this.Text = "Check Plagiarism Against Documents";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputForm_FormClosing);
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rankValueNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtInputQuery;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAnalyze;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtResult5;
        private System.Windows.Forms.TextBox txtResult4;
        private System.Windows.Forms.TextBox txtResult3;
        private System.Windows.Forms.TextBox txtResult2;
        private System.Windows.Forms.TextBox txtResult1;
        private MetroFramework.Controls.MetroButton btnShowAlgorithmSteps;
        private System.Windows.Forms.TextBox txtResult7;
        private System.Windows.Forms.TextBox txtResult6;
        private System.Windows.Forms.NumericUpDown rankValueNumericUpDown;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnClearAll;
        private MetroFramework.Controls.MetroButton btnInputClear;
        private MetroFramework.Controls.MetroButton btnResultsClear;
    }
}

