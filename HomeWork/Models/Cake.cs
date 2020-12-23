using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Models
{
    public class Cake : Bread, IBread
    {
        public void Taste()
        {
            Console.WriteLine("Normal");
        }
    }
}
