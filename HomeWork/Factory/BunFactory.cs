using HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class BunFactory : IBreadFactory
    {
        public IBread creteBread()
        {
            return new Bun();
        }
    }
}
