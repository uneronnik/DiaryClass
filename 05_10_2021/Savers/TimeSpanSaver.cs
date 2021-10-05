using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _05_10_2021.Savers
{
    class TimeSpanSaver
    {
        private TimeSpan _objectToSave;

        public TimeSpanSaver(TimeSpan objectToSave)
        {
            _objectToSave = objectToSave;
        }

        public void Save(StreamWriter streamWriter)
        {
            string stringToWrite = "";
            stringToWrite += _objectToSave.Hours + "\n";
            stringToWrite += _objectToSave.Minutes + "\n";
            
            streamWriter.Write(stringToWrite);
        }
    }
}
