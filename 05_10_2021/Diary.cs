using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_10_2021
{
    class Diary
    {
        private List<Meeting> _meetings = new List<Meeting>();

        public Diary(List<Meeting> meetings)
        {
            _meetings = meetings;
        }
        public Diary(Diary diary)
        {
            _meetings = diary.Meetings;
        }

        internal List<Meeting> Meetings { get => _meetings; }

        public override string ToString()
        {
            string stringToReturn = "";
            foreach(var meeting in _meetings)
            {
                stringToReturn += meeting.ToString() + "\n\n";
            }
            return stringToReturn;
        }
    }
}
