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

namespace PeopleViewer.Layer
{
    public partial class MainWindow : Window
    {
        PeopleViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
            viewModel = new PeopleViewModel();
            this.DataContext = viewModel;
        }

        private void FetchButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.FetchData();
            ShowRepositoryType();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ClearData();
            RepositoryTypeTextBlock.Text = string.Empty;
        }

        private void ShowRepositoryType()
        {
            RepositoryTypeTextBlock.Text = viewModel.RepositoryType;
        }
    }
}
