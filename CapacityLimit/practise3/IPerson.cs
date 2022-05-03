using System;
using System.Collections.Generic;
using System.Text;

namespace practise3
{
    interface IPerson
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        string ShowInfo();
    }
}
