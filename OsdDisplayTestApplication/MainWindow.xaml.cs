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

namespace OsdDisplayTestApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainVM _vm;

        public MainWindow()
        {
            InitializeComponent();

            _vm = new MainVM();
            DataContext = _vm;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            DisplayHelper.Close();
        }
    }
}
