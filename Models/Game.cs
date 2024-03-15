namespace WebApplication1.Models
{
    public class Game
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string? Timetable { get; set; }
        public string? Local {  get; set; }
        public int Slots { get; set; }
        public string? Level { get; set; }
        public string? Category { get; set; }
        public List<string>? Players { get; set; }

    }
}
