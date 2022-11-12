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

namespace WPF_SB_PR4
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

        private void Generator_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int i = rnd.Next(51);
            VG1.Text = i.ToString();
        }

        private void Extrasens_Click(object sender, RoutedEventArgs e)
        {
            int i = int.Parse(VG1.Text);
            int TT1 = Convert.ToInt32(Vivod.Text);

            if (i == TT1)
            {
                MessageBox.Show("Ладно, угадал");
            }
            else if (i > TT1)
            {
                MessageBox.Show("Чёт маловато");
            }
            else
            {
                MessageBox.Show("А давай чуть поменьше как бы");
            }
        }
    }
}
