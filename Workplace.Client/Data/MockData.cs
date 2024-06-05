
using Workplace.Shared;

namespace Workplace.Client.Data
{
    public class MockData : IDataService
    {
        private readonly List<TaskItemDTO> tasks = [
            new TaskItemDTO() { Id = 1, Name = "Задача 1", Theme = "Тема 1", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit."},
            new TaskItemDTO() { Id = 2, Name = "Задача 2", Theme = "Тема 2", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit."},
            new TaskItemDTO() { Id = 3, Name = "Задача 3", Theme = "Тема 3", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit."},
        ];
        public async Task AddAsync(TaskItemDTO taskItem)
        {
            await Task.Run(() => tasks.Add(taskItem));
        }

        public async Task RemoveAsync(int Id)
        {
            await Task.Run(() => 
            {
                tasks.Remove(tasks.First(x => x.Id == Id));
                for (int i = Id-1; i < tasks.Count; i++)
                {
                    if (tasks[i] != null)
                        tasks[i].Id--;
                }
            });
        }

        public async Task SaveAsync(TaskItemDTO taskItem)
        {
            await Task.Run(() => 
            {
                var task = tasks.First(x => x.Id == taskItem.Id);
                tasks.Remove(task);
                tasks.Add(taskItem);
            });
        }

        public async Task<IEnumerable<TaskItemDTO>> GetDataAsync()
        {
            //await Task.Delay(1000);
            return await Task.FromResult<IEnumerable<TaskItemDTO>>(tasks);
        }

        public async Task<TaskItemDTO> GetTaskAsync(int id)
        {
            return await Task.FromResult<TaskItemDTO>(tasks.First(x => x.Id == id));
        }
    }
}
