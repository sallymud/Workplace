using Workplace.Shared;

namespace Workplace.Client.Data
{
    public interface IDataService
    {
        Task<IEnumerable<TaskItemDTO>> GetDataAsync();
        Task AddAsync(TaskItemDTO dto);
        Task RemoveAsync(TaskItemDTO dto);
        Task EditAsync(TaskItemDTO dto);
    }
}
