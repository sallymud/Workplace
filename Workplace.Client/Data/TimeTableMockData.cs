using System.Threading.Tasks;
using Workplace.Shared;

namespace Workplace.Client.Data
{
    public class TimeTableMockData : TimeTableDataService
    {
        public List<RawTimeTableItem> items = [
            new RawTimeTableItem() {
                Slug = "math",
                Name = "Математика",
                Teachers = [
                    "Иванов Иван Иванович",
                    "Мамидярова Зухра Кхъоровна",
                    "Кёрхер Эдуард Графоманович"
                ]
            },

            new RawTimeTableItem() {
                Slug = "phys_ed",
                Name = "Физическая культура",
                Teachers = [
                    "Абдурозов Абдурозик Абдурович",
                    "Хасбуллов Хасбулла Хасбуллович",
                    "Майнкрафтов Стив Александрович"
                ]
            },

            new RawTimeTableItem() {
                Slug = "bgd",
                Name = "Безопасность жизнедеятельности",
                Teachers = [
                    "Паровозов Аркадий Светофорович",
                    "Дедков Степан Рахметович",
                    "Зайнетдинов Добрыня Мамедрагимович"
                ]
            }
            ];

        public readonly List<TimeTableWeek> weeks = [
            new TimeTableWeek() {
                Id = 0,
                EvenWeek = false,
                DaysInWeek = [
                    new TimeTableDay {
                        Date = new DateOnly(2024, 6, 10),
                        ItemsInDay = []
                    },
                    new TimeTableDay {
                        Date = new DateOnly(2024, 6, 11),
                        ItemsInDay = [
                            new TimeTableItem() {
                                Id = 1,
                                Time = new TimeOnly(8, 0),
                                LessonName = "Физическая культура",
                                LT = TimeTableItem.LessonType.Практика,
                                Teacher = "Хасбуллов Хасбулла Хасбуллович",
                                Location = "ул.Пушкина, д.Колотушкина",
                                Students = [
                                    "Ваня Дырка",
                                    "Вася Пупкин",
                                    "Даздраперма Василькова",
                                    "Иосиф Сталин",
                                    "Олег Тиньков",
                                    "Т-Банк Сбербанкович"
                                ]
                            },
                            new TimeTableItem() {
                                Id = 0,
                                Time = new TimeOnly(9, 45),
                                LessonName = "Математика",
                                LT = TimeTableItem.LessonType.Лабораторная_работа,
                                Teacher = "Иванов Иван Иванович",
                                Location = "ул.Колотушкина, д.Пушкина",
                                Students = [
                                    "Ваня Дырка",
                                    "Вася Пупкин",
                                    "Даздраперма Василькова",
                                    "Иосиф Сталин",
                                    "Олег Тиньков",
                                    "Т-Банк Сбербанкович"
                                ]
                            }
                        ]
                    },
                    new TimeTableDay {
                        Date = new DateOnly(2024, 6, 12),
                        ItemsInDay = [
                            new TimeTableItem() {
                                Id = 2,
                                Time = new TimeOnly(9, 45),
                                LessonName = "Безопасность жизнедеятельности",
                                LT = TimeTableItem.LessonType.Лекция,
                                Teacher = "Паровозов Аркадий Светофорович",
                                Location = "ул.Пушкина, д.Колотушкина",
                                Students = [
                                    "Ваня Дырка",
                                    "Вася Пупкин",
                                    "Даздраперма Василькова",
                                    "Иосиф Сталин",
                                    "Олег Тиньков",
                                    "Т-Банк Сбербанкович"
                                ]
                            },
                            new TimeTableItem() {
                                Id = 2,
                                Time = new TimeOnly(11, 30),
                                LessonName = "Безопасность жизнедеятельности",
                                LT = TimeTableItem.LessonType.Практика,
                                Teacher = "Дедков Степан Рахметович",
                                Location = "ул.Пушкина, д.Колотушкина",
                                Students = [
                                    "Ваня Дырка",
                                    "Вася Пупкин",
                                    "Даздраперма Василькова",
                                    "Иосиф Сталин",
                                    "Олег Тиньков",
                                    "Т-Банк Сбербанкович"
                                ]
                            }
                        ]
                    }
                ]
            },
            new TimeTableWeek() {
                Id = 1,
                EvenWeek = true,
                DaysInWeek = [
                    new TimeTableDay {
                        Date = new DateOnly(2024, 6, 17),
                        ItemsInDay = []
                    },
                    new TimeTableDay {
                        Date = new DateOnly(2024, 6, 18),
                        ItemsInDay = [
                            new TimeTableItem() {
                                Id = 1,
                                Time = new TimeOnly(8, 0),
                                LessonName = "Физическая культура",
                                LT = TimeTableItem.LessonType.Практика,
                                Teacher = "Хасбуллов Хасбулла Хасбуллович",
                                Location = "ул.Пушкина, д.Колотушкина",
                                Students = [
                                    "Ваня Дырка",
                                    "Вася Пупкин",
                                    "Даздраперма Василькова",
                                    "Иосиф Сталин",
                                    "Олег Тиньков",
                                    "Т-Банк Сбербанкович"
                                ]
                            },
                            new TimeTableItem() {
                                Id = 0,
                                Time = new TimeOnly(9, 45),
                                LessonName = "Математика",
                                LT = TimeTableItem.LessonType.Лекция,
                                Teacher = "Иванов Иван Иванович",
                                Location = "ул.Колотушкина, д.Пушкина",
                                Students = [
                                    "Ваня Дырка",
                                    "Вася Пупкин",
                                    "Даздраперма Василькова",
                                    "Иосиф Сталин",
                                    "Олег Тиньков",
                                    "Т-Банк Сбербанкович"
                                ]
                            }
                        ]
                    },
                    new TimeTableDay {
                        Date = new DateOnly(2024, 6, 19),
                        ItemsInDay = [
                            new TimeTableItem() {
                                Id = 2,
                                Time = new TimeOnly(9, 45),
                                LessonName = "Безопасность жизнедеятельности",
                                LT = TimeTableItem.LessonType.Лекция,
                                Teacher = "Паровозов Аркадий Светофорович",
                                Location = "ул.Пушкина, д.Колотушкина",
                                Students = [
                                    "Ваня Дырка",
                                    "Вася Пупкин",
                                    "Даздраперма Василькова",
                                    "Иосиф Сталин",
                                    "Олег Тиньков",
                                    "Т-Банк Сбербанкович"
                                ]
                            },
                            new TimeTableItem() {
                                Id = 2,
                                Time = new TimeOnly(11, 30),
                                LessonName = "Безопасность жизнедеятельности",
                                LT = TimeTableItem.LessonType.Практика,
                                Teacher = "Дедков Степан Рахметович",
                                Location = "ул.Пушкина, д.Колотушкина",
                                Students = [
                                    "Ваня Дырка",
                                    "Вася Пупкин",
                                    "Даздраперма Василькова",
                                    "Иосиф Сталин",
                                    "Олег Тиньков",
                                    "Т-Банк Сбербанкович"
                                ]
                            }
                        ]
                    }
                ]
            },
        ];

        public async Task<List<TimeTableWeek>> GetDataAsync()
        {
            //await Task.Delay(1000);
            return await Task.FromResult<List<TimeTableWeek>>(weeks);
        }

        public async Task<TimeTableWeek> GetWeekAsync(int Id)
        {
            return await Task.FromResult<TimeTableWeek>(weeks.First(x => x.Id == Id));
        }
    }
}
