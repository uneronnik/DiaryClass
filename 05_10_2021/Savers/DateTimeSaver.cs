using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _05_10_2021.Savers
{
    class DateTimeSaver
    {
        private DateTime _objectToSave;

        public DateTimeSaver(DateTime objectToSave)
        {
            _objectToSave = objectToSave;
        }

        public void Save(StreamWriter streamWriter)
        {
            string stringToWrite = "";
            stringToWrite += _objectToSave.Year + "\n";
            stringToWrite += _objectToSave.Month + "\n";
            stringToWrite += _objectToSave.Day + "\n";
            stringToWrite += _objectToSave.Hour + "\n";
            stringToWrite += _objectToSave.Minute + "\n";
            streamWriter.Write(stringToWrite);
        }
    }
}
