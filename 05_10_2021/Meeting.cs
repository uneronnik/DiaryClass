using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_10_2021
{
    sealed class Meeting
    {

        public Meeting(DateTime begin, DateTime end, TimeSpan notification, string description)
        {
            Begin = begin;
            End = end;
            Notification = notification;
            Description = description;
        }

        public DateTime Begin { get; private set; }
        public DateTime End { get; private set; }
        public TimeSpan Notification { get; private set; }
        public string Description { get; private set; }

        public override string ToString()
        {
            string stringToReturn = "";
            stringToReturn += $"Начало: {Begin}\n";
            stringToReturn += $"Конец: {End}\n";
            stringToReturn += $"Время за которое нужно уведомить: {Notification}\n";
            stringToReturn += $"{Description}";
            return stringToReturn;
        }
        
    }
}
