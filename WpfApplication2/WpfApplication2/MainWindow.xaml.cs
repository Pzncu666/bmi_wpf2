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

namespace WpfApplication2
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Clear_Btn1_Click(object sender, RoutedEventArgs e)
        {
            Box1.Text = "";
        }

        private void Clear_Btn2_Click(object sender, RoutedEventArgs e)
        {
            Box2.Text = "";
        }

        private void cu_Click(object sender, RoutedEventArgs e)
        {
            double h = double.Parse(Box1.Text)/100;
            double w = double.Parse(Box2.Text);
            double bmi = w / (h * h);

            Answer.Text = bmi.ToString();
        }
    }
}
