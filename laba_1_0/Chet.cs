using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1_0
{
    class Chet
    {
        public string Name = "";
        public int Number = 0;
        public double Summa = 0.0;
        /// <summary>
        /// Инициализация объекта, параметры по умолчанию
        /// </summary>
        public Chet()
        {
            this.Name = "";
            this.Number = 0;
            this.Summa = 0.0;
        }
        /// <summary>
        /// инициальзация объекта параметрами имя, номер, сумма
        /// </summary>
        /// <param name="name">НАИМЕНОВАНИЕ</param>
        /// <param name="nomber">НОМЕР</param>
        /// <param name="sum">СУММА</param>
        public Chet(string name, int nomber, double sum)
        {
            Name = name;
            Number = nomber;
            Summa = sum;
        }
    }
}
