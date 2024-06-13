using Workplace.Shared;

namespace Workplace.Client.Data
{
    public class ScheduleMockData : IScheduleDataService
    {
        public readonly List<ScheduleWeek> weeks = [
            new ScheduleWeek() {
                Id = 0,
                EvenWeek = false,
                DaysInWeek = [
					new ScheduleDay {
						Date = new DateOnly(2024, 6, 10),
						ItemsInDay = []
					},
					new ScheduleDay {
                        Date = new DateOnly(2024, 6, 11),
                        ItemsInDay = [
                            new ScheduleItem() {
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
                                Students = [
                                    new Student() {
                                        Id = 0,
                                        Name = "Ваня Дырка",
                                        Group = "МКМб 22-1"
                                    },
                                    new Student() {
                                        Id = 1,
                                        Name = "Вася Пупкин",
                                        Group = "МКМб 22-1"
                                    },
                                    new Student() {
                                        Id = 2,
                                        Name = "Даздраперма Василькова",
                                        Group = "МКМб 22-1"
                                    },
                                    new Student() {
                                        Id = 3,
                                        Name = "Иосиф Сталин",
                                        Group = "МКМб 22-1"
                                    },
                                    new Student() {
                                        Id = 4,
                                        Name = "Олег Тиньков",
                                        Group = "МКМб 22-1"
                                    },
                                    new Student() {
                                        Id = 5,
                                        Name = "Т-Банк Сбербанкович",
                                        Group = "МКМб 22-1"
                                    }
                                ]
                            },
                            new ScheduleItem() {
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
                                Students = [
                                    new Student() {
                                        Id = 0,
                                        Name = "Ваня Дырка",
                                        Group = "МКМб 22-1"
                                    },
                                    new Student() {
                                        Id = 1,
                                        Name = "Вася Пупкин",
                                        Group = "МКМб 22-1"
                                    },
                                    new Student() {
                                        Id = 2,
                                        Name = "Даздраперма Василькова",
                                        Group = "МКМб 22-1"
                                    },
                                    new Student() {
                                        Id = 3,
                                        Name = "Иосиф Сталин",
                                        Group = "МКМб 22-1"
                                    },
                                    new Student() {
                                        Id = 4,
                                        Name = "Олег Тиньков",
                                        Group = "МКМб 22-1"
                                    },
                                    new Student() {
                                        Id = 5,
                                        Name = "Т-Банк Сбербанкович",
                                        Group = "МКМб 22-1"
                                    }
                                ]
                            }
                        ]
                    },
                    new ScheduleDay {
                        Date = new DateOnly(2024, 6, 12),
                        ItemsInDay = [
                            new ScheduleItem() {
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
                                Students = [
                                    new Student() {
                                        Id = 0,
                                        Name = "Ваня Дырка",
                                        Group = "МКМб 22-1"
                                    },
                                    new Student() {
                                        Id = 1,
                                        Name = "Вася Пупкин",
                                        Group = "МКМб 22-1"
                                    },
                                    new Student() {
                                        Id = 2,
                                        Name = "Даздраперма Василькова",
                                        Group = "МКМб 22-1"
                                    },
                                    new Student() {
                                        Id = 3,
                                        Name = "Иосиф Сталин",
                                        Group = "МКМб 22-1"
                                    },
                                    new Student() {
                                        Id = 4,
                                        Name = "Олег Тиньков",
                                        Group = "МКМб 22-1"
                                    },
                                    new Student() {
                                        Id = 5,
                                        Name = "Т-Банк Сбербанкович",
                                        Group = "МКМб 22-1"
                                    }
                                ]
                            },
                            new ScheduleItem() {
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
                                Students = [
                                    new Student() {
                                        Id = 0,
                                        Name = "Ваня Дырка",
                                        Group = "МКМб 22-1"
                                    },
                                    new Student() {
                                        Id = 1,
                                        Name = "Вася Пупкин",
                                        Group = "МКМб 22-1"
                                    },
                                    new Student() {
                                        Id = 2,
                                        Name = "Даздраперма Василькова",
                                        Group = "МКМб 22-1"
                                    },
                                    new Student() {
                                        Id = 3,
                                        Name = "Иосиф Сталин",
                                        Group = "МКМб 22-1"
                                    },
                                    new Student() {
                                        Id = 4,
                                        Name = "Олег Тиньков",
                                        Group = "МКМб 22-1"
                                    },
                                    new Student() {
                                        Id = 5,
                                        Name = "Т-Банк Сбербанкович",
                                        Group = "МКМб 22-1"
                                    }
                                ]
                            }
                        ]
                    }
                ]
            }
        ];

		public async Task<List<ScheduleWeek>> GetAllWeeksAsync()
		{
			return await Task.FromResult<List<ScheduleWeek>>(weeks);
		}

		public async Task<ScheduleWeek> GetWeekAsync(int Id)
        {
            return await Task.FromResult<ScheduleWeek>(weeks.First(x => x.Id == Id));
        }
    }
}
