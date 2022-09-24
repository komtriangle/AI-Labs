using LW_2_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_2_Core.Interfces
{
    public interface ITextGenerator
    {
        Task<GereratedTextResponse> Gererate(string startPhrase);
    }
}
