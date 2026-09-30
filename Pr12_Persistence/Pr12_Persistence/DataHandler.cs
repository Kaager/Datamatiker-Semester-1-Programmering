using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Pr12_Persistence
{
    public class DataHandler
    {
        private string _dataFileName;
        //public string DataFileName { get => _dataFileName; } // Same as:
        public string DataFileName => _dataFileName;

        public DataHandler(string dataFileName)
        {
            _dataFileName = dataFileName;
        }

        public void SavePerson(Person person)
        {
            StreamWriter saveStream = new(DataFileName);
            saveStream.WriteLine(person.MakeTitle());
            saveStream.Close();
        }

        public Person LoadPerson()
        {
            StreamReader loadStream = new(DataFileName);
            string[] arr = loadStream.ReadLine().Split(';');
            loadStream.Close();

            Person somePerson = new(arr[0], DateTime.Parse(arr[1]), double.Parse(arr[2]), bool.Parse(arr[3]), int.Parse(arr[4]));

            return somePerson;

        }
    }
}
