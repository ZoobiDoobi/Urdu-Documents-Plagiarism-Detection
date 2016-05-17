namespace UPlagSolution
{
    partial class ShowMatrices
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
            this.txtQueryMatrix = new MetroFramework.Controls.MetroTextBox();
            this.txtCorpusMatrix = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnNextSVD = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(29, 63);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(145, 32);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show";
            this.btnShow.UseSelectable = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 104);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Query TF Matrix";
            // 
            // txtQueryMatrix
            // 
            // 
            // 
            // 
            this.txtQueryMatrix.CustomButton.Image = null;
            this.txtQueryMatrix.CustomButton.Location = new System.Drawing.Point(-297, 1);
            this.txtQueryMatrix.CustomButton.Name = "";
            this.txtQueryMatrix.CustomButton.Size = new System.Drawing.Size(441, 441);
            this.txtQueryMatrix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQueryMatrix.CustomButton.TabIndex = 1;
            this.txtQueryMatrix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQueryMatrix.CustomButton.UseSelectable = true;
            this.txtQueryMatrix.CustomButton.Visible = false;
            this.txtQueryMatrix.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtQueryMatrix.Lines = new string[0];
            this.txtQueryMatrix.Location = new System.Drawing.Point(28, 126);
            this.txtQueryMatrix.MaxLength = 32767;
            this.txtQueryMatrix.Multiline = true;
            this.txtQueryMatrix.Name = "txtQueryMatrix";
            this.txtQueryMatrix.PasswordChar = '\0';
            this.txtQueryMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQueryMatrix.SelectedText = "";
            this.txtQueryMatrix.SelectionLength = 0;
            this.txtQueryMatrix.SelectionStart = 0;
            this.txtQueryMatrix.Size = new System.Drawing.Size(145, 443);
            this.txtQueryMatrix.TabIndex = 2;
            this.txtQueryMatrix.UseSelectable = true;
            this.txtQueryMatrix.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQueryMatrix.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCorpusMatrix
            // 
            // 
            // 
            // 
            this.txtCorpusMatrix.CustomButton.Image = null;
            this.txtCorpusMatrix.CustomButton.Location = new System.Drawing.Point(309, 1);
            this.txtCorpusMatrix.CustomButton.Name = "";
            this.txtCorpusMatrix.CustomButton.Size = new System.Drawing.Size(441, 441);
            this.txtCorpusMatrix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCorpusMatrix.CustomButton.TabIndex = 1;
            this.txtCorpusMatrix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCorpusMatrix.CustomButton.UseSelectable = true;
            this.txtCorpusMatrix.CustomButton.Visible = false;
            this.txtCorpusMatrix.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCorpusMatrix.Lines = new string[0];
            this.txtCorpusMatrix.Location = new System.Drawing.Point(179, 126);
            this.txtCorpusMatrix.MaxLength = 32767;
            this.txtCorpusMatrix.Multiline = true;
            this.txtCorpusMatrix.Name = "txtCorpusMatrix";
            this.txtCorpusMatrix.PasswordChar = '\0';
            this.txtCorpusMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCorpusMatrix.SelectedText = "";
            this.txtCorpusMatrix.SelectionLength = 0;
            this.txtCorpusMatrix.SelectionStart = 0;
            this.txtCorpusMatrix.Size = new System.Drawing.Size(751, 443);
            this.txtCorpusMatrix.TabIndex = 4;
            this.txtCorpusMatrix.UseSelectable = true;
            this.txtCorpusMatrix.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCorpusMatrix.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(179, 104);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(135, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Corpus TF-IDF Matrix";
            // 
            // btnNextSVD
            // 
            this.btnNextSVD.Location = new System.Drawing.Point(714, 575);
            this.btnNextSVD.Name = "btnNextSVD";
            this.btnNextSVD.Size = new System.Drawing.Size(216, 36);
            this.btnNextSVD.TabIndex = 5;
            this.btnNextSVD.Text = "Next -> SVD";
            this.btnNextSVD.UseSelectable = true;
            this.btnNextSVD.Click += new System.EventHandler(this.btnNextSVD_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(492, 575);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(216, 36);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Back <- Preprocessing";
            this.metroButton1.UseSelectable = true;
            // 
            // ShowMatrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 643);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnNextSVD);
            this.Controls.Add(this.txtCorpusMatrix);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtQueryMatrix);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnShow);
            this.Name = "ShowMatrices";
            this.Text = "Show Matrices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnShow;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtQueryMatrix;
        private MetroFramework.Controls.MetroTextBox txtCorpusMatrix;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnNextSVD;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}