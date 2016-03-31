using Bluebit.MatrixLibrary;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using UPlagSolution.AlgorithmModules;

namespace UPlagSolution
{
    public partial class InputForm : MetroForm
    {
        private string queryContent;
        private string[] corpusDocuments;
        public InputForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files(*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                queryContent = File.ReadAllText(filePath);
                txtInputQuery.Text = queryContent;
            }
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            // This is temporary implementaion.take only text files in that folder.
            //This line will get the files names of all the text files in Corpus directory
            string[] fileNames = Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), @"Corpus"));
            corpusDocuments = new string[fileNames.Length];
            for (int i = 0; i < fileNames.Length; i++)
            {
                corpusDocuments[i] = File.ReadAllText(fileNames[i]);
            }
            Algorithm applyAlgorithm = new Algorithm(corpusDocuments, queryContent);
            List<Matrix> tempSvd = applyAlgorithm.LowRankApproximation();
            //txtCorpusVectors.Text = tempSvd[2].ToString();
            List<double> tempSimilarities = applyAlgorithm.QueryVectors();
            for (int i = 0; i < tempSimilarities.Count; i++)
            {
                tempSimilarities[i] = tempSimilarities[i] * 100;
                txtCosineSimilarity.Text += tempSimilarities[i].ToString("00.00")+"%" +" with document"+(i+1)+ Environment.NewLine;
            }
        }

        private void InputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Menu().Visible = true;
            Visible = false;
        }
    }
}
