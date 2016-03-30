using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UPlagSolution
{
    public partial class ParagraphMatchingForm : MetroForm
    {
        public ParagraphMatchingForm()
        {
            InitializeComponent();
        }

        private void ParagraphMatchingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Menu().Visible = true;
            this.Visible = false;
        }
    }
}
