using EventAlgorithm.Domain;

namespace EventAlgorithm.MockData
{
    public class MockData
    {
        public static List<Event> GetEvents()
        {
            return new List<Event>
            {
                new Event { Id = 1, StartTime = TimeSpan.Parse("10:00"),Name="Aile", EndTime = TimeSpan.Parse("12:00"), Location = "A", Priority = 50 },
                new Event { Id = 2, StartTime = TimeSpan.Parse("10:00"),Name="Toplantı", EndTime = TimeSpan.Parse("11:00"), Location = "B", Priority = 30, },
                new Event { Id = 3, StartTime = TimeSpan.Parse("11:30"),Name="Dugun", EndTime = TimeSpan.Parse("12:30"), Location = "A", Priority = 40 },
                new Event { Id = 4, StartTime = TimeSpan.Parse("14:30"),Name="Nisan", EndTime = TimeSpan.Parse("16:00"), Location = "C", Priority = 70  },
                new Event { Id = 5, StartTime = TimeSpan.Parse("14:25"),Name="Hastane", EndTime = TimeSpan.Parse("15:30"), Location = "B", Priority = 60  },
                new Event { Id = 6, StartTime = TimeSpan.Parse("13:00"),Name="Parti", EndTime = TimeSpan.Parse("14:00"), Location = "D", Priority = 10  }
            };
        }

        public static List<DurationBetweenLocations> GetDurationBetweenLocations()
        {
            return new List<DurationBetweenLocations>
            {
                new DurationBetweenLocations { From = "A", To = "B", DurationMinutes = 60 },
                new DurationBetweenLocations { From = "A", To = "C", DurationMinutes = 40 },
                new DurationBetweenLocations { From = "A", To = "D", DurationMinutes = 20 },
                new DurationBetweenLocations { From = "B", To = "C", DurationMinutes = 35 },
                new DurationBetweenLocations { From = "B", To = "D", DurationMinutes = 30 },
                new DurationBetweenLocations { From = "C", To = "D", DurationMinutes = 15 }
            };
        }
    }
}
