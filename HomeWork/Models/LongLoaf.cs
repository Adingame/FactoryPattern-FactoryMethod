using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Models
{
    public class LongLoaf : Bread, IBread
    {
        public void Taste()
        {
            Console.WriteLine("Very nice 2");
        }
    }
}
