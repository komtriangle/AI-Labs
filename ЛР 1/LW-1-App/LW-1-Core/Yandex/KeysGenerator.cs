using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_1_Core.Yandex
{
    internal static class KeysGenerator
    {
        public static string GenerateAIMToken()
        {
            var command = " yc iam create-token";

            var powerShellCommand = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                Arguments = command.ToString(),
                CreateNoWindow = true,
            };

            var process = Process.Start(powerShellCommand);
            process.WaitForExit();
            string token = process.StandardOutput.ReadToEnd();

            while (token.Contains('\n'))
            {
                token = token.Remove(token.IndexOf('\n'));
            }
            return token;
        }
    }
}
