using LW_2_Core.Exceptions;
using LW_2_Core.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LW_2_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class TextGeneration : Window
    {
        private readonly ITextGenerator _textGenerator;

        private string startPhrase
        {
            get
            {
                return startPhrase_TextBox.Text;
            }
        }
        public TextGeneration(ITextGenerator textGenerator)
        {
            InitializeComponent();
            _textGenerator = textGenerator ??
                throw new ArgumentNullException(nameof(textGenerator));
        }

        private async void complementText_Btn_Click(object sender, RoutedEventArgs e)
        {
            cleanText();
            if (string.IsNullOrEmpty(startPhrase))
            {
                MessageBox.Show("Необоходимо ввести стартовую фразу", "Ошибка");
                return;
            }
            try
            {
                disableButtons();
                enableSpinner();
                var result = await _textGenerator.Gererate(startPhrase);
                resultText_TextBox.Text = result.Text;
            }
            catch (ruGPT_3_Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка во время генерации текста", "Ошибка");
            }
            finally{
                enableButtons();
                disableSpinner();
            }
        }

        private void cleanText()
        {
            resultText_TextBox.Text = string.Empty;
        }

        private void enableSpinner()
        {
            LoadSpinner.Visibility = Visibility.Visible;
        }

        private void disableSpinner()
        {
            LoadSpinner.Visibility = Visibility.Hidden;
        }

        private void disableButtons()
        {
            complementText_Btn.IsEnabled = false;
        }

        private void enableButtons()
        {
            complementText_Btn.IsEnabled = true;
        }

    }
}
