using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp65
{
    internal class Bmw:Car
    {
        static int _totalcount;
        public static int Totalcount { get => _totalcount; }
        public Bmw()
        {
            _totalcount++;
        }
    }
}
