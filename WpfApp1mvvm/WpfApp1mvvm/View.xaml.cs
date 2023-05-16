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

namespace WpfApp1mvvm
{
    public partial class View : Window
    {
        ViewModel viewModel;
        public View()
        {
            InitializeComponent();
            this.viewModel = new ViewModel();
            // DataContext привязывает отображение к другому классу.
            // Тогда в View.xaml.cs останутся только необходимые методы
            DataContext = this.viewModel;

        }
    }
}
