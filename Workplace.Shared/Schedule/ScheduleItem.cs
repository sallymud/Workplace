using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workplace.Shared.Schedule
{
    public class Scheduleltem
    {
        public Lesson? LessonInfo { get; set; }
        public TimeOnly Time { get; set; }
        public LessonType LT { get; set; }
        public string? Location { get; set; }
        public Group[]? Groups { get; set; }
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
