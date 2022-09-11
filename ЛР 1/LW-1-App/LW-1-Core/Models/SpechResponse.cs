using LW_1_Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_1_Core.Models
{
    public class SpechResponse
    {
        public ResponseTypes Type { get; set; }
        public string Text { get; set; }
        public string Message { get; set; }

        public SpechResponse(ResponseTypes type, string text = "", string message = "")
        {
            Type = type;
            Text = text;
            Message = message;
        }
    }
}
