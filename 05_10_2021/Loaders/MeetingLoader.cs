using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _05_10_2021.Loaders
{
    class MeetingLoader
    {
        string _path;

        public MeetingLoader(string path)
        {
            _path = path;
        }

        public Meeting Load()
        {
            StreamReader streamReader = new StreamReader(_path);

            DateTimeLoader dateTimeLoader = new DateTimeLoader(streamReader);
            DateTime begin = dateTimeLoader.Load();
            DateTime end = dateTimeLoader.Load();

            TimeSpanLoader timeSpanLoader = new TimeSpanLoader(streamReader);
            TimeSpan notification = timeSpanLoader.Load();

            string description = streamReader.ReadLine();

            return new Meeting(begin, end, notification, description);
        }
    }
}
