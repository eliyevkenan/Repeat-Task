using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp65
{
    internal class Garage
    {
        public int Bmwlimit { get; set; }
        public int Mercedeslimit { get; set; }
        Car[] _cars = new Car[0];
        int _bmwcount;
        int _mercedescount;
        public Car[] Cars { get => _cars; }
        public void Addcar(Car car)
        {
            if (_cars.Length < Bmwlimit + Mercedeslimit)
            {
                if (car is Bmw)
                {
                    if (_bmwcount < Bmwlimit)
                    {
                        Array.Resize(ref _cars, _cars.Length + 1);
                        _cars[_cars.Length - 1] = car;
                        _bmwcount++;
                    }
                    else
                        throw new BmwException("Bmw-modelinin limiti doldu!");
                }
                
                else if (car is Mercedes)
                {
                    if (_mercedescount < Mercedeslimit)
                    {
                        Array.Resize(ref _cars, _cars.Length + 1);
                        _cars[_cars.Length - 1] = car;
                        _mercedescount++;
                    }
                    throw new MercedesException("Merecedes-modelinin limiti doldu!");
                }
                else
                    throw new GarageException("Avtomobillerin limiti doldu!");
            }
        }
    }
}
