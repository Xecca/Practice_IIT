using System.Collections.Generic;

namespace TextAnalysis
{
    static class TextGeneratorTask
    {
        public static string FinalPhrase(List<string> listPhB)
        {
            var finalPhrase = "";
            foreach (var word in listPhB)
            {
                if (finalPhrase == "")
                    finalPhrase = word;
                else
                    finalPhrase = finalPhrase + " " + word;
            }
            return finalPhrase;
        }

        public static string ContinuePhrase(
            Dictionary<string, string> nextWords,
            string phraseBeginning,
            int wordsCount)
        {
            int i = 0;
            if (wordsCount > 0)
            {
                var arrPhB = phraseBeginning.Split(' ');
                List<string> listPhB = new List<string>();
                foreach (var word in arrPhB)
                    listPhB.Add(word);
                while (i < wordsCount)
                {
                    //int lenPhr = listPhB.Count;
                    if (listPhB.Count >= 2 && nextWords.ContainsKey(listPhB[listPhB.Count - 2] + " " + listPhB[listPhB.Count - 1]))
                        listPhB.Add(nextWords[listPhB[listPhB.Count - 2] + " " + listPhB[listPhB.Count - 1]]);
                    else if (nextWords.ContainsKey(listPhB[listPhB.Count - 1]))
                        listPhB.Add(nextWords[listPhB[listPhB.Count - 1]]);
                    else
                        break;
                    i++;
                }
                phraseBeginning = FinalPhrase(listPhB);
            }

            return phraseBeginning;
        }
    }
}