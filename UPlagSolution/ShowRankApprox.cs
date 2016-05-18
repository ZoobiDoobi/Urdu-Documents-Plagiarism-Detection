using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bluebit.MatrixLibrary;
using UPlagSolution.AlgorithmModules;

namespace UPlagSolution
{
    public partial class ShowRankApprox : MetroForm
    {
        public Algorithm AlgorithmObject { get; set; }

        public ShowRankApprox()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            List<Matrix> lowRankedMatrices = AlgorithmObject.LowRankApproximation();
            Matrix lowRankedSMatrix = lowRankedMatrices[0];
            Matrix lowRankedUMatrix = lowRankedMatrices[1];
            Matrix lowRankedVMatrix = lowRankedMatrices[2];

            txtReducedSMatrix.Text = lowRankedSMatrix.ToString("F3", " ", "\n|", "|" + Environment.NewLine, "|");
            txtReducedUMatrix.Text = lowRankedUMatrix.ToString("F3", " ", "\n|", "|" + Environment.NewLine, "|");
            txtReducedVMatrix.Text = lowRankedVMatrix.ToString("F3", " ", "\n|", "|" + Environment.NewLine, "|"); 
        }

        private void btnNextQueryVectorsForm_Click(object sender, EventArgs e)
        {
            ShowQueryVectors showQueryVectors = new ShowQueryVectors();
            showQueryVectors.AlgorithmObject = AlgorithmObject;
            showQueryVectors.Visible = true;
            Visible = false;
        }

        private void btnPreviousSvdForm_Click(object sender, EventArgs e)
        {
            new ShowSVDForm().Visible = true;
            Visible = false;
        }
    }
}
