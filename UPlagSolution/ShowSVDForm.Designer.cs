namespace UPlagSolution
{
    partial class ShowSVDForm
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
            this.btnShow = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtUMatrix = new MetroFramework.Controls.MetroTextBox();
            this.txtSMatrix = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtVMatrix = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnNextQueryVectors = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(23, 74);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(137, 38);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show";
            this.btnShow.UseSelectable = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 131);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "U Matrix:";
            // 
            // txtUMatrix
            // 
            this.txtUMatrix.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtUMatrix.CustomButton.Image = null;
            this.txtUMatrix.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtUMatrix.CustomButton.Name = "";
            this.txtUMatrix.CustomButton.Size = new System.Drawing.Size(393, 393);
            this.txtUMatrix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUMatrix.CustomButton.TabIndex = 1;
            this.txtUMatrix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUMatrix.CustomButton.UseSelectable = true;
            this.txtUMatrix.CustomButton.Visible = false;
            this.txtUMatrix.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUMatrix.Lines = new string[0];
            this.txtUMatrix.Location = new System.Drawing.Point(23, 162);
            this.txtUMatrix.MaxLength = 32767;
            this.txtUMatrix.Multiline = true;
            this.txtUMatrix.Name = "txtUMatrix";
            this.txtUMatrix.PasswordChar = '\0';
            this.txtUMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUMatrix.SelectedText = "";
            this.txtUMatrix.SelectionLength = 0;
            this.txtUMatrix.SelectionStart = 0;
            this.txtUMatrix.Size = new System.Drawing.Size(441, 395);
            this.txtUMatrix.TabIndex = 2;
            this.txtUMatrix.UseSelectable = true;
            this.txtUMatrix.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUMatrix.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSMatrix
            // 
            // 
            // 
            // 
            this.txtSMatrix.CustomButton.Image = null;
            this.txtSMatrix.CustomButton.Location = new System.Drawing.Point(-154, 1);
            this.txtSMatrix.CustomButton.Name = "";
            this.txtSMatrix.CustomButton.Size = new System.Drawing.Size(393, 393);
            this.txtSMatrix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSMatrix.CustomButton.TabIndex = 1;
            this.txtSMatrix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSMatrix.CustomButton.UseSelectable = true;
            this.txtSMatrix.CustomButton.Visible = false;
            this.txtSMatrix.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSMatrix.Lines = new string[0];
            this.txtSMatrix.Location = new System.Drawing.Point(470, 162);
            this.txtSMatrix.MaxLength = 32767;
            this.txtSMatrix.Multiline = true;
            this.txtSMatrix.Name = "txtSMatrix";
            this.txtSMatrix.PasswordChar = '\0';
            this.txtSMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSMatrix.SelectedText = "";
            this.txtSMatrix.SelectionLength = 0;
            this.txtSMatrix.SelectionStart = 0;
            this.txtSMatrix.Size = new System.Drawing.Size(240, 395);
            this.txtSMatrix.TabIndex = 4;
            this.txtSMatrix.UseSelectable = true;
            this.txtSMatrix.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSMatrix.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(519, 131);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "S Matrix:";
            // 
            // txtVMatrix
            // 
            // 
            // 
            // 
            this.txtVMatrix.CustomButton.Image = null;
            this.txtVMatrix.CustomButton.Location = new System.Drawing.Point(-154, 1);
            this.txtVMatrix.CustomButton.Name = "";
            this.txtVMatrix.CustomButton.Size = new System.Drawing.Size(393, 393);
            this.txtVMatrix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVMatrix.CustomButton.TabIndex = 1;
            this.txtVMatrix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVMatrix.CustomButton.UseSelectable = true;
            this.txtVMatrix.CustomButton.Visible = false;
            this.txtVMatrix.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtVMatrix.Lines = new string[0];
            this.txtVMatrix.Location = new System.Drawing.Point(716, 162);
            this.txtVMatrix.MaxLength = 32767;
            this.txtVMatrix.Multiline = true;
            this.txtVMatrix.Name = "txtVMatrix";
            this.txtVMatrix.PasswordChar = '\0';
            this.txtVMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVMatrix.SelectedText = "";
            this.txtVMatrix.SelectionLength = 0;
            this.txtVMatrix.SelectionStart = 0;
            this.txtVMatrix.Size = new System.Drawing.Size(289, 395);
            this.txtVMatrix.TabIndex = 6;
            this.txtVMatrix.UseSelectable = true;
            this.txtVMatrix.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVMatrix.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(716, 134);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "V Matrix:";
            // 
            // btnNextQueryVectors
            // 
            this.btnNextQueryVectors.Location = new System.Drawing.Point(765, 563);
            this.btnNextQueryVectors.Name = "btnNextQueryVectors";
            this.btnNextQueryVectors.Size = new System.Drawing.Size(240, 38);
            this.btnNextQueryVectors.TabIndex = 7;
            this.btnNextQueryVectors.Text = "Next -> Rank K Approximation";
            this.btnNextQueryVectors.UseSelectable = true;
            this.btnNextQueryVectors.Click += new System.EventHandler(this.btnNextRank_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(519, 563);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(240, 38);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Previous <- Matrices Form";
            this.metroButton1.UseSelectable = true;
            // 
            // ShowSVDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 614);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnNextQueryVectors);
            this.Controls.Add(this.txtVMatrix);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtSMatrix);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtUMatrix);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnShow);
            this.Name = "ShowSVDForm";
            this.Text = "Singular Value Decomposition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnShow;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtUMatrix;
        private MetroFramework.Controls.MetroTextBox txtSMatrix;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtVMatrix;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnNextQueryVectors;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}