using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp65
{
    internal class Mercedes:Car
    {
        static int _totalcoun;
        public static int Totalcoun { get => _totalcoun; }
        public Mercedes()
        {
            _totalcoun++;
        }
    }
}
