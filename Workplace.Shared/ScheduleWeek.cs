using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workplace.Shared
{
    public class ScheduleWeek
    {
        public int Id { get; set; }
        public bool EvenWeek { get; set; }
        public ScheduleDay[]? DaysInWeek { get; set; } = new ScheduleDay[7];
    }

    public class ScheduleDay
    {
        public DateOnly Date { get; set; }
        public ScheduleItem[]? ItemsInDay { get; set; }
    }

    public class ScheduleItem
    {
        public Lesson? LessonInfo { get; set; }
        public TimeOnly Time { get; set; }
        public LessonType LT { get; set; }
        public string? Location { get; set; }
        public Student[]? Students { get; set; }
    }

    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Group { get; set; }
    }

    public class Lesson
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string[]? Teachers { get; set; } = new string[3];
    }

    public enum LessonType
    {
        Лекция,
        Практика,
        Лабораторная_работа,
        Консультация,
        Экзамен
    }
}