using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_tasks_3
{
    class Add_persons
    {
        public void Add_people()
        {
            List<Person> people = new List<Person>(6);
            people.Add(new Person() { Name = "Vasul", Age = 18, PhoneNumbers = new List<string>() { "+380456543412", "+380124364265" } });
            people.Add(new Person() { Name = "Dima", Age = 10, PhoneNumbers = new List<string>() { "+380983042312", "+3805742356" } });
            people.Add(new Person() { Name = "Bodya", Age = 21, PhoneNumbers = new List<string>() { "+380935723146", "+380903415203" } });
            people.Add(new Person() { Name = "Petya", Age = 41, PhoneNumbers = new List<string>() { "+380671743652", "+380923175624" } });
            people.Add(new Person() { Name = "Vova", Age = 74, PhoneNumbers = new List<string>() { "+380676472153", "+380981462375" } });
            people.Add(new Person() { Name = "Sanya", Age = 33, PhoneNumbers = new List<string>() { "+380666452317", "+380957514263", "+380683651472" } });
            people.Add(new Person() { Name = "Diana", Age = 33, PhoneNumbers = new List<string>() { "+380662356471", "+380926573214", "+380686574132" } });


            List<Person> Addpeople = new List<Person>(2);

            Addpeople.Add(new Person() { Name = "Stepan", Age = 31, PhoneNumbers = new List<string> { "+380674312576", "+380921463725" } });
            Addpeople.Add(new Person() { Name = "Ira", Age = 28, PhoneNumbers = new List<string> { "+380674312576", "+380924756321", "+380962354535" } });          
            people.AddRange(Addpeople);

            foreach (var item in people)
            {
                Console.Write($"Name = {item.Name},   Age = {item.Age},  Phone numbers:  ");
                foreach (var numbers in item.PhoneNumbers)
                {
                    Console.Write($"{numbers} ");
                }
                Console.WriteLine();
            }
        }
    }
}
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /*/
        List<Person> Addpeople = new List<Person>();
        public List<Person> GetPeople
        {
            get
            {
                List<Person> temp = new List<Person>();

                foreach (var item in Addpeople)
                {
                    Console.Write($"Name={item.Name}, Age={item.Age}, Phone numbers: ");
                    foreach (var numbers in item.PhoneNumbers)
                    {
                        Console.Write($"{numbers} ");
                    }
                    Console.WriteLine();
                }
                return temp;
            }
        }
        /*/