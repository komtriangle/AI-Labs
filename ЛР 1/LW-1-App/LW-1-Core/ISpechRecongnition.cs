using LW_1_Core.Enums;
using LW_1_Core.Models;
using Microsoft.CognitiveServices.Speech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_1_Core
{
    public interface ISpechRecongnition
    {
        /// <summary>
        /// Распознавание теста в аудио
        /// </summary>
        /// <param name="pathToFile">Путь до файла</param>
        /// <returns></returns>
        Task<SpechResponse> Recognize(string pathToFile);
    }
}
