using Codefirst.Data;
using System.Data.Common;

namespace Codefirst
{
    internal class Program
    {     
        static void Main(string[] args)
        {

            Navi navi = new Navi();
            navi.Start();

             ///Labb2Context labb2 = new();
            //foreach  (string arg in args) { }
            //foreach (var item in db) { }

            Console.WriteLine("");
        }
    }
}