using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _05_10_2021.Loaders
{
    class DiaryLoader
    {
        string _path;

        public DiaryLoader(string path)
        {
            _path = path;
        }

        public Diary Load()
        {
            List<Meeting> meetings = new List<Meeting>();
            foreach (var yearDirectory in Directory.EnumerateDirectories(_path))
            {
                foreach (var monthDirectory in Directory.EnumerateDirectories(yearDirectory))
                {
                    foreach (var dayDirectory in Directory.EnumerateDirectories(monthDirectory))
                    {
                        foreach (var meetingFilePath in Directory.EnumerateFiles(dayDirectory))
                        {
                            MeetingLoader meetingLoader = new MeetingLoader(meetingFilePath);
                            meetings.Add(meetingLoader.Load());
                        }
                    }
                }
            }
            return new Diary(meetings);
        }
    }
}
