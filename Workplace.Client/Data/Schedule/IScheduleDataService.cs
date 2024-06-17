using Workplace.Shared.Schedule;

namespace Workplace.Client.Data.Schedule
{
    public interface IScheduleDataService
    {
        Task<ScheduleDay> GetDayAsync(DateOnly dayDate);
        Task<List<ScheduleDay>> GetDayRangeAsync(DateOnly border1, DateOnly border2, string studentName);
    }
}
