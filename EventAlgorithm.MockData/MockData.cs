using EventAlgorithm.Domain;

namespace EventAlgorithm.MockData
{
    public class MockData
    {
        public static List<Event> GetEvents()
        {
            return new List<Event>
            {
                new Event { Id = 1, StartTime = TimeSpan.Parse("10:00"), EndTime = TimeSpan.Parse("12:00"), Location = "A", Priority = 50 },
                new Event { Id = 2, StartTime = TimeSpan.Parse("10:00"), EndTime = TimeSpan.Parse("11:00"), Location = "B", Priority = 30, },
                new Event { Id = 3, StartTime = TimeSpan.Parse("11:30"), EndTime = TimeSpan.Parse("12:30"), Location = "A", Priority = 40 },
                new Event { Id = 4, StartTime = TimeSpan.Parse("14:30"), EndTime = TimeSpan.Parse("16:00"), Location = "C", Priority = 70  },
                new Event { Id = 5, StartTime = TimeSpan.Parse("14:25"), EndTime = TimeSpan.Parse("15:30"), Location = "B", Priority = 60  },
                new Event { Id = 6, StartTime = TimeSpan.Parse("13:00"), EndTime = TimeSpan.Parse("14:00"), Location = "D", Priority = 80  }
            };
        }

        public static List<DurationBetweenLocations> GetDurationBetweenLocations()
        {
            return new List<DurationBetweenLocations>
            {
                new DurationBetweenLocations { From = "A", To = "B", DurationMinutes = 15 },
                new DurationBetweenLocations { From = "A", To = "C", DurationMinutes = 20 },
                new DurationBetweenLocations { From = "A", To = "D", DurationMinutes = 10 },
                new DurationBetweenLocations { From = "B", To = "C", DurationMinutes = 5 },
                new DurationBetweenLocations { From = "B", To = "D", DurationMinutes = 25 },
                new DurationBetweenLocations { From = "C", To = "D", DurationMinutes = 15 }
            };
        }
    }
}
