using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Problem1
{
    public interface IConvertible
    {
        string ConvertToCSharp(string stringToConvert);
        string ConvertToVisualBasic(string stringToConvert);
    }
}
