using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> FirstName = new MyDictionary<string>();
            FirstName.Add("Umut");
            FirstName.Add("Kemal");
            FirstName.Add("Mustafa");

            MyDictionary<string> LastName = new MyDictionary<string>();
            LastName.Add("Azak");
            LastName.Add("Sancak");
            LastName.Add("Ren");

            MyDictionary<int> Tel_No = new MyDictionary<int>();
            Tel_No.Add(123456);
            Tel_No.Add(1234567);
            Tel_No.Add(12345678);


            Console.ReadKey();
        }
    }
}
