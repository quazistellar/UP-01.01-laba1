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
using UP_laba1_dataset.UP_laba_1DataSetTableAdapters;

namespace UP_laba1_dataset
{
    /// <summary>
    /// Логика взаимодействия для Types.xaml
    /// </summary>
    public partial class Types : Window
    {
        public ShipsTypesTableAdapter types = new ShipsTypesTableAdapter();

        public Types()
        {
            InitializeComponent();
            datagrid2.ItemsSource = types.GetData();
        }
    }
}
