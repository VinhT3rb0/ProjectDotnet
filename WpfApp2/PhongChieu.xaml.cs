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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for PhongChieu.xaml
    /// </summary>
    public partial class PhongChieu : Window
    {
        public PhongChieu()
        {
            InitializeComponent();
            DataContext = this;

            Buttons = new List<string>();
            for (int i = 1; i <= 140; i++)
            {
                Buttons.Add($"Button {i}");
            }
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
