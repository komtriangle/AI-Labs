using LW_1_Core.Validators;
using Microsoft.Win32;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using LW_1_Core;
using LW_1_App.Models.Enums;

namespace LW_1_App
{
    public partial class SpeechRecognizerWindow : Window
    {
        private string _filePath;
        private readonly RecognitionServiceResolver _resolver;
        public SpeechRecognizerWindow(RecognitionServiceResolver resolver)
        {
            _resolver = resolver;
            InitializeComponent();
        }

        private async void ChooseFileBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog chooseFileDialog = new OpenFileDialog();
            if (chooseFileDialog.ShowDialog() == true)
            {
                if (!FilePathValidator.ValidatePath(chooseFileDialog.FileName, out string message))
                {
                    MessageBox.Show(message);
                }
                else
                {
                    _filePath = chooseFileDialog.FileName;
                    FileNameTextLabel.Content = Path.GetFileName(chooseFileDialog.FileName);
                }
            }
           
        }

        private async void AzureRecoginizeBtn_Click(object sender, RoutedEventArgs e)
        {
            await recognizeSpeech(_resolver(RecognizerTypes.Azure));
        }

        private async void YandexRecoginizeBtn_Click(object sender, RoutedEventArgs e)
        {
            await recognizeSpeech(_resolver(RecognizerTypes.YandexCloud));
        }

        private async void HoundifyRecoginizeBtn_Click(object sender, RoutedEventArgs e)
        {
             await recognizeSpeech(_resolver(RecognizerTypes.Houndify));
        }


        private async Task recognizeSpeech(ISpechRecongnition recognizer)
        {
            disableButtions();

            if (string.IsNullOrEmpty(_filePath))
            {
                MessageBox.Show("Необоходимо выбрать файл для распознавания", "Ошибка");
                return;
            }
            try
            {
                LoadSpinner.Visibility = Visibility.Visible;
                cleanRecognizedSpechTextBox();
                var result = await Task.Run(async () =>
                        await recognizer.Recognize(_filePath));
                LoadSpinner.Visibility = Visibility.Hidden;
                switch (result.Type)
                {
                    case LW_1_Core.Enums.ResponseTypes.Recognized:
                        RecognizedSpechTextBox.Text = result.Text;
                        break;
                    case LW_1_Core.Enums.ResponseTypes.NoMatch:
                        MessageBox.Show("Речь в аудиофайле не найдена", "Сообщение");
                        break;
                    default:
                        MessageBox.Show(result.Message, "Ошибка");
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ОШибка во время распознавания аудио", "Ошибка");
            }
            finally{
                enableButtions();
            }
           

        }
        
        private void cleanRecognizedSpechTextBox()
        {
            RecognizedSpechTextBox.Text = String.Empty;
        }

        private void disableButtions()
        {
            AzureRecoginizeBtn.IsEnabled = false;
            YandexRecoginizeBtn.IsEnabled =false;
            HoundifyRecoginizeBtn.IsEnabled=false;
        }

        private void enableButtions()
        {
            AzureRecoginizeBtn.IsEnabled = true;
            YandexRecoginizeBtn.IsEnabled = true;
            HoundifyRecoginizeBtn.IsEnabled = true;
        }


    }
}
