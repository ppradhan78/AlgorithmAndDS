using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.Generic
{
    public  class SwapTwoItem<T>
    {

        public  void Swap(T item1,T item2)
        {
            if (item1.GetType() == typeof(int) && item2.GetType() == typeof(int))
            {
                int x =Convert.ToInt32(item1);
                int y = Convert.ToInt32(item2);
                Console.WriteLine("x,y@" + x + "," + y);
                x = x + y;
                y = x - y;
                x = x - y;
                Console.WriteLine("x,y@" + x + "," + y);
            }
            if (item1.GetType() == typeof(string) && item2.GetType() == typeof(string))
            {
                string x = Convert.ToString(item1);
                string y = Convert.ToString(item2);
                Console.WriteLine("x,y@" + x + "," + y);

                Console.WriteLine("x,y@" + x.Replace(x,y) + "," + y.Replace(y,x));
            }
        }
    }
}
