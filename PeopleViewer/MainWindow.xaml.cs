using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using PersonRepository.Factory;
using PersonRepository.Interface;

namespace PeopleViewer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FetchButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();

            IPersonRepository repository = FactoryRepository.GetRepository();

            var people = repository.GetPeople();
            foreach (var person in people)
                PersonListBox.Items.Add(person);

            ShowRepositoryType(repository);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            PersonListBox.Items.Clear();
            RepositoryTypeTextBlock.Text = string.Empty;
        }

        private void ShowRepositoryType(IPersonRepository repository)
        {
            RepositoryTypeTextBlock.Text = repository.GetType().ToString();
        }
    }
}
