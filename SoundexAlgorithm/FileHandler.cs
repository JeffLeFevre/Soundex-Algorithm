using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundexAlgorithm
{
    public class FileHandler
    {
        private string dir;
        private StreamReader fileIn;
        private string fileData;
        private string[] nameArray;


        public FileHandler(string directory)
        {
            dir = directory;

            fileIn = new StreamReader(dir);

            //Creates one giant string from the file data
            fileData = fileIn.ReadToEnd();

            //Close the file, we're done
            fileIn.Close();
        }

        public string[] ScrubText()
        {
            //Uses the array of delimiters to split one string into a clean array of names
            string[] delimiters = { " ", "\t", "\r", "\n" };
            nameArray = fileData.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            for(int i = 0; i < nameArray.Length; i++)
            {
                //Normalize case to minimize number of comparisons
                //needed later.
                 nameArray[i] = nameArray[i].ToUpper();
            }

            return nameArray;
        }
    }
}
