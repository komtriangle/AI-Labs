using NAudio.Wave;
using System.Diagnostics;
using System.IO;
using System;
using System.Linq;

namespace LW_1_Core.Utils
{
    internal static class AudioConverter
    {
        private static string[] allowedExtensions = { ".mp3", ".wav", ".ogg", ".opus" };
        public static void ConvertAduio(string sourcePath, out string newPath, string newExtension)
        {
            if (!allowedExtensions.Contains(newExtension))
            {
                throw new ArgumentException($"Неподдерживаемое расширение: {newExtension}");
            }
            if (!File.Exists(sourcePath))
            {
                throw new FileNotFoundException("Исходный файл не найден");
            }
            newPath = $"{Path.GetFileNameWithoutExtension(sourcePath)}{newExtension}";
            if (File.Exists(newPath))
            {
                return;
            }
            var command = $"ffmpeg -i \"{sourcePath}\" \"{newPath}\"";
            runPowershellCommand(command);
        }

        private static void runPowershellCommand(string command)
        {

            var powerShellCommand = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                Arguments = command.ToString(),
                CreateNoWindow = true,
                WorkingDirectory = Directory.GetCurrentDirectory()
            };

            var process = Process.Start(powerShellCommand);
            process?.WaitForExit();
        }

    }
}
