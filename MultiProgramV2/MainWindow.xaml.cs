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

namespace MultiProgramV2
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void EncodingBtn_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "";
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(Textbox.Text);
            foreach(byte b in ASCIIValues)
            {
                resultLabel.Content = resultLabel.Content +  " " + b.ToString();
            }
            
        }

        private void DecodingBtn_Click(object sender, RoutedEventArgs e)
        {
            ASCIIEncoding ascii = new ASCIIEncoding();
            string[] stringArray = TextBox2.Text.Split(' ');
            stringArray = stringArray.Skip(1).ToArray();
            byte[] byteArray = Array.ConvertAll(stringArray, Byte.Parse);
            resultLabel2.Content = ascii.GetString(byteArray);
        }

        private void CopyToClipboard_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Clipboard.SetText(resultLabel.Content.ToString());
        }
    }
}
