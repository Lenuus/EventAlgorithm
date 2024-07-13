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

        List<(int Id, string StartTime, string Name)> selectedEvents = SelectEvents(events, durationBetweenLocations);
        Console.WriteLine("Katılınabilecek Maksimum Etkinlik Sayısı: " + selectedEvents.Count);
        Console.Write("Katılınabilecek Etkinliklerin ID'leri ve Başlangıç Zamanları: ");
        foreach (var ev in selectedEvents)
        {
            Console.Write($"({ev.Id}, {ev.StartTime},{ev.Name}), ");
        }
        Console.WriteLine();
        Console.WriteLine("Toplam Değer: " + CalculateTotalPriority(events, selectedEvents.Select(e => e.Id).ToList()));
    }


    static List<(int Id, string StartTime,string Name)> SelectEvents(List<Event> events, List<DurationBetweenLocations> durationBetweenLocations)
    {
        events.Sort((x, y) => y.Priority.CompareTo(x.Priority));

        List<(int Id, string StartTime, string Name)> selectedEvents = new List<(int, string,string)>();
        HashSet<string> visitedLocations = new HashSet<string>();

        foreach (var ev in events)
        {
            if (!visitedLocations.Contains(ev.Location))
            {
                selectedEvents.Add((ev.Id, ev.Name, ev.StartTime.ToString()));
                visitedLocations.Add(ev.Location);
            }
        }

        return selectedEvents;
    }

    static int CalculateTotalPriority(List<Event> events, List<int> selectedEventIds)
    {
        int totalPriority = 0;
        foreach (var eventId in selectedEventIds)
        {
            var ev = events.Find(e => e.Id == eventId);
            totalPriority += ev.Priority;
        }
        return totalPriority;
    }
}
