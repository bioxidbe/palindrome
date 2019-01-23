using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //<--

namespace DalPalindrome
{
    public class FileTextReaderUtility
    {
        public List<string> ReadAllLines(string pFileName)
        {
            if (string.IsNullOrEmpty(pFileName))
            {
                throw new ArgumentOutOfRangeException();
            }
          return File.ReadAllLines(pFileName).ToList();
               
        }
    }
}
