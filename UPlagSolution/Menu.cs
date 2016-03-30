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
    public partial class Menu : MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void linkLabelParagraphMatching_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ParagraphMatchingForm().Visible = true;
            this.Visible = false;
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelQuery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new InputForm().Visible = true;
            this.Visible = false;
        }
    }
}
