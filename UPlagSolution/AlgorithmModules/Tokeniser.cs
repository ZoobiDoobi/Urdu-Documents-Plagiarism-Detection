using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace UPlagSolution.AlgorithmModules
{
    public class Tokeniser
    {
        public Tokeniser()
        {
            StopWordsHandler stopWordHandler = new StopWordsHandler();
        }
        /// <summary>
        /// This function tokenizes the string(content of each document one by one). It tokenize by using regular expressions
        /// Also, StopWords will also be removed here
        /// </summary>
        /// <param name="input"></param>
        /// <returns>it returns a string array whose each index contains a token.</returns>
        public string[] Tokenize(string documentContents)
        {
            string pattern = "[ ۔،؛:)(!؟/؎{}]"; //it will match space and other punctuation marks.
            Regex _regex = new Regex(pattern);
            string[] tokens = _regex.Split(documentContents);

            List<string> processedList = new List<string>(); // this list will contain words after punctuation removal and stopword removal

            for (int i = 0; i < tokens.Length; i++)
            {
                //Below line further checks if any character in RE is still in content, maybe a space character, which will be removed in if condition
                MatchCollection mc = _regex.Matches(tokens[i]); //Represents the set of successful matches found by iteratively applying a regular 

                //expression pattern to the input string.
                if (mc.Count <= 0 && tokens[i].Trim().Length > 0 && !StopWordsHandler.IsStopWord(tokens[i]))
                {
                    processedList.Add(tokens[i]);
                }
            }
            return processedList.ToArray();
        }
    }
}
