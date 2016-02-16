using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Problem1
{
    public interface ISelectable
    {
        // Indexer declaration:  
        int this[int index]
        {
            get;
            set;
        }
    }
}
