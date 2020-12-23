using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Models
{
    public class Bun : Bread, IBread
    {
        public void Taste()
        {
            Console.WriteLine("Very nice");
        }
    }
}
