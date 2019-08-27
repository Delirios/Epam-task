using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_tasks_3
{
    class Task_3
    {

        List<string> Random_List = new List<string>();
        int counter = 0;
        int counter2 = 0;
        public void Random_list()
        {
            //counter = 0;
            int rands;
            Random random = new Random();
            char[] randomWord = new char[4];
            //A-Z (65-91) a-z(97-122) 0-9(48-57)
            for (int i = 0; i < 200; i++)
            {
                
                string word = "";
                for (int j = 0; j < randomWord.Length; j++)
                {
                    rands = Convert.ToInt32(random.Next(65, 91));
                    randomWord[j] = Convert.ToChar(rands);
                    word = new string( randomWord);
                    

                }
                Random_List.Add(word);
                counter++;

            }
            //Console.WriteLine(randomWord);
            //Random_List.Add(list);

            //Random_List.Reverse();






            counter2 = counter;
            for (int i = 0; i < Random_List.Count; i++)
            {
                // select the first element
                string first = Random_List[i];

                // select the next element if it exists
                if ((i + 1) == Random_List.Count) break;
                string second = Random_List[(i + 1)];

                // remove the second one if they're equal
                if (first.Equals(second))
                {
                    Random_List.RemoveAt((i + 1));
                    i--;
                    counter2--;
                }
                

            }


            for (int i = 0; i < Random_List.Count; i++)
            {

                if (Random_List[i].StartsWith('Z'))
                {
                    Random_List.Remove(Random_List[i]);
                    counter2--;
                }
                

            }


            Random_List.Sort();
            Random_List.Reverse();
            foreach (var item in Random_List)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("With Z and duplicates: " + counter);
            Console.WriteLine("Without Z and duplicates: " + counter2);



        }





        public void DisplayPage(int pageNumber)
        {
                     
            
                for (int i = (pageNumber - 1) * 5; i < (pageNumber - 1) * 5 + 5; i++)
                {
                    Console.WriteLine(Random_List[i]);
                }
          
            
        }
    }
}
