using System;
using System.Collections.Generic;
using System.Text;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class MainViewModel
    {
        private PersonRepository personRepo;

        public MainViewModel()
        {
            personRepo = new PersonRepository();
        }
    }
}
