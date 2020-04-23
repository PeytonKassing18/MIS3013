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

namespace WPF2
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

        private void btnEven_Checked(object sender, RoutedEventArgs e)
        {
            string max;
            max = txtMax.Text;

            int maxNum = Convert.ToInt32(max);

            for (int i = 0; i <= maxNum; i++)
            {
                if(i%2 == 0)
                {
                    lstOddEven.Items.Add(i);
                }
            }
        }

        private void btnOdd_Checked(object sender, RoutedEventArgs e)
        {
            string max;
            max = txtMax.Text;

            int maxNum = Convert.ToInt32(max);

            for (int i = 0; i <= maxNum; i++)
            {
                if (i % 2 != 0)
                {
                    lstOddEven.Items.Add(i);
                }
            }
        }
    }
}
