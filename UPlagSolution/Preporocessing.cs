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
    public partial class Preporocessing : MetroForm
    {
        public Algorithm AlgObjPreProcessForm { get; set; }
        

        public Preporocessing()
        {
            InitializeComponent();
            
        }
        private void btnShowPreprocessing_Click(object sender, EventArgs e)
        {
            List<string> termsOfQueryAfterProcessing = AlgObjPreProcessForm.GenerateTermsOfQuery();
            for (int i = 0; i < termsOfQueryAfterProcessing.Count; i++)
            {
                txtPreprocessedQuery.Text += termsOfQueryAfterProcessing[i] + " |";
            }
            List<string> termsOfCorpusAfterProcessing = AlgObjPreProcessForm.GenerateTermsOfDocuments();
            foreach (var item in termsOfCorpusAfterProcessing)
            {
                txtPreprocessedCorpus.Text += item + " |";
            }
        }

        private void btnShowNextStep_Click(object sender, EventArgs e)
        {
            ShowMatrices showMatricesForm = new ShowMatrices();
            showMatricesForm.AlgorithmObject = AlgObjPreProcessForm;
            showMatricesForm.Visible = true;
            Visible = false;
        }
    }
}
