using LW_2_Core.Interfces;
using LW_2_Core.Models;
using System.Threading.Tasks;
using LW_2_Core.Exceptions;
using System;
using Microsoft.Extensions.Options;
using LW_2_Core.Configuration;

namespace LW_2_Core.ruGPT_3
{
    public class ruGPT_3_TextGenerator : ITextGenerator
    {
        public ruGPT_3_TextGenerator(IOptions<ruGPT_3_Configuration> options)
        {
            ruGPT_3_Requester.setApiUrl(options?.Value?.ApiUrl);
        }
        public async Task<GereratedTextResponse> Gererate(string startPhrase)
        {
            if (string.IsNullOrWhiteSpace(startPhrase))
            {
                throw new ruGPT_3_Exception("Стартовая фраза не может быть пустой строколй или null");
            }
            try
            {
                var rugpt3Response = await ruGPT_3_Requester.Send(startPhrase);

                return new GereratedTextResponse() { Text = rugpt3Response.predictions };
            }
            catch (ruGPT_3_Exception)
            {
                throw;
            }
            catch (Exception)
            {
                throw new ruGPT_3_Exception("Ошибка во время работы ruGPT-3");
            }
        }
    }
}
