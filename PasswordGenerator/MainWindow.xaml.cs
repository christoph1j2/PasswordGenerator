using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace PasswordGenerator
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    /// CapitalLetters_Click
    /// LowerCase_Click
    /// SpecialChars_Click
    /// Numbers_Click

    public partial class MainWindow : Window
    {
        private bool capitalLetters = false;
        private bool lowerCase = false;
        private bool specialChars = false;
        private bool numbers = false;
        private int length;

        string pw;
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.ResizeMode = ResizeMode.NoResize;
            Closing += OnWindowExit;
        }

        private void CapitalLetters_Click(object sender, RoutedEventArgs e)
        {
            capitalLetters = !capitalLetters;
            capitalIndicator.Fill = !capitalLetters ? Brushes.Red : Brushes.Green;
        }
        private void LowerCase_Click(object sender, RoutedEventArgs e)
        {
            lowerCase = !lowerCase;
            lowercaseIndicator.Fill = !lowerCase ? Brushes.Red : Brushes.Green;
        }
        private void SpecialChars_Click(object sender, RoutedEventArgs e)
        {
            specialChars = !specialChars;
            specialIndicator.Fill = !specialChars ? Brushes.Red : Brushes.Green;
        }
        private void Numbers_Click(object sender, RoutedEventArgs e)
        {
            numbers = !numbers;
            numberIndicator.Fill = !numbers ? Brushes.Red : Brushes.Green;
        }
        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                length = Convert.ToInt32(Length.Text);
            }
            catch (FormatException)
            {
                output.Text = "Invalid password length.";
                return;
            }
            if (!lowerCase&&!capitalLetters&&!specialChars&&!numbers)
            {
                output.Text = "Select atleast one option.";
            }
            else if(length==0)
            {
                output.Text = "Select the password length";
            }
            else
            {
                pw = CreatePassword(lowerCase, capitalLetters, numbers, specialChars, length);
                output.Text = pw;
            }
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (output.Text.Contains("Select")||output.Text.Contains("Invalid")|| String.IsNullOrEmpty(output.Text)|| String.IsNullOrWhiteSpace(output.Text))
            {
                MessageBox.Show("Error saving the password.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                SavePassword();
            }
        }
        private static string CreatePassword(bool lc, bool up, bool dg, bool sc, int len)
        {
            string alphabet = "";

            if (lc)
            {
                alphabet += "abcdefghijklmnopqrstuvwxyz";
            }
            if (up)
            {
                alphabet += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            if (dg)
            {
                alphabet += "0123456789";
            }
            if (sc)
            {
                alphabet += "^!|€đĐ[]łŁ#&@{}*$ß¤÷×/()'?:_¨§,.-+=´ˇ%~";
            }
            if (alphabet.Length == 0)
            {
                return "error";
            }

            StringBuilder result = new StringBuilder();
            Random r = new Random();

            while (result.Length < len)
            {
                result.Append(alphabet[r.Next(alphabet.Length)]);
            }
            Console.WriteLine(result.ToString());
            return result.ToString();
        }
        private void SavePassword()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.Title = "Save Password";
            if (saveFileDialog.ShowDialog() == true)
            {
                string password = pw;
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, password);
                }
                catch (Exception ex)
                {
                    err.Text = "Error saving password: " + ex.Message;
                }
            }
        }
        private void OnWindowExit(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
