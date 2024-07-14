using EventAlgorithm;
using EventAlgorithm.Domain;
using EventAlgorithm.MockData;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Event> events = MockData.GetEvents();
        List<DurationBetweenLocations> durationBetweenLocations = MockData.GetDurationBetweenLocations();

        List<Event> selectedEvents = SelectEvents(events, durationBetweenLocations, out int sumPriority);
        Console.WriteLine("Katılınabilecek Maksimum Etkinlik Sayısı: " + selectedEvents.Count);
        Console.Write("Katılınabilecek Etkinliklerin ID'leri ve Başlangıç Zamanları: ");
        foreach (var ev in selectedEvents)
        {
            Console.Write($"({ev.Id}, {ev.StartTime}), ");
        }
        Console.WriteLine();
        Console.WriteLine("Toplam Değer: " + sumPriority);
    }


    static List<Event> SelectEvents(List<Event> events, List<DurationBetweenLocations> durationBetweenLocations, out int totalPriority)
    {
        totalPriority = 0;
        events.Sort((x, y) => y.Priority.CompareTo(x.Priority));

        List<Event> selectedEvents = new List<Event>();
        HashSet<string> visitedLocations = new HashSet<string>();

        foreach (var ev in events)
        {
            if (visitedLocations.Contains(ev.Location))
            {
                continue;
            }
            bool overlap = selectedEvents.Any(f => (ev.StartTime < f.EndTime && ev.EndTime > f.StartTime) &&
            durationBetweenLocations.Any(x => (x.From == f.Location && x.To == ev.Location) ||
            ( x.From == ev.Location && x.To == f.Location)));

            if (!overlap)
            {
                selectedEvents.Add(ev);
                visitedLocations.Add(ev.Location);
                totalPriority += ev.Priority;
                if (selectedEvents.Count == 3)
                {
                    break;
                }

            }
        }

        return selectedEvents;
    }
}
