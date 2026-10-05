using System;
using System.Collections.Generic;
using System.IO;

namespace Pr13_Persistence_2
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
            using StreamWriter saveStream = new(DataFileName);
            saveStream.WriteLine(person.MakeTitle());
        }

        public void SavePersons(Person[] persons)
        {
            using StreamWriter writer = new(DataFileName);

            foreach (Person person in persons)
            {
                writer.WriteLine(person.MakeTitle());
            }
        }

        public Person LoadPerson()
        {
            using StreamReader loadStream = new(DataFileName);
            string[] arr = loadStream.ReadLine().Split(';');

            Person somePerson = new(arr[0], DateTime.Parse(arr[1]), double.Parse(arr[2]), bool.Parse(arr[3]), int.Parse(arr[4]));

            return somePerson;

        }

        public Person[] LoadPersons()
        {
            int count = 0;

            using StreamReader reader = new(DataFileName);
            while (reader.ReadLine() != null)
            {
                count++;
            }

            using StreamReader reader_2 = new(DataFileName);
            Person[] persons = new Person[count];

            for (int i = 0; i < count; i++)
            {
                string line = reader_2.ReadLine();
                string[] arr = line.Split(';');
                Person somePerson = new(arr[0], DateTime.Parse(arr[1]), double.Parse(arr[2]), bool.Parse(arr[3]), int.Parse(arr[4]));
                persons[i] = somePerson;
            }
          
            return persons;

        }
    }
}
