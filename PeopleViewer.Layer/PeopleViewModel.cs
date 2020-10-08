using PersonRepository.Factory;
using PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace PeopleViewer.Layer
{

    public class PeopleViewModel : INotifyPropertyChanged
    {
        private IPersonRepository repository;
        private IEnumerable<Person> people;

        public PeopleViewModel()
        {
            repository = FactoryRepository.GetRepository();
        }

        public IEnumerable<Person> People
        {
            get { return people; }
            set
            {
                people = value;
                RaisePropertyChanged();
            }
        }

        public void FetchData()
        {
            People = repository.GetPeople();
        }

        public void ClearData()
        {
            People = new List<Person>();
        }

        public string RepositoryType
        {
            get { return repository.GetType().ToString(); }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
