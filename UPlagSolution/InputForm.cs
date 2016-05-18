using Bluebit.MatrixLibrary;
using MetroFramework.Controls;
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
        public Algorithm applyAlgorithm;
        public InputForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Directory.GetCurrentDirectory();
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


            if (txtInputQuery.Text == "")
            {
                MessageBox.Show("Please Input Some Urdu Content", "Query Cannot Be Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                applyAlgorithm = new Algorithm(corpusDocuments, queryContent);
                applyAlgorithm.RankKValue = Convert.ToInt32(rankValueNumericUpDown.Value);
                List<Matrix> tempSvd = applyAlgorithm.LowRankApproximation();
                //txtCorpusVectors.Text = tempSvd[2].ToString();
                List<double> tempSimilarities = applyAlgorithm.QueryVectors();
                List<TextBox> resultTexboxes = new List<TextBox>();
                resultTexboxes.Add(txtResult1);
                resultTexboxes.Add(txtResult2);
                resultTexboxes.Add(txtResult3);
                resultTexboxes.Add(txtResult4);
                resultTexboxes.Add(txtResult5);
                for (int i = 0; i < tempSimilarities.Count; i++)
                {
                    //tempSimilarities[i] = tempSimilarities[i] * 100;
                    //resultTexboxes[i].Text += tempSimilarities[i].ToString("00.00") + "%" + " with document" + (i + 1);
                    if (tempSimilarities[i] >= 0.7071 && tempSimilarities[i] <= 1)
                    {
                        resultTexboxes[i].Text += "Query Document is Similar To Document" + (i + 1) + " (" + tempSimilarities[i].ToString("0.0000") + ")";
                        resultTexboxes[i].BackColor = System.Drawing.Color.Orange;
                    }
                    else if (tempSimilarities[i] >= 0 && tempSimilarities[i] < 0.7071)
                    {
                        resultTexboxes[i].Text += "Query Document is Disimilar To Document" + (i + 1) + " (" + tempSimilarities[i].ToString("0.0000") + ")";
                        resultTexboxes[i].BackColor = System.Drawing.Color.LightGreen;
                    }
                    else
                    {
                        resultTexboxes[i].Text += "Query Document is Unique To Document" + (i + 1) + " (" + tempSimilarities[i].ToString("0.0000") + ")";
                    }
                }
            }
        }

        private void InputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnShowAlgorithmSteps_Click(object sender, EventArgs e)
        {
            Preporocessing preprocessingForm = new Preporocessing();
            preprocessingForm.AlgObjPreProcessForm = applyAlgorithm;
            preprocessingForm.Visible = true;
            Visible = false;
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            
            //This is temporary implementaion.take only text files in that folder.
            //This line will get the files names of all the text files in Corpus directory
            string[] fileNames = Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), @"Corpus"));
            corpusDocuments = new string[fileNames.Length];
            for (int i = 0; i < fileNames.Length; i++)
            {
                corpusDocuments[i] = File.ReadAllText(fileNames[i]);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes();
            
        }
        private void ClearAllTextBoxes()
        {
            //I had to do this instead of foreach loop because of MetroTextBox :\
            txtInputQuery.Clear();
            txtResult1.Clear();txtResult1.BackColor = System.Drawing.Color.White;
            txtResult2.Clear(); txtResult2.BackColor = System.Drawing.Color.White;
            txtResult3.Clear(); txtResult3.BackColor = System.Drawing.Color.White;
            txtResult4.Clear(); txtResult4.BackColor = System.Drawing.Color.White;
            txtResult5.Clear(); txtResult5.BackColor = System.Drawing.Color.White;
            txtResult6.Clear(); txtResult6.BackColor = System.Drawing.Color.White;
            txtResult7.Clear(); txtResult7.BackColor = System.Drawing.Color.White;
        }

        private void txtResult1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnInputClear_Click(object sender, EventArgs e)
        {
            txtInputQuery.Clear();
        }

        private void btnResultsClear_Click(object sender, EventArgs e)
        {
            txtResult1.Clear(); txtResult1.BackColor = System.Drawing.Color.White;
            txtResult2.Clear(); txtResult2.BackColor = System.Drawing.Color.White;
            txtResult3.Clear(); txtResult3.BackColor = System.Drawing.Color.White;
            txtResult4.Clear(); txtResult4.BackColor = System.Drawing.Color.White;
            txtResult5.Clear(); txtResult5.BackColor = System.Drawing.Color.White;
            txtResult6.Clear(); txtResult6.BackColor = System.Drawing.Color.White;
            txtResult7.Clear(); txtResult7.BackColor = System.Drawing.Color.White;
        }
    }
}
