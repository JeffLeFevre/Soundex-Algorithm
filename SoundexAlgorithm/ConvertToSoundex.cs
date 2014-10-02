using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundexAlgorithm
{
    class ConvertToSoundex
    {
        private string converted;

        public string Conversion(string toConvert) 
        {
            //Used to build the output
            StringBuilder temp = new StringBuilder();

            //Using StringReader we can look at each letter in the word
            StringReader c = new StringReader(toConvert);

            //Save the first letter
            temp.Append(Convert.ToChar(c.Read()));

            //Iterate through toConvert and change any letters needing changed
            //Ignore vowels and deal with w, h on next pass

            for (int i = 1; i < toConvert.Length; i++ )
            {

                if((i+1) < toConvert.Length && toConvert.Substring(i,1).Equals(toConvert.Substring((i+1),1)))
                {
                    //If the current letter and subsequent letter are the same, remove
                    //first - a bit of a cheat since it's supposed to remove the second according to the wiki.
                    
                    i++;

                }

                switch (toConvert[i])
                {
                    case 'A':
                        //Remove vowels from the produced string by removing them
                        break;

                    case 'E':
                        break;

                    case 'I':
                        break;

                    case 'O':
                        break;

                    case 'U':
                        break;

                    case 'Y':
                        break;

                    case 'B':
                        temp.Append("1");
                        break;
                    case 'F':
                        temp.Append("1");
                        break;
                    case 'P':
                        temp.Append("1");
                        break;
                    case 'V':
                        temp.Append("1");
                        break;
                    case 'C':
                        temp.Append("2");
                        break;
                    case 'G':
                        temp.Append("2");
                        break;
                    case 'J':
                        temp.Append("2");
                        break;
                    case 'K':
                        temp.Append("2");
                        break;
                    case 'Q':
                        temp.Append("2");
                        break;
                    case 'S':
                        temp.Append("2");
                        break;
                    case 'X':
                        temp.Append("2");
                        break;
                    case 'Z':
                        temp.Append("2");
                        break;
                    case 'D':
                        temp.Append("3");
                        break;
                    case 'T':
                        temp.Append("3");
                        break;
                    case 'L':
                        temp.Append("4");
                        break;
                    case 'M':
                        temp.Append("5");
                        break;
                    case 'N':
                        temp.Append("5");
                        break;
                    case 'R':
                        temp.Append("6");
                        break;
                    case 'W':
                        if ((i + 1) < toConvert.Length) 
                        {
                            if (toConvert.Substring((i - 1), 1).Equals("B") || toConvert.Substring((i - 1), 1).Equals("F") ||
                                toConvert.Substring((i - 1), 1).Equals("P") || toConvert.Substring((i - 1), 1).Equals("V")) 
                            {
                                if (toConvert.Substring((i + 1), 1).Equals("B") || toConvert.Substring((i + 1), 1).Equals("F") ||
                                toConvert.Substring((i + 1), 1).Equals("P") || toConvert.Substring((i + 1), 1).Equals("V"))
                                {
                                    //Skip ahead so the character w/matching code won't be added
                                    i += 2;
                                }
                            }

                            if (toConvert.Substring((i - 1), 1).Equals("C") || toConvert.Substring((i - 1), 1).Equals("G") ||
                                toConvert.Substring((i - 1), 1).Equals("J") || toConvert.Substring((i - 1), 1).Equals("K")
                                || toConvert.Substring((i - 1), 1).Equals("Q") || toConvert.Substring((i - 1), 1).Equals("S")
                                || toConvert.Substring((i - 1), 1).Equals("X") || toConvert.Substring((i - 1), 1).Equals("Z"))
                            {
                                if (toConvert.Substring((i + 1), 1).Equals("C") || toConvert.Substring((i + 1), 1).Equals("G") ||
                                toConvert.Substring((i + 1), 1).Equals("J") || toConvert.Substring((i + 1), 1).Equals("K")
                                || toConvert.Substring((i + 1), 1).Equals("Q") || toConvert.Substring((i + 1), 1).Equals("S")
                                || toConvert.Substring((i + 1), 1).Equals("X") || toConvert.Substring((i + 1), 1).Equals("Z"))
                                {
                                    //Skip ahead so the character w/matching code won't be added
                                    i += 2;
                                }
                            }

                            if (toConvert.Substring((i - 1), 1).Equals("D") || toConvert.Substring((i - 1), 1).Equals("T"))
                            {
                                if (toConvert.Substring((i + 1), 1).Equals("D") || toConvert.Substring((i + 1), 1).Equals("T"))
                                {
                                    //Skip ahead so the character w/matching code won't be added
                                    i += 2;
                                }
                            }

                            if (toConvert.Substring((i - 1), 1).Equals("L") && toConvert.Substring((i + 1), 1).Equals("L"))
                            {
                                //Skip ahead so the character w/matching code won't be added
                                i += 2;
                                
                            }

                            if (toConvert.Substring((i - 1), 1).Equals("R") && toConvert.Substring((i + 1), 1).Equals("R"))
                            {
                                //Skip ahead so the character w/matching code won't be added
                                i += 2;

                            }

                            if (toConvert.Substring((i - 1), 1).Equals("M") || toConvert.Substring((i - 1), 1).Equals("N"))
                            {
                                if (toConvert.Substring((i + 1), 1).Equals("M") || toConvert.Substring((i + 1), 1).Equals("N"))
                                {
                                    //Skip ahead so the character w/matching code won't be added
                                    i += 2;
                                }
                            }
                        }
                        break;
                    case 'H':
                        if ((i + 1) < toConvert.Length)
                        {
                            if (toConvert.Substring((i - 1), 1).Equals("B") || toConvert.Substring((i - 1), 1).Equals("F") ||
                                toConvert.Substring((i - 1), 1).Equals("P") || toConvert.Substring((i - 1), 1).Equals("V"))
                            {
                                if (toConvert.Substring((i + 1), 1).Equals("B") || toConvert.Substring((i + 1), 1).Equals("F") ||
                                toConvert.Substring((i + 1), 1).Equals("P") || toConvert.Substring((i + 1), 1).Equals("V"))
                                {
                                    //Skip ahead so the character w/matching code won't be added
                                    i += 2;
                                }
                            }

                            if (toConvert.Substring((i - 1), 1).Equals("C") || toConvert.Substring((i - 1), 1).Equals("G") ||
                                toConvert.Substring((i - 1), 1).Equals("J") || toConvert.Substring((i - 1), 1).Equals("K")
                                || toConvert.Substring((i - 1), 1).Equals("Q") || toConvert.Substring((i - 1), 1).Equals("S")
                                || toConvert.Substring((i - 1), 1).Equals("X") || toConvert.Substring((i - 1), 1).Equals("Z"))
                            {
                                if (toConvert.Substring((i + 1), 1).Equals("C") || toConvert.Substring((i + 1), 1).Equals("G") ||
                                toConvert.Substring((i + 1), 1).Equals("J") || toConvert.Substring((i + 1), 1).Equals("K")
                                || toConvert.Substring((i + 1), 1).Equals("Q") || toConvert.Substring((i + 1), 1).Equals("S")
                                || toConvert.Substring((i + 1), 1).Equals("X") || toConvert.Substring((i + 1), 1).Equals("Z"))
                                {
                                    //Skip ahead so the character w/matching code won't be added
                                    i += 2;
                                }
                            }

                            if (toConvert.Substring((i - 1), 1).Equals("D") || toConvert.Substring((i - 1), 1).Equals("T"))
                            {
                                if (toConvert.Substring((i + 1), 1).Equals("D") || toConvert.Substring((i + 1), 1).Equals("T"))
                                {
                                    //Skip ahead so the character w/matching code won't be added
                                    i += 2;
                                }
                            }

                            if (toConvert.Substring((i - 1), 1).Equals("L") && toConvert.Substring((i + 1), 1).Equals("L"))
                            {
                                //Skip ahead so the character w/matching code won't be added
                                i += 2;

                            }

                            if (toConvert.Substring((i - 1), 1).Equals("R") && toConvert.Substring((i + 1), 1).Equals("R"))
                            {
                                //Skip ahead so the character w/matching code won't be added
                                i += 2;

                            }

                            if (toConvert.Substring((i - 1), 1).Equals("M") || toConvert.Substring((i - 1), 1).Equals("N"))
                            {
                                if (toConvert.Substring((i + 1), 1).Equals("M") || toConvert.Substring((i + 1), 1).Equals("N"))
                                {
                                    //Skip ahead so the character w/matching code won't be added
                                    i += 2;
                                }
                            }
                        }
                        break;
                }
            }

            //If the resultant soundex is less than four characters,
            //append zeros until the length = 4

            if (temp.Length <= 3)
            {
                for (int i = temp.Length; i < 4; i++)
                {
                    temp.Append("0");
                }
            }

            converted = temp.ToString();

            if (converted.Length >= 5) 
            {
                converted = converted.Remove(4);
            }

            return converted;
        }
    }
}
