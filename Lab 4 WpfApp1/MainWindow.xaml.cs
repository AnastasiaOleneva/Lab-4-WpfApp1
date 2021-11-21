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

namespace Lab_4_WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar = rateDollar * sumDollar;
            result.Text = resDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate2.Text);
            double sumEuro = Convert.ToDouble(sum2.Text);
            double resEuro = rateEuro * sumEuro;
            result2.Text = resEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGr = Convert.ToDouble(rate3.Text);
            double sumGr = Convert.ToDouble(sum3.Text);
            double resGr= rateGr * sumGr;
            result3.Text = resGr.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDr = Convert.ToDouble(rate4.Text);
            double sumDr = Convert.ToDouble(sum4.Text);
            double resDr = rateDr * sumDr;
            result4.Text = resDr.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double valueDm = Convert.ToDouble(value1.Text);
            double resM = valueDm * 0.0254;
            resultConver1.Text = resM.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double valueFt = Convert.ToDouble(value2.Text);
            double resM2 = valueFt * 0.3;
            resultConver2.Text = resM2.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double valueMl = Convert.ToDouble(value3.Text);
            double resM3 = valueMl * 1609.34;
            resultConver3.Text = resM3.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double valueVrst = Convert.ToDouble(value4.Text);
            double resVrst = valueVrst * 1066.8;
            resultConver4.Text = resVrst.ToString();
        }
    }
}
