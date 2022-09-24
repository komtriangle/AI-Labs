using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_1_Core.Azure
{
    internal class AzureResponse
    {
        public string RecognitionStatus { get; set; }
        public long Offset { get; set; }
        public long Duration { get; set; }
        public string DisplayText { get; set; }
    }
}
