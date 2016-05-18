using Bluebit.MatrixLibrary;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UPlagSolution.AlgorithmModules;

namespace UPlagSolution
{
    public partial class ShowSVDForm : MetroForm
    {
        public Algorithm AlgorithmObject { get; set; }

        public ShowSVDForm()
        {
            InitializeComponent();
        }

        private void btnNextRank_Click(object sender, EventArgs e)
        {
            ShowRankApprox showRankApprox = new ShowRankApprox();
            showRankApprox.AlgorithmObject = AlgorithmObject;
            showRankApprox.Visible = true;

            Visible = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SVD tempSVd = AlgorithmObject.CalculateSVD();
            txtSMatrix.Text = tempSVd.S.ToString("F3", " ", "\n|", "|" + Environment.NewLine, "|");
            txtUMatrix.Text = tempSVd.U.ToString("F3", "", "\n|", "|" + Environment.NewLine, "|");
            txtVMatrix.Text = tempSVd.V.ToString("F3", " ", "\n|", "|" + Environment.NewLine, "|");
        }

        private void backMatricesForm_Click(object sender, EventArgs e)
        {
            new ShowMatrices().Visible = true;
            Visible = false;
        }
    }
}
