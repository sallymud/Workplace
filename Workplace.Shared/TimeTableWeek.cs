namespace Workplace.Shared
{
    public class TimeTableWeek
    {
        public int Id { get; set; }
        public bool EvenWeek { get; set; }
        public TimeTableDay[]? DaysInWeek { get; set; } = new TimeTableDay[6];
    }

    public class TimeTableDay
    {
        public DateOnly Date { get; set; }
        public TimeTableItem[]? ItemsInDay { get; set; }
    }

    public class TimeTableItem
    {
        public int Id { get; set; }
        public TimeOnly Time { get; set; }
        public string? LessonName { get; set; }
        public LessonType LT { get; set; }
        public string? Teacher { get; set; }
        public string? Location { get; set; }
        public string[]? Students { get; set; }

        public enum LessonType
        {
            Лекция,
            Практика,
            Лабораторная_работа,
            Консультация,
            Экзамен
        }
    }
}
