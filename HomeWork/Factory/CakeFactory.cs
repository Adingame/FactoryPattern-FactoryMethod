using HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class CakeFactory : IBreadFactory
    {
        public IBread creteBread()
        {
            return new Cake();
        }
    }
}
