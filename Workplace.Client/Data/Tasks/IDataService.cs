using Workplace.Shared.Tasks;

namespace Workplace.Client.Data.Tasks
{
    public interface IDataService
    {
        Task<IEnumerable<TaskItemDTO>> GetDataAsync();
        Task AddAsync(TaskItemDTO dto);
        Task RemoveAsync(int Id);
        Task SaveAsync(TaskItemDTO dto);
        Task<TaskItemDTO> GetTaskAsync(int id);
    }
}
