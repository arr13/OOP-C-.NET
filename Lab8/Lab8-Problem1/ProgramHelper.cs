using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Problem1
{
    class ProgramHelper: IConvertible, ICodeChecker
    {
        public string ConvertToCSharp(string stringToConvert)
        {
            return stringToConvert + " to convert to CSharp";
        }

        public string ConvertToVisualBasic(string stringToConvert)
        {
            return stringToConvert + " to convert to VB2005";
        }

        public bool CodeCheckSyntax(string code, string lang)
        {
            return code.Equals(lang);
        }
    }
}
