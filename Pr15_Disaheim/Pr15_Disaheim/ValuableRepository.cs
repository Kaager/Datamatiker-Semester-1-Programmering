using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Pr15_Disaheim
{
    public class ValuableRepository : IPersistable
    {
        private List<IValuable> valuables = new();
        // could also be:
        //private List<IValuable> valuables = [];
        // or the longer:
        //private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string id)
        {
            foreach (IValuable valuable in valuables)
            {
                if (valuable is Merchandise merch)
                {
                    if (id == merch.ItemId)
                        return valuable;
                }
                else if (valuable is Course aCourse)
                {
                    if (id == aCourse.Name)
                        return aCourse;
                }
            }
            throw new KeyNotFoundException($"No valuable with ID '{id}' found.");
        }

        public double GetTotalValue()
        {
            double totalValue = 0;
            foreach(IValuable v in valuables)
            {
                totalValue += v.GetValue();
            }
            return totalValue;
        }

        public int Count()
        {
            return valuables.Count;
        }

        public void Save()
        {
            StreamWriter sw = new("ValuableRepository.txt");

            foreach (IValuable valuable in valuables)
            {
                if (valuable is Book book)
                    sw.WriteLine($"BOG;{book.ItemId};{book.Title};{book.GetValue()}");
                else if (valuable is Amulet amulet)
                    sw.WriteLine($"AMULET;{amulet.ItemId};{amulet.Quality};{amulet.Design}");
                else if (valuable is Course course)
                    sw.WriteLine($"KURSUS;{course.Name};{course.DurationInMinutes}");
            }
            sw.Close();
        }

        public void Save(string fileName)
        {
            StreamWriter sw = new(fileName);

            foreach (IValuable valuable in valuables)
            {
                if (valuable is Book book)
                    sw.WriteLine($"BOG;{book.ItemId};{book.Title};{book.GetValue()}");
                else if (valuable is Amulet amulet)
                    sw.WriteLine($"AMULET;{amulet.ItemId};{amulet.Quality};{amulet.Design}");
                else if (valuable is Course course)
                    sw.WriteLine($"KURSUS;{course.Name};{course.DurationInMinutes}");
            }
            sw.Close();
        }

        public void Load()
        {
            string fileName = "ValuableRepository.txt";

            if (File.Exists(fileName)){
                string[] linesOfText = File.ReadAllLines(fileName);

                foreach (string line in linesOfText)
                {
                    string[] values = line.Split(';');
                    IValuable? valuable = null;
                    if (values[0] == "BOG")
                        valuable = new Book(values[1], values[2], double.Parse(values[3]));
                    else if (values[0] == "AMULET")
                        valuable = new Amulet(values[1], Enum.Parse<Level>(values[2]), values[3]);
                    else if (values[0] == "KURSUS")
                        valuable = new Course(values[1], int.Parse(values[2]));

                    if (valuable is not null)
                        AddValuable(valuable);
                }
            }
        }

        public void Load(string fileName)
        {
            if (File.Exists(fileName)){
                string[] linesOfText = File.ReadAllLines(fileName);

                foreach (string line in linesOfText)
                {
                    string[] values = line.Split(';');
                    IValuable? valuable = null;
                    if (values[0] == "BOG")
                        valuable = new Book(values[1], values[2], double.Parse(values[3]));
                    else if (values[0] == "AMULET")
                        valuable = new Amulet(values[1], Enum.Parse<Level>(values[2]), values[3]);
                    else if (values[0] == "KURSUS")
                        valuable = new Course(values[1], int.Parse(values[2]));

                    if (valuable is not null)
                        AddValuable(valuable);
                }
            }
        }
    }
}
