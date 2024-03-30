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


using UP_laba1_dataset.UP_laba_1DataSetTableAdapters;

namespace UP_laba1_dataset
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

     
        private void exit_btn_Click(object sender, RoutedEventArgs e)
        {

            Environment.Exit(0);
        }

        private void ships_show_Click(object sender, RoutedEventArgs e)
        {
            Ships ships = new Ships();
            ships.ShowDialog();
        }

        private void types_show_Click(object sender, RoutedEventArgs e)
        {
            Types types = new Types();
            types.ShowDialog();
        }

        private void pilots_show_Click(object sender, RoutedEventArgs e)
        {
            Pilots pilots = new Pilots();
            pilots.ShowDialog();
        }
    }
}
