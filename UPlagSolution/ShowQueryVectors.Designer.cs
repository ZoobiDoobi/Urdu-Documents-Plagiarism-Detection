namespace UPlagSolution
{
    partial class ShowQueryVectors
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
            this.btnShowQueryVectors = new MetroFramework.Controls.MetroButton();
            this.txtQueryVetors = new MetroFramework.Controls.MetroTextBox();
            this.txtSimilarities = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnShowQueryVectors
            // 
            this.btnShowQueryVectors.Location = new System.Drawing.Point(23, 63);
            this.btnShowQueryVectors.Name = "btnShowQueryVectors";
            this.btnShowQueryVectors.Size = new System.Drawing.Size(113, 31);
            this.btnShowQueryVectors.TabIndex = 0;
            this.btnShowQueryVectors.Text = "Show";
            this.btnShowQueryVectors.UseSelectable = true;
            this.btnShowQueryVectors.Click += new System.EventHandler(this.btnShowQueryVectors_Click);
            // 
            // txtQueryVetors
            // 
            // 
            // 
            // 
            this.txtQueryVetors.CustomButton.Image = null;
            this.txtQueryVetors.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtQueryVetors.CustomButton.Name = "";
            this.txtQueryVetors.CustomButton.Size = new System.Drawing.Size(327, 327);
            this.txtQueryVetors.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQueryVetors.CustomButton.TabIndex = 1;
            this.txtQueryVetors.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQueryVetors.CustomButton.UseSelectable = true;
            this.txtQueryVetors.CustomButton.Visible = false;
            this.txtQueryVetors.Lines = new string[0];
            this.txtQueryVetors.Location = new System.Drawing.Point(23, 116);
            this.txtQueryVetors.MaxLength = 32767;
            this.txtQueryVetors.Multiline = true;
            this.txtQueryVetors.Name = "txtQueryVetors";
            this.txtQueryVetors.PasswordChar = '\0';
            this.txtQueryVetors.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQueryVetors.SelectedText = "";
            this.txtQueryVetors.SelectionLength = 0;
            this.txtQueryVetors.SelectionStart = 0;
            this.txtQueryVetors.Size = new System.Drawing.Size(476, 329);
            this.txtQueryVetors.TabIndex = 1;
            this.txtQueryVetors.UseSelectable = true;
            this.txtQueryVetors.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQueryVetors.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSimilarities
            // 
            // 
            // 
            // 
            this.txtSimilarities.CustomButton.Image = null;
            this.txtSimilarities.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtSimilarities.CustomButton.Name = "";
            this.txtSimilarities.CustomButton.Size = new System.Drawing.Size(327, 327);
            this.txtSimilarities.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSimilarities.CustomButton.TabIndex = 1;
            this.txtSimilarities.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSimilarities.CustomButton.UseSelectable = true;
            this.txtSimilarities.CustomButton.Visible = false;
            this.txtSimilarities.Lines = new string[0];
            this.txtSimilarities.Location = new System.Drawing.Point(505, 116);
            this.txtSimilarities.MaxLength = 32767;
            this.txtSimilarities.Multiline = true;
            this.txtSimilarities.Name = "txtSimilarities";
            this.txtSimilarities.PasswordChar = '\0';
            this.txtSimilarities.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSimilarities.SelectedText = "";
            this.txtSimilarities.SelectionLength = 0;
            this.txtSimilarities.SelectionStart = 0;
            this.txtSimilarities.Size = new System.Drawing.Size(476, 329);
            this.txtSimilarities.TabIndex = 2;
            this.txtSimilarities.UseSelectable = true;
            this.txtSimilarities.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSimilarities.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ShowQueryVectors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 468);
            this.Controls.Add(this.txtSimilarities);
            this.Controls.Add(this.txtQueryVetors);
            this.Controls.Add(this.btnShowQueryVectors);
            this.Name = "ShowQueryVectors";
            this.Text = "Show Query Vectors";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnShowQueryVectors;
        private MetroFramework.Controls.MetroTextBox txtQueryVetors;
        private MetroFramework.Controls.MetroTextBox txtSimilarities;
    }
}