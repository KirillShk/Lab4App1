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

namespace Lab4App1
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
            double sumDollar = Convert.ToDouble(summa.Text);
            double result = rateDollar * sumDollar;
            resSum.Text = result.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate2.Text);
            double sumEuro = Convert.ToDouble(summa2.Text);
            double result2 = rateEuro * sumEuro;
            resSum2.Text = result2.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateYena = Convert.ToDouble(rate3.Text);
            double sumYena = Convert.ToDouble(summa3.Text);
            double result3 = rateYena * sumYena;
            resSum3.Text = result3.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDrama = Convert.ToDouble(rate4.Text);
            double sumDrama = Convert.ToDouble(summa4.Text);
            double result4 = rateDrama * sumDrama;
            resSum4.Text = result4.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double sumInch = Convert.ToDouble(distance1.Text);
            const double Inch = 0.0254;
            double resultInch = sumInch * Inch;
            resDis1.Text = resultInch.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double sumFut = Convert.ToDouble(distance2.Text);
            const double Fut = 3.28;
            double resultFut = sumFut * Fut;
            resDis2.Text = resultFut.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double sumMile = Convert.ToDouble(distance3.Text);
            const double Mile = 1609.34;
            double resultMile = sumMile * Mile;
            resDis3.Text = resultMile.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double sumVersta = Convert.ToDouble(distance4.Text);
            const double Versta = 1066.8;
            double resultVerst = sumVersta * Versta;
            resDis4.Text=resultVerst.ToString();
        }
    }
}
