using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UPlagSolution.AlgorithmModules
{
    public class SynonymReplacement
    {
        public string[] ContentToBeSynonymReplaced { get; set; }

        public Dictionary<string,string> UrduDictionary { get; set; }

        public SynonymReplacement(string[] content)
        {
            ContentToBeSynonymReplaced = content;
            LoadDictionary();
        }

        private void LoadDictionary()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"Dictionary\Dictionary.txt");
            var lines = File.ReadAllLines(path);
            foreach (var item in lines)
            {
                string[] temp = item.Split(':'); // each time a line is read from dictionary, declare a new string array
                UrduDictionary.Add(temp[0], temp[1]);
            }
        }

        public void PerformSynonymReplacemnt()
        {
            
            for (int i = 0; i < ContentToBeSynonymReplaced.Length; i++)
            {
                if (UrduDictionary.ContainsKey(ContentToBeSynonymReplaced[i]))
                {
                    ContentToBeSynonymReplaced[i] = UrduDictionary.Where(x => x.Key == ContentToBeSynonymReplaced[i]).Select(p => p.Value).FirstOrDefault();
                }
                else
                {

                }
            }
        }
    }
}
