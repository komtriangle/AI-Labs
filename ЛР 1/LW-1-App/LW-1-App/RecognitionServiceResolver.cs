using LW_1_App.Models.Enums;
using LW_1_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_1_App
{
    public delegate ISpechRecongnition RecognitionServiceResolver(RecognizerTypes type);
}
