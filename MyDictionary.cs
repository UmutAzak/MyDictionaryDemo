using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class MyDictionary<T>
    {
        T[] itmes;
        T[] tempArray;
       
        public MyDictionary()
        {
            itmes = new T[0];
        }

        
        public void Add(T item)
        {
            tempArray = itmes;
            itmes = new T[itmes.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                itmes[1] = tempArray[i];
            }

            itmes[itmes.Length - 1] = item;
            Console.WriteLine(item);

        }

    }
}
