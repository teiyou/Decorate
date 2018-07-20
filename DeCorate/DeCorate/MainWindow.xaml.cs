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

namespace DeCorate
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        Component myHouse;
        public MainWindow()
        {
            InitializeComponent();
            myHouse = new MYHouse();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             myHouse = new SafeDecote(myHouse);
            this.txt_house.Text= myHouse.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            myHouse = new TransformDecore(myHouse);
            this.txt_house.Text = myHouse.Show();
        }
    }
}
