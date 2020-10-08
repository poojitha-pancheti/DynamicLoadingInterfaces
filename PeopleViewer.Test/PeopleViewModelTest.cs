using NUnit.Framework;
using PeopleViewer.Layer;
using System;
using System.Linq;

namespace PeopleViewer.Test
{
   public  class PeopleViewModelTest
    {
        [Test]
        public void People_OnFetchData_IsPopulated()
        {
            var viewModel = new PeopleViewModel();

            viewModel.FetchData();

            Assert.IsNotNull(viewModel.People);
            Assert.AreEqual(2, viewModel.People.Count());
        }

        [Test]
        public void RepositoryType_OnCreation_ReturnsFakeRepoString()
        {
            var viewModel = new PeopleViewModel();
            var expectedString = "PersonRepository.Fake.FakeRepository";

            viewModel.FetchData();

            Assert.AreEqual(expectedString, viewModel.RepositoryType);
        }

        [Test]
        public void People_OnClearData_IsEmpty()
        {
            var viewModel = new PeopleViewModel();
            viewModel.FetchData();

            viewModel.ClearData();

            Assert.AreEqual(0, viewModel.People.Count());
        }
    }
}
