using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DalPalindrome;

namespace BllPalindrome
{
    public class PalindromeManagement
    {
        public List<string> GetListPalindromeFromFile(string pFileName)
        {
            FileTextReaderUtility myReader = new FileTextReaderUtility();
            List<string> redLines = myReader.ReadAllLines(pFileName);
            List<string> cleanedList = new List<string>();
            foreach (string lines in redLines)
            {
                if (string.IsNullOrWhiteSpace(lines) == false)
                {
                    string[] splitted = lines.Split(',');
                    cleanedList.Add(NoBrackets(splitted[0].Trim()));
                }
                //example line contiens " aa, une type de lave"
                //cree algorythme, a la fin ne rreste que "aa"

            }
            return cleanedList;
        }

        public string NoBrackets(string input)
        {
            StringBuilder noBrackets = new StringBuilder();
            int level = 0;
            string output = string.Empty;
            foreach (var c in input)
            {
                if (c == '(')
                {
                    level++;
                }
                if (level == 0)
                {
                    noBrackets.Append(c);
                }
                if (c == ')' && level > 0)
                {
                    level--;
                }

            }
            return noBrackets.ToString();
        }
    }
}
//List<string> resultClean = new List<string>();
//foreach (string regLine in redLines)
//{
//    string pattern;
//    pattern = ".+?(?=,)";
//    Regex rgx = new Regex(pattern);

//    MatchCollection matches = rgx.Matches(regLine);

//    if (rgx.IsMatch(regLine))
//    {
//        foreach (Match match in matches)
//            resultClean.Add("" + match.Value);
//    }
//}
//return resultClean;