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
using static System.Net.Mime.MediaTypeNames;

namespace RichTextEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txt.FontFamily = new FontFamily(Fonts.SelectedItem.ToString());
            txt.FontSize = 11;
            txt.Foreground = Brushes.Black;
        }

        private void Close_Button_Click(object sender, RoutedEventArgs e) => Close();
        private void Minimize_Button_Click(object sender, RoutedEventArgs e) => WindowState = WindowState.Minimized;

        private void changed(object sender, SelectionChangedEventArgs e)
        {
            //txt.FontFamily = new FontFamily(Fonts.SelectedItem.ToString());
            //txt.FontSize = Convert.ToDouble(Size.SelectedItem.ToString());
            //if(Colors.SelectedItem.ToString() == "Black") txt.Foreground = Brushes.Black;
            //else if(Colors.SelectedItem.ToString() == "Red") txt.Foreground = Brushes.Red;
            //else if(Colors.SelectedItem.ToString() == "Blue") txt.Foreground = Brushes.Blue;
            //else if(Colors.SelectedItem.ToString() == "Green") txt.Foreground = Brushes.Green;
        }
    }
}
