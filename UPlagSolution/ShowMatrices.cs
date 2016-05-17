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
    public partial class ShowMatrices : MetroForm
    {
        public Algorithm AlgorithmObject { get; set; }

        public ShowMatrices()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Matrix queryMatrix = new Matrix(AlgorithmObject._termFreqOfQuery);
            txtQueryMatrix.Text = queryMatrix.ToString("F3", " ", "\n|", "|"+Environment.NewLine,"|");
            Matrix corpusMatrix = new Matrix(AlgorithmObject._termWeightCorpus);
            txtCorpusMatrix.Text = corpusMatrix.ToString("F3", " ", "|", "|"+Environment.NewLine, "|");
        }

        private void btnNextSVD_Click(object sender, EventArgs e)
        {
            ShowSVDForm showSVDform = new ShowSVDForm();
            showSVDform.AlgorithmObject = AlgorithmObject;
            showSVDform.Visible = true;
            Visible = false;
        }
    }
}
