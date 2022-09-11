using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_1_Core.Validators
{
    public static class FilePathValidator
    {
        private static string[] allowedExtensions = new string[] { ".wav", ".mp3", ".opus", ".ogg" };
        public static bool ValidatePath(string pathToFile, out string message)
        {
            message = string.Empty;
            if (!File.Exists(pathToFile))
            {
                message = "Файл по переданному пути не существует";
                return false;
            }

            string fileExtension = Path.GetExtension(pathToFile);
            if (!allowedExtensions.Contains(fileExtension))
            {
                message = $"Выбранный файл должен иметь одно из сделующий расширений: {string.Join(", ", allowedExtensions)}";
                return false;
            }
            return true;
        }
    }
}
