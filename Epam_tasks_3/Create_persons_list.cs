using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_tasks_3
{
    class Create_persons_list
    {
        public void Persons()
        {
            List<Person> people = new List<Person>(6);
            people.Add(new Person() { Name = "Vasul", Age = 18, PhoneNumbers = new List<string>() { "+380456543412", "+380124364265" } });
            people.Add(new Person() { Name = "Dima", Age = 10, PhoneNumbers = new List<string>() { "+380983042312", "+3805742356" } });
            people.Add(new Person() { Name = "Bodya", Age = 21, PhoneNumbers = new List<string>() { "+380935723146", "+380903415203" } });
            people.Add(new Person() { Name = "Petya", Age = 41, PhoneNumbers = new List<string>() { "+380671743652", "+380923175624" } });
            people.Add(new Person() { Name = "Vova", Age = 74, PhoneNumbers = new List<string>() { "+380676472153", "+380981462375" } });
            people.Add(new Person() { Name = "Sanya", Age = 33, PhoneNumbers = new List<string>() { "+380666452317", "+380957514263", "+380683651472" } });
            people.Add(new Person() { Name = "Diana", Age = 33, PhoneNumbers = new List<string>() { "+380662356471", "+380926573214", "+380686574132" } });
            foreach (Person p in people)
            {
                Console.WriteLine("Name:  {0}    Age:  {1}    ",  p.Name, p.Age );

            }
        }

    }
}
