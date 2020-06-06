using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ListShuffling
{
    class Shuffle
    {
        private List<string> numbersList = new List<string>();
        private List<string> letterList = new List<string>();

        public void ReadLists()
        {
            using (FileStream input = File.OpenRead("lists.dat"))
            using (StreamReader reader = new StreamReader(input))
            {
                string data = reader.ReadToEnd();
                string[] dataToSplit = data.Split(";");
                string[] numbers = dataToSplit[0].Split(",");
                string[] letters = dataToSplit[1].Split(",");
                numbersList.AddRange(numbers);
                letterList.AddRange(letters);
            }
        }
        
        public void Shuffling()
        {
            List<string> outputList = new List<string>();
            if (numbersList.Count > letterList.Count)
                for (int i = 0; i < numbersList.Count; i++)
                {
                    outputList.Add(numbersList[i]);
                    if (i < letterList.Count)
                        outputList.Add(letterList[i]);
                }
            else
                for (int i = 0; i < letterList.Count; i++)
                {
                    outputList.Add(letterList[i]);
                    if (i<numbersList.Count)
                        outputList.Add(numbersList[i]);
                }
          
            foreach (string elements in outputList)
            {
                Console.WriteLine(elements);
            }
        }

    }
}
