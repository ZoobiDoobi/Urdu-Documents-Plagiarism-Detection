using System;
using System.Collections.Generic;
using System.Collections;
using Bluebit.MatrixLibrary;
namespace UPlagSolution.AlgorithmModules
{
    public class Algorithm
    {
        private string _queryDocument;
        private string[] _corpusDocuments;
        private int _totalCorpusDocs;
        private int _totalUniqueTerms = 0;


        private List<string> _allTermsOfQuery = new List<string>();
        private List<string> _allTermsOfCorpus = new List<string>();
        private Dictionary<string, int> _termIndex = new Dictionary<string, int>();
        public List<double> _similarities = new List<double>();

        private int[] _maxTermFreqCorpus;
        private int _maxTermFreqQuery = 0; //Should it be initialized to zero?
        private int[] _docFreq;
        private int[,] _termFreqOfCorpus; 
        public double[,] _termFreqOfQuery;
        public double[,] _termWeightCorpus; // this will contain our final tf-idf matrix of corpus

        public int RankKValue { get; set; }

        public double[] FinalQueryVectors;


        public Algorithm(string[] documents, string query)
        {
            _queryDocument = query;
            _corpusDocuments = documents;
            _totalCorpusDocs = documents.Length;
            Initializer();
        }

        public Algorithm()
        {

        }

        private void Initializer()
        {
            _allTermsOfCorpus = GenerateTermsOfDocuments();
            _allTermsOfQuery = GenerateTermsOfQuery();
            int count = 0; //This approach can create problems though. so keep it in mind.
            foreach (var item in _allTermsOfCorpus)
            {
                //Indexing is to be done so every key must be unique.
                if (!_termIndex.ContainsKey(item))
                {
                    _termIndex.Add(item, count);
                    count++;
                }
            }
            foreach (var item in _allTermsOfQuery)
            {
                if (!_termIndex.ContainsKey(item))
                {
                    _termIndex.Add(item, count);
                    count++;
                }
            }
            //Below are all the initializations required.
            _totalUniqueTerms = count;
            _termFreqOfCorpus = new int[_totalUniqueTerms, _totalCorpusDocs];
            _termFreqOfQuery = new double[_totalUniqueTerms, 1];
            _termWeightCorpus = new double[_totalUniqueTerms, _totalCorpusDocs];
            _docFreq = new int[_totalUniqueTerms]; //
            _maxTermFreqCorpus = new int[_totalCorpusDocs];

            GenerateTermFreqOfCorpus();
            GenerateTermFreqOfQuery();
            GenerateTermWeightOfCorpus();

        }

        public int GetTermIndex(string term)
        {
            object index = _termIndex[term];
            if (index == null)
            {
                return -1;
            }
            else
            {
                return (int)index;
            }
        }

        public List<string> GenerateTermsOfDocuments()
        {
            List<string> _termsList = new List<string>();
            for (int i = 0; i < _corpusDocuments.Length; i++)
            {
                Tokeniser _tokeniser = new Tokeniser();
                string[] _termsArrayOneDoc = _tokeniser.Tokenize(_corpusDocuments[i]);
                for (int j = 0; j < _termsArrayOneDoc.Length; j++)
                {
                    _termsList.Add(_termsArrayOneDoc[j]);
                }
            }
            return _termsList;
        }

        public List<string> GenerateTermsOfQuery()
        {
            List<string> _termsList = new List<string>();
            Tokeniser _tokeniser = new Tokeniser();
            string[] _termsArrayQuery = _tokeniser.Tokenize(_queryDocument);
            for (int i = 0; i < _termsArrayQuery.Length; i++)
            {
                _termsList.Add(_termsArrayQuery[i]);
            }
            return _termsList;
        }

        /// <summary>
        /// This function is going to count the word and tell how many time it occuered.
        /// </summary>
        /// <param name="document"></param>
        /// <returns></returns>
        public Dictionary<string, int> GetTermOccurence(string document)
        {
            Tokeniser _tokeniser = new Tokeniser();
            string[] terms = _tokeniser.Tokenize(document);
            string[] distinctTerms = GetDistinctWords(terms);
            Array.Sort(terms);
            Dictionary<string, int> _termsAndOccurences = new Dictionary<string, int>();
            for (int i = 0; i < distinctTerms.Length; i++)
            {
                int temp = CountWords(distinctTerms[i], terms);
                _termsAndOccurences.Add(distinctTerms[i], temp);
            }
            return _termsAndOccurences;
        }
        /// <summary>
        /// This method will return distinct words
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string[] GetDistinctWords(string[] input)
        {
            if (input == null)
            {
                return new string[0];
            }
            else
            {
                List<string> uniques = new List<string>();
                for (int i = 0; i < input.Length; i++)
                {
                    if (!uniques.Contains(input[i]))
                    {
                        uniques.Add(input[i]);
                    }
                }
                return uniques.ToArray();
            }
        }

        /// <summary>
        /// This method will count the distinct words
        /// </summary>
        /// <param name="word"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        private int CountWords(string word, string[] words)
        {
            int itemIndex = Array.BinarySearch(words, word);
            if (itemIndex > 0)
            {
                while (itemIndex > 0 && words[itemIndex].Equals(word))
                {
                    itemIndex--;
                }

            }
            int count = 0;
            while (itemIndex < words.Length && itemIndex >= 0)
            {
                if (words[itemIndex].Equals(word))
                {
                    count++;
                }
                itemIndex++;
                if (itemIndex < words.Length)
                {
                    if (!words[itemIndex].Equals(word))
                    {
                        break;
                    }
                }
            }
            return count;
        }

        /// <summary>
        /// This function will generate a document-word matrix which will tell how many 
        /// times a particular word has occured in document.
        /// </summary>
        /// <returns>Document word matrix of stored documents</returns>
        private void GenerateTermFreqOfCorpus()
        {
            for (int i = 0; i < _totalCorpusDocs; i++)
            {
                string currentDocument = _corpusDocuments[i];
                Dictionary<string, int> occurencesOfTerms = GetTermOccurence(currentDocument);
                foreach (var item in occurencesOfTerms)
                {
                    string term = item.Key;
                    int occurences = item.Value;
                    int termIndex = GetTermIndex(term);
                    _termFreqOfCorpus[termIndex, i] = occurences;
                    _docFreq[termIndex]++;
                    if (occurences > _maxTermFreqCorpus[i])
                    {
                        _maxTermFreqCorpus[i] = occurences;
                    }
                }
            }
        }
        /// <summary>
        /// same as above but for query document
        /// </summary>
        /// <returns></returns>
        public double[,] GenerateTermFreqOfQuery()
        {
            Dictionary<string, int> occurenceOfTerms = GetTermOccurence(_queryDocument);
            foreach (var item in occurenceOfTerms)
            {
                string term = item.Key;
                int occurences = item.Value;
                int termIndex = GetTermIndex(term);
                _termFreqOfQuery[termIndex, 0] = occurences;
                //_docFreq[termIndex]++; //Ask sir about this line.
                //if (occurences >  _maxTermFreqQuery)
                //{
                //    _maxTermFreqQuery = occurences;
                //}
            }
            return _termFreqOfQuery;
        }


        /// <summary>
        /// This function will normalize the values of term frequency matrices
        /// </summary>
        /// <param name="term"></param>
        /// <param name="doc"></param>
        /// <returns></returns>
        public double GetTermFrequency(int term, int doc)
        {
            int frequency = _termFreqOfCorpus[term, doc];//this line will give frequency of a term.
            //int maxFrequency = _maxTermFreqCorpus[doc]; //Max Term Frequency in that document.
            int numberOfWordsInDocument = _corpusDocuments[doc].Length;
            return ((double)frequency / numberOfWordsInDocument); //Divide frequency of term with max value of tf in that document.
        }

        private double GetInverseDocumentFreq(int term)
        {
            double idf = 0.0;
            int df = _docFreq[term];  //frequency of that term in all documents.
            try
            {
                double temp = ((double)_totalCorpusDocs / df);
                idf = Math.Log(temp,2);  
            }
            catch(DivideByZeroException dze)
            {
                idf = 0.0;      
            }
            return idf;
             
        }
        
        public double ComputeTermWeight(int term, int doc)
        {
            double tf = GetTermFrequency(term, doc);
            double idf = GetInverseDocumentFreq(term);
            return tf * idf;
        }
        public void GenerateTermWeightOfCorpus()
        {
            for (int i = 0; i < _totalUniqueTerms; i++)
            {
                for (int j = 0; j < _totalCorpusDocs; j++)
                {
                    _termWeightCorpus[i, j] = ComputeTermWeight(i, j);
                    if (double.IsNaN(_termWeightCorpus[i, j]))
                    {
                        _termWeightCorpus[i, j] = 0.0;
                    }
                }
            }
        }
        /// <summary>
        /// This method will calculate the SVD of Term Frequency Matrix of Stored Documents
        /// </summary>
        /// <returns></returns>
        public SVD CalculateSVD()
        {
            Matrix tempMatrix = new Matrix(_termWeightCorpus);
            SVD tempsvd = new SVD(tempMatrix);
            return tempsvd;

        }

        public List<Matrix> LowRankApproximation()
        {
            SVD tempSvd = CalculateSVD();
            Matrix afterRankU = tempSvd.U.SubMatrix(0, tempSvd.U.Rows - 1, 0, RankKValue);
            Matrix afterRankVH = tempSvd.VH.SubMatrix(0, tempSvd.VH.Rows - 1, 0, RankKValue);
            Matrix afterRankV = tempSvd.V.SubMatrix(0, tempSvd.V.Rows - 1, 0, RankKValue);
            Matrix afterRankS = tempSvd.S.SubMatrix(0, RankKValue, 0, RankKValue); 
            List<Matrix> reducedMatrices = new List<Matrix>();

            reducedMatrices.Add(afterRankS);
            reducedMatrices.Add(afterRankU);
            reducedMatrices.Add(afterRankV);
            reducedMatrices.Add(afterRankVH);
            return reducedMatrices;

        }
        public List<double> QueryVectors()
        {
            //V matrix contains vectors of stored documents, we need of vector of query document too.
            //So there is a formula for that.
            Matrix queryMatrix = new Matrix(_termFreqOfQuery);
            Matrix transposeQueryMatrix = queryMatrix.Transpose();
            List<Matrix> _reducedMatrices = LowRankApproximation();
            Matrix reducedS = _reducedMatrices[0];
            Matrix reducedU = _reducedMatrices[1];
            Matrix inverseOfS = reducedS.Inverse();
            Matrix reducedV = _reducedMatrices[2];
            double[,] documentVectors = reducedV.ToArray();


            //Since we are going to multiply three matrices, which we can't at once.
            //so we will store the results of qT * uK in temp and multiply it with Sk
            Matrix temp = Matrix.Multiply(transposeQueryMatrix, reducedU);
            Matrix finalQueryVector = Matrix.Multiply(temp, inverseOfS);


            //Converting back from Matrix To 2D Array
            double[,] finalQueryArray = finalQueryVector.ToArray();

            //Convert this 2D array having single row into 1D Array
            FinalQueryVectors = Convert2DTo1DArray(finalQueryArray);

            double[] vectorOfDocuments = new double[documentVectors.GetLength(1)];
            for (int i = 0; i < documentVectors.GetLength(0); i++)
            {
                for (int j = 0; j < documentVectors.GetLength(1); j++)
                {
                    vectorOfDocuments[j] = documentVectors[i, j];
                }
                _similarities.Add(CosineSimilarity.CalculateCosineSimilarity(FinalQueryVectors, vectorOfDocuments));
            }
           
            return _similarities;
        }
       
        public double[] Convert2DTo1DArray(double[,] convertArray)
        {
            double[] tempSingle = new double[convertArray.Length];
            for (int i = 0; i < convertArray.GetLength(0); i++)
            {
                for (int j = 0; j < convertArray.GetLength(1); j++)
                {
                    tempSingle[j] = convertArray[i, j];
                }

            }
            return tempSingle;
        }
    }
}
