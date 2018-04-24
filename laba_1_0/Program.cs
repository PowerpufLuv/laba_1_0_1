
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1_0
{
    class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Chet schet = new Chet();
            Console.WriteLine(schet);
            //schet.Name = "Nomber one";
            Chet schet2 = new Chet("Two", 150, 2.1);
            Console.WriteLine(schet2);
            Console.ReadKey();
        }

    }
}
