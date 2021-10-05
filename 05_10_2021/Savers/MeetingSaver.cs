using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _05_10_2021.Savers
{
    class MeetingSaver
    {
        private Meeting _objectToSave;

        public MeetingSaver(Meeting objectToSave)
        {
            _objectToSave = objectToSave;
        }

        public void Save(string directoryName)
        {
            string pathToFile = directoryName + "\\" + _objectToSave.Begin.ToFileTime() + ".txt";
            FileStream fileStream = new FileStream(pathToFile,  FileMode.Create, FileAccess.Write);
            fileStream.Close();

            StreamWriter streamWriter = new StreamWriter(pathToFile);

            DateTimeSaver beginSaver = new DateTimeSaver(_objectToSave.Begin);
            beginSaver.Save(streamWriter);

            DateTimeSaver endSaver = new DateTimeSaver(_objectToSave.End);
            endSaver.Save(streamWriter);

            TimeSpanSaver notificationSaver = new TimeSpanSaver(_objectToSave.Notification);
            notificationSaver.Save(streamWriter);

            streamWriter.WriteLine(_objectToSave.Description);

            streamWriter.Close();
        }
    }
}
