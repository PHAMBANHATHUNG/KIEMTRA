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

namespace kiemtraketthucmon
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

        private void NUT_Click(object sender, RoutedEventArgs e)
        {
            DongVat loai1 = new DongVat("gau gau");
            loai1.Talk();
            DongVat loai2 = new DongVat();
            loai2.Loai = "meo meo";
            loai2.Talk();

        }
    }
}
