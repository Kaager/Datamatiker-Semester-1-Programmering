using System;
using System.Collections.Generic;
using System.Text;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class MainViewModel
    {
        private PersonRepository personRepo;
        public List<PersonViewModel> PersonsVM { get; set; }
        public PersonViewModel SelectedPersonVM { get; set; } 

        public MainViewModel()
        {
            personRepo = new PersonRepository();

            PersonsVM = new();
            foreach (Person person in personRepo.GetAll())
            {
                PersonsVM.Add(new PersonViewModel(person));
            }
        }
    }
}
