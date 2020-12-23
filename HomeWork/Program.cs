using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace HomeWork
{
    class Program
    {
        static void Main()
        {
            //IAnimalFactory2 factory2 = new DogFactory();
            //IAnimal2 animal = factory2.CreateAnimal();
            //animal.Sound();

            IBreadFactory factory = new BunFactory();
            IBread bunBread = factory.creteBread();
            bunBread.Taste();
        }
    }
}
