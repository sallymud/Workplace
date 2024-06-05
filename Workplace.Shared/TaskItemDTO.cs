using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workplace.Shared
{
    public class TaskItemDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Theme { get; set; }
        public string? Text { get; set; }
    }
}
