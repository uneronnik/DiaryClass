using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _05_10_2021.Loaders
{
    class DateTimeLoader
    {
        StreamReader _streamReader;

        public DateTimeLoader(StreamReader streamReader)
        {
            _streamReader = streamReader;
        }

        public DateTime Load()
        {
            int year = Convert.ToInt32(_streamReader.ReadLine());
            int month = Convert.ToInt32(_streamReader.ReadLine());
            int day = Convert.ToInt32(_streamReader.ReadLine());
            int hour = Convert.ToInt32(_streamReader.ReadLine());
            int minute = Convert.ToInt32(_streamReader.ReadLine());
            return new DateTime(year, month, day, hour, minute, 0);
        }
    }
}
