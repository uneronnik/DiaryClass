using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _05_10_2021.Loaders
{
    class TimeSpanLoader
    {
        StreamReader _streamReader;

        public TimeSpanLoader(StreamReader streamReader)
        {
            _streamReader = streamReader;
        }
        public TimeSpan Load()
        {
            
            int hour = Convert.ToInt32(_streamReader.ReadLine());
            int minute = Convert.ToInt32(_streamReader.ReadLine());
            return new TimeSpan(hour, minute, 0);
        }
    }
}
