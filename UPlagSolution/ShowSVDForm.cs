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
            ShowQueryVectors showQueryVectors = new ShowQueryVectors();
            showQueryVectors.AlgorithmObject = AlgorithmObject;
            showQueryVectors.Visible = true;

            Visible = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SVD tempSVd = AlgorithmObject.CalculateSVD();
            txtSMatrix.Text = tempSVd.S.ToString();
            txtUMatrix.Text = tempSVd.U.ToString();
            txtVMatrix.Text = tempSVd.V.ToString();
        }
    }
}
