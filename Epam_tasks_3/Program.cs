using System;
using System.Collections.Generic;

namespace Epam_tasks_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task_1
            Create_persons_list create_Persons = new Create_persons_list();
            create_Persons.Persons();
            #endregion
            Console.WriteLine();
            #region Task_2
            Add_persons add_Persons = new Add_persons();
            add_Persons.Add_people();
            #endregion
            #region Task_3
            Task_3 task_3 = new Task_3();
            task_3.Random_list();
            Console.WriteLine();
            int res;


            while (true)
            {
                Console.Write("Input Page Number:  ");
                string PageNumber = Console.ReadLine();
                if (int.TryParse(PageNumber, out res) && Convert.ToInt32(PageNumber) != 0)
                {
                    task_3.DisplayPage(Convert.ToInt32(PageNumber));

                }
                else if (PageNumber == "exit")
                {
                    return;
                }
                else 
                {
                    Console.WriteLine("Input error!");
                    continue;
                }
               
            }

            #endregion

        }
    }
}
