using System;
using System.Collections.Generic;
using System.Text;

namespace practise3.custom
{
    class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message):base(message)
        {
            
        }
    }
}
