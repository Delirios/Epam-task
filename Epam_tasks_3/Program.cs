using System;
using System.Collections.Generic;

namespace Epam_tasks_3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Create_persons_list create_Persons = new Create_persons_list();
            create_Persons.Persons();
            Console.WriteLine();
            Add_persons add_Persons = new Add_persons();
            add_Persons.Add_people();

        }
    }
}
