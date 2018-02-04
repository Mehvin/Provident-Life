using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife
{
    interface Iterator
    {
        Object next();
        bool hasNext();
        void remove(object obj);
    }
}
