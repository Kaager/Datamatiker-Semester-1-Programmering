using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private PersonRepository personRepo;
        public ObservableCollection<PersonViewModel> PersonsVM { get; set; }
        private PersonViewModel _selectedPersonVM;
        public PersonViewModel SelectedPersonVM 
        {
            get => _selectedPersonVM;
            set
            {
                _selectedPersonVM = value;
                OnPropertyChanged();
            }
        } 

        public MainViewModel()
        {
            personRepo = new PersonRepository();

            PersonsVM = new();
            foreach (Person person in personRepo.GetAll())
            {
                PersonsVM.Add(new PersonViewModel(person));
            }
        }

        public void AddDefaultPerson()
        {
            Person newPerson = personRepo.Add("Specify FirstName", "Specify LastName", 0, "Specify Phone");
            PersonViewModel newPersonVM = new(newPerson);
            PersonsVM.Add(newPersonVM);
            SelectedPersonVM = newPersonVM;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
