using System;
using System.Windows;

namespace temperatura
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnToFahrenheit_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtInput.Text, out double celsius))
            {
                double fahrenheit = celsius * 9.0 / 5.0 + 32;
                lblResult.Text = $"{celsius} °C = {fahrenheit:F2} °F";
            }
            else
            {
                MessageBox.Show("Proszę wpisać poprawną liczbę!", "Błąd",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnToCelsius_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtInput.Text, out double fahrenheit))
            {
                double celsius = (fahrenheit - 32) * 5.0 / 9.0;
                lblResult.Text = $"{fahrenheit} °F = {celsius:F2} °C";
            }
            else
            {
                MessageBox.Show("Proszę wpisać poprawną liczbę!", "Błąd",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}