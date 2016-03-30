namespace UPlagSolution
{
    partial class Menu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabelParagraphMatching = new System.Windows.Forms.LinkLabel();
            this.linkLabelQuery = new System.Windows.Forms.LinkLabel();
            this.linkLabelWeb = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 232);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabelParagraphMatching
            // 
            this.linkLabelParagraphMatching.AutoSize = true;
            this.linkLabelParagraphMatching.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelParagraphMatching.Location = new System.Drawing.Point(210, 99);
            this.linkLabelParagraphMatching.Name = "linkLabelParagraphMatching";
            this.linkLabelParagraphMatching.Size = new System.Drawing.Size(263, 21);
            this.linkLabelParagraphMatching.TabIndex = 1;
            this.linkLabelParagraphMatching.TabStop = true;
            this.linkLabelParagraphMatching.Text = "Paragraph Matching Using N-Gram\r\n";
            this.linkLabelParagraphMatching.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelParagraphMatching_LinkClicked);
            // 
            // linkLabelQuery
            // 
            this.linkLabelQuery.AutoSize = true;
            this.linkLabelQuery.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelQuery.Location = new System.Drawing.Point(210, 147);
            this.linkLabelQuery.Name = "linkLabelQuery";
            this.linkLabelQuery.Size = new System.Drawing.Size(246, 21);
            this.linkLabelQuery.TabIndex = 2;
            this.linkLabelQuery.TabStop = true;
            this.linkLabelQuery.Text = "Query document against Corpus";
            this.linkLabelQuery.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelQuery_LinkClicked);
            // 
            // linkLabelWeb
            // 
            this.linkLabelWeb.AutoSize = true;
            this.linkLabelWeb.Enabled = false;
            this.linkLabelWeb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelWeb.Location = new System.Drawing.Point(210, 207);
            this.linkLabelWeb.Name = "linkLabelWeb";
            this.linkLabelWeb.Size = new System.Drawing.Size(120, 21);
            this.linkLabelWeb.TabIndex = 3;
            this.linkLabelWeb.TabStop = true;
            this.linkLabelWeb.Text = "Search on Web";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 297);
            this.Controls.Add(this.linkLabelWeb);
            this.Controls.Add(this.linkLabelQuery);
            this.Controls.Add(this.linkLabelParagraphMatching);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelParagraphMatching;
        private System.Windows.Forms.LinkLabel linkLabelQuery;
        private System.Windows.Forms.LinkLabel linkLabelWeb;
    }
}