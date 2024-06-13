using Workplace.Shared;

namespace Workplace.Client.Data
{
    public interface IScheduleDataService
    {
        Task<List<ScheduleWeek>> GetAllWeeksAsync();
        Task<ScheduleWeek> GetWeekAsync(int Id);
    }
}
