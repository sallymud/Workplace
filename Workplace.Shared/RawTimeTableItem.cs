namespace Workplace.Shared
{
    public class RawTimeTableItem
    {
        public string? Slug { get; set; }
        public string? Name { get; set; }
        public string[] Teachers { get; set; } = new string[3];
    }
}
