using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using EasySaveApp.ViewModels;

namespace EasySaveApp.Views
{
    /// <summary>
    /// Logique d'interaction pour View.xaml
    /// </summary>
    public partial class View : Window
    {
        public View()
        {
            DataContext = new ViewModel();
            InitializeComponent();
        }
    }
}
