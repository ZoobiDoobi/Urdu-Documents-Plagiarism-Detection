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
            this.txtQueryVectors = new MetroFramework.Controls.MetroTextBox();
            this.txtCorpusVectors = new MetroFramework.Controls.MetroTextBox();
            this.txtCosineSimilarity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txtInputQuery
            // 
            // 
            // 
            // 
            this.txtInputQuery.CustomButton.Image = null;
            this.txtInputQuery.CustomButton.Location = new System.Drawing.Point(779, 1);
            this.txtInputQuery.CustomButton.Name = "";
            this.txtInputQuery.CustomButton.Size = new System.Drawing.Size(237, 237);
            this.txtInputQuery.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInputQuery.CustomButton.TabIndex = 1;
            this.txtInputQuery.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInputQuery.CustomButton.UseSelectable = true;
            this.txtInputQuery.CustomButton.Visible = false;
            this.txtInputQuery.FontSize = MetroFramework.MetroTextBoxSize.Medium;
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
            this.txtInputQuery.Size = new System.Drawing.Size(1017, 239);
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
            this.btnAnalyze.Location = new System.Drawing.Point(914, 328);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(126, 37);
            this.btnAnalyze.TabIndex = 2;
            this.btnAnalyze.Text = "Analyze It";
            this.btnAnalyze.UseSelectable = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(782, 328);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(126, 37);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse Document";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtQueryVectors
            // 
            // 
            // 
            // 
            this.txtQueryVectors.CustomButton.Image = null;
            this.txtQueryVectors.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtQueryVectors.CustomButton.Name = "";
            this.txtQueryVectors.CustomButton.Size = new System.Drawing.Size(217, 217);
            this.txtQueryVectors.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQueryVectors.CustomButton.TabIndex = 1;
            this.txtQueryVectors.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQueryVectors.CustomButton.UseSelectable = true;
            this.txtQueryVectors.CustomButton.Visible = false;
            this.txtQueryVectors.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtQueryVectors.Lines = new string[0];
            this.txtQueryVectors.Location = new System.Drawing.Point(23, 402);
            this.txtQueryVectors.MaxLength = 32767;
            this.txtQueryVectors.Multiline = true;
            this.txtQueryVectors.Name = "txtQueryVectors";
            this.txtQueryVectors.PasswordChar = '\0';
            this.txtQueryVectors.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQueryVectors.SelectedText = "";
            this.txtQueryVectors.SelectionLength = 0;
            this.txtQueryVectors.SelectionStart = 0;
            this.txtQueryVectors.Size = new System.Drawing.Size(323, 219);
            this.txtQueryVectors.TabIndex = 4;
            this.txtQueryVectors.UseSelectable = true;
            this.txtQueryVectors.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQueryVectors.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCorpusVectors
            // 
            // 
            // 
            // 
            this.txtCorpusVectors.CustomButton.Image = null;
            this.txtCorpusVectors.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtCorpusVectors.CustomButton.Name = "";
            this.txtCorpusVectors.CustomButton.Size = new System.Drawing.Size(217, 217);
            this.txtCorpusVectors.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCorpusVectors.CustomButton.TabIndex = 1;
            this.txtCorpusVectors.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCorpusVectors.CustomButton.UseSelectable = true;
            this.txtCorpusVectors.CustomButton.Visible = false;
            this.txtCorpusVectors.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCorpusVectors.Lines = new string[0];
            this.txtCorpusVectors.Location = new System.Drawing.Point(370, 402);
            this.txtCorpusVectors.MaxLength = 32767;
            this.txtCorpusVectors.Multiline = true;
            this.txtCorpusVectors.Name = "txtCorpusVectors";
            this.txtCorpusVectors.PasswordChar = '\0';
            this.txtCorpusVectors.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCorpusVectors.SelectedText = "";
            this.txtCorpusVectors.SelectionLength = 0;
            this.txtCorpusVectors.SelectionStart = 0;
            this.txtCorpusVectors.Size = new System.Drawing.Size(323, 219);
            this.txtCorpusVectors.TabIndex = 5;
            this.txtCorpusVectors.UseSelectable = true;
            this.txtCorpusVectors.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCorpusVectors.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCosineSimilarity
            // 
            // 
            // 
            // 
            this.txtCosineSimilarity.CustomButton.Image = null;
            this.txtCosineSimilarity.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtCosineSimilarity.CustomButton.Name = "";
            this.txtCosineSimilarity.CustomButton.Size = new System.Drawing.Size(217, 217);
            this.txtCosineSimilarity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCosineSimilarity.CustomButton.TabIndex = 1;
            this.txtCosineSimilarity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCosineSimilarity.CustomButton.UseSelectable = true;
            this.txtCosineSimilarity.CustomButton.Visible = false;
            this.txtCosineSimilarity.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCosineSimilarity.Lines = new string[0];
            this.txtCosineSimilarity.Location = new System.Drawing.Point(717, 403);
            this.txtCosineSimilarity.MaxLength = 32767;
            this.txtCosineSimilarity.Multiline = true;
            this.txtCosineSimilarity.Name = "txtCosineSimilarity";
            this.txtCosineSimilarity.PasswordChar = '\0';
            this.txtCosineSimilarity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCosineSimilarity.SelectedText = "";
            this.txtCosineSimilarity.SelectionLength = 0;
            this.txtCosineSimilarity.SelectionStart = 0;
            this.txtCosineSimilarity.Size = new System.Drawing.Size(323, 219);
            this.txtCosineSimilarity.TabIndex = 6;
            this.txtCosineSimilarity.UseSelectable = true;
            this.txtCosineSimilarity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCosineSimilarity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 374);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(128, 25);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Query Vectors:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(370, 374);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(133, 25);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Corpus Vectors";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(717, 374);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(142, 25);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Cosine Similarity";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 628);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtCosineSimilarity);
            this.Controls.Add(this.txtCorpusVectors);
            this.Controls.Add(this.txtQueryVectors);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtInputQuery);
            this.Name = "InputForm";
            this.Text = "Latent Semantic Analysis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtInputQuery;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAnalyze;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroTextBox txtQueryVectors;
        private MetroFramework.Controls.MetroTextBox txtCorpusVectors;
        private MetroFramework.Controls.MetroTextBox txtCosineSimilarity;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}

