using System.Threading.Tasks;
using Workplace.Shared.Schedule;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Workplace.Client.Data.Schedule
{
    public class ScheduleMockData : IScheduleDataService
    {
        public readonly List<ScheduleDay> data = [
			new ScheduleDay {
				Date = new DateOnly(2024, 6, 16),
				ItemsInDay = []
			},
			new ScheduleDay {
                Date = new DateOnly(2024, 6, 17),
                ItemsInDay = [
                    new Scheduleltem() {
                        LessonInfo = new Lesson() {
                            Id = 0,
                            Name = "Физическая культура",
                            Teachers = [
                                "Не придумал Иванович",
                                "Кто-то Александрович",
                                "Альберт Эйнштейн"
                            ]
                        },
                        Time = new TimeOnly(8, 0),
                        LT = LessonType.Практика,
                        Location = "ул.Пушкина, д.Колотушкина",
                        Groups = [
                            new Group() {
                            Id = 0,
                            Name = "МКМб 22-1",
                            Students = [
                                new Student() {
                                    Id = 0,
                                    Name = "Ваня Дырка"
                                },
                                new Student() {
                                    Id = 1,
                                    Name = "Вася Пупкин"
                                },
                                new Student() {
                                    Id = 2,
                                    Name = "Даздраперма Василькова"
                                },
                                new Student() {
                                    Id = 3,
                                    Name = "Иосиф Сталин"
                                },
                                new Student() {
                                    Id = 4,
                                    Name = "Олег Тиньков"
                                },
                                new Student() {
                                    Id = 5,
                                    Name = "Т-Банк Сбербанкович"
                                }
                            ]
                        },
                            new Group() {
                            Id = 1,
                            Name = "ПКТб 22-1",
                            Students = [
                                new Student() {
                                    Id = 6,
                                    Name = "Джон Доу"
                                },
                                new Student() {
                                    Id = 7,
                                    Name = "Джейн Доу"
                                },
                                new Student() {
                                    Id = 8,
                                    Name = "Кристофер Нолан"
                                },
                                new Student() {
                                    Id = 9,
                                    Name = "Стивен Спилберг"
                                },
                                new Student() {
                                    Id = 10,
                                    Name = "Саша Спилберг"
                                },
                                new Student() {
                                    Id = 11,
                                    Name = "Ян Гордиенко"
                                }
                            ]
                        }]
                    },
                    new Scheduleltem() {
                        LessonInfo = new Lesson() {
                            Id = 1,
                            Name = "Математика",
                            Teachers = [
                                "Не придумал Иванович",
                                "Кто-то Александрович",
                                "Альберт Эйнштейн"
                            ]
                        },
                        Time = new TimeOnly(9, 45),
                        LT = LessonType.Лекция,
                        Location = "ул.Колотушкина, д.Пушкина",
                        Groups = [new Group() {
                            Id = 0,
                            Name = "МКМб 22-1",
                            Students = [
                                new Student() {
                                    Id = 0,
                                    Name = "Ваня Дырка"
                                },
                                new Student() {
                                    Id = 1,
                                    Name = "Вася Пупкин"
                                },
                                new Student() {
                                    Id = 2,
                                    Name = "Даздраперма Василькова"
                                },
                                new Student() {
                                    Id = 3,
                                    Name = "Иосиф Сталин"
                                },
                                new Student() {
                                    Id = 4,
                                    Name = "Олег Тиньков"
                                },
                                new Student() {
                                    Id = 5,
                                    Name = "Т-Банк Сбербанкович"
                                }
                            ]
                        }]
                    }
                ]
            },
            new ScheduleDay {
                Date = new DateOnly(2024, 6, 19),
                ItemsInDay = [
                    new Scheduleltem() {
                        LessonInfo = new Lesson() {
                            Id = 2,
                            Name = "Безопасность жизнедеятельности",
                            Teachers = [
                                "Не придумал Иванович",
                                "Кто-то Александрович",
                                "Альберт Эйнштейн"
                            ]
                        },
                        Time = new TimeOnly(9, 45),
                        LT = LessonType.Лекция,
                        Location = "ул.Пушкина, д.Колотушкина",
                        Groups = [new Group() {
                            Id = 0,
                            Name = "МКМб 22-1",
                            Students = [
                                new Student() {
                                    Id = 0,
                                    Name = "Ваня Дырка"
                                },
                                new Student() {
                                    Id = 1,
                                    Name = "Вася Пупкин"
                                },
                                new Student() {
                                    Id = 2,
                                    Name = "Даздраперма Василькова"
                                },
                                new Student() {
                                    Id = 3,
                                    Name = "Иосиф Сталин"
                                },
                                new Student() {
                                    Id = 4,
                                    Name = "Олег Тиньков"
                                },
                                new Student() {
                                    Id = 5,
                                    Name = "Т-Банк Сбербанкович"
                                }
                            ]
                        }]
                    },
                    new Scheduleltem() {
                        LessonInfo = new Lesson() {
                            Id = 2,
                            Name = "Безопасность жизнедеятельности",
                            Teachers = [
                                "Не придумал Иванович",
                                "Кто-то Александрович",
                                "Альберт Эйнштейн"
                            ]
                        },
                        Time = new TimeOnly(11, 30),
                        LT = LessonType.Практика,
                        Location = "ул.Пушкина, д.Колотушкина",
                        Groups = [new Group() {
                            Id = 0,
                            Name = "МКМб 22-1",
                            Students = [
                                new Student() {
                                    Id = 0,
                                    Name = "Ваня Дырка"
                                },
                                new Student() {
                                    Id = 1,
                                    Name = "Вася Пупкин"
                                },
                                new Student() {
                                    Id = 2,
                                    Name = "Даздраперма Василькова"
                                },
                                new Student() {
                                    Id = 3,
                                    Name = "Иосиф Сталин"
                                },
                                new Student() {
                                    Id = 4,
                                    Name = "Олег Тиньков"
                                },
                                new Student() {
                                    Id = 5,
                                    Name = "Т-Банк Сбербанкович"
                                }
                            ]
                        }]
                    }
                ]
            }
        ];

        public async Task<ScheduleDay> GetDayAsync(DateOnly dayDate)
        {
            return await Task.FromResult<ScheduleDay>(data.First(d => d.Date == dayDate));
        }

        public async Task<List<ScheduleDay>> GetDayRangeAsync(DateOnly border1, DateOnly border2)
        {
            return await Task.FromResult<List<ScheduleDay>>(data.Where(d => d.Date.CompareTo(border1) >= 0 && d.Date.CompareTo(border2) <= 0).ToList());
        }
    }
}
