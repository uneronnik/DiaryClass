using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _05_10_2021.Loaders;
using _05_10_2021.Savers;
namespace _05_10_2021
{
    class Program
    {

        static void Main(string[] args)
        {
            //List<Meeting> meetings = new List<Meeting>();
            //meetings.Add(new Meeting(new DateTime(2019, 9, 9, 9, 10, 0)
            //            , new DateTime(2019, 9, 9, 10, 10, 0),
            //            new TimeSpan(1, 0, 0), "Описание1"));
            //meetings.Add(new Meeting(new DateTime(2020, 9, 9)
            //            , new DateTime(2020, 9, 9),
            //            new TimeSpan(1, 0, 0), "Описание2"));
            //Diary diary = new Diary(meetings);

            
            DiaryLoader diaryLoader = new DiaryLoader("Diary");
            Diary diary = new Diary(diaryLoader.Load());

            Console.WriteLine(diary.ToString());
            Console.ReadKey();
        }
    }
}
