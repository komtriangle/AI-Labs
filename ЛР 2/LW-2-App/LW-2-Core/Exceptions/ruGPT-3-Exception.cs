using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_2_Core.Exceptions
{
    public class ruGPT_3_Exception: Exception
    {
        public ruGPT_3_Exception(string message)
            :base(message)
        { }
    }
}
