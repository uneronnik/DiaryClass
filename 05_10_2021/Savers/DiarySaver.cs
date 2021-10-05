using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05_10_2021.Savers
{
    class DiarySaver
    {
        private Diary _objectToSave;

        public DiarySaver(Diary objectToSave)
        {
            _objectToSave = objectToSave;
        }

        public void Save(string directoryName)
        {
            
            Directory.CreateDirectory(directoryName);

            foreach (var meeting in _objectToSave.Meetings)
            {
                string pathToFileDirectory = $"{directoryName}\\{meeting.Begin.Year.ToString()}\\{meeting.Begin.Month.ToString()}\\{meeting.Begin.Day.ToString()}";
                Directory.CreateDirectory(pathToFileDirectory);

                MeetingSaver meetingSaver = new MeetingSaver(meeting);
                meetingSaver.Save(pathToFileDirectory);
            }
        }
    }
}
