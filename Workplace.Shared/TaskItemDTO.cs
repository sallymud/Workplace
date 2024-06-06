using System.ComponentModel.DataAnnotations;

namespace Workplace.Shared
{
    public class TaskItemDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Название задачи обязательно для заполнения.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Тема задачи обязательно для заполнения.")]
        public string? Theme { get; set; }
        
        [Required(ErrorMessage = "Текст задачи обязательно для заполнения.")]
        public string? Text { get; set; }

        public TaskType TType { get; set; }

        public TaskSource Source { get; set; }

        public DateTime DateOfCreation { get; set; }

        public DateTime DateOfCompletion { get; set; }

        public TaskStatus Status { get; set; }
    }

    public enum TaskType
    {  
        T_timeTable,
        T_event
    }

    public enum TaskSource
    {

    }

    public enum TaskStatus
    {
        Success,
        Failure,
        In_Process
    }
}
