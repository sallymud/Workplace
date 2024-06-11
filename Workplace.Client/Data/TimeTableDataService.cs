using Workplace.Shared;

namespace Workplace.Client.Data
{
    public interface TimeTableDataService
    {
        Task<List<TimeTableWeek>> GetDataAsync();
        Task<TimeTableWeek> GetWeekAsync(int Id);
    }
}
