using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace Lab2._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
                textBox.FontFamily = new FontFamily(fontName);
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            double fontSize = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
            if (textBox != null)
                textBox.FontSize = fontSize;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool bold = (sender as Button).IsPressed;
            if (textBox != null)
            {
                if (bold)
                {
                    textBox.FontWeight = textBox.FontWeight != FontWeights.Bold
                        ? FontWeights.Bold
                        : FontWeights.Normal;
                }
            }
        }

        private void italic_Click(object sender, RoutedEventArgs e)
        {
            bool italic = (sender as Button).IsPressed;
            if (textBox != null)
            {
                if (italic)
                {
                    textBox.FontStyle = textBox.FontStyle != FontStyles.Italic
                        ? FontStyles.Italic
                        : FontStyles.Normal;
                }
            }
        }

        private void underline_Click(object sender, RoutedEventArgs e)
        {
            bool underline = (sender as Button).IsPressed;
            if (textBox != null)
            {
                if (underline)
                {
                    if (textBox.TextDecorations != TextDecorations.Underline)
                    {
                        textBox.TextDecorations = TextDecorations.Underline;
                    }
                    else
                    {
                        textBox.TextDecorations = null;
                    }
                }
            }
        }

        private void blackColor_Checked(object sender, RoutedEventArgs e)
        {
            bool isChecked = (bool)(sender as RadioButton).IsChecked;
            if (textBox != null)
            {
                if (isChecked)
                {
                    textBox.Foreground = Brushes.Black;
                }
            }
        }

        private void redColor_Checked(object sender, RoutedEventArgs e)
        {
            bool isChecked = (bool)(sender as RadioButton).IsChecked;
            if (textBox != null)
            {
                if (isChecked)
                {
                    textBox.Foreground = Brushes.Red;
                }
            }
        }
    }
}
