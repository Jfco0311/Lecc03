using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03
{
    class Arreglo
    {
        public int FibonacciArreglo(int limit)
        {
            int[] Series = new int[1];
            Array.Resize(ref Series, limit);

            Series[0] = 0;
            Series[1] = 1;

            for (int i = 2; i < limit; i++) ;
                Series[i] = Series[i-1] + Series[i-2]; 
            return Series;
        }
        
    
    
    }
}
