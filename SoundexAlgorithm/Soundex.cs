using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SoundexAlgorithm;

namespace SoundexAlgorithm
{
    class Soundex
    {
        //This will hold each soundex result for printout and saving
        private static List<String> soundexArray = new List<String>();

        private static FileHandler currentFile = new FileHandler("input.txt");
        private static ConvertToSoundex soundex = new ConvertToSoundex();
        private static string[] names;

        static void Main(string[] args)
        {
            names = currentFile.ScrubText();  
            // Analyze each string - for each item in the array produce 
            // the appropriate soundex code in the soundex array
            foreach (string item in names) 
            {
                Console.WriteLine(soundex.Conversion(item));
            }

            //Save output to file output.txt

            //Output results to console
            //foreach (string item in soundexArray) 
            //{
            //    Console.WriteLine(item);
            //}

            //Pause so user can see output
            Console.ReadKey();
        }
    }
}

