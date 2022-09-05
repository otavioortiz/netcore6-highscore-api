using System.ComponentModel.DataAnnotations.Schema;


namespace HighscoreApi.Models
{
    [Table("Scores")]
    public class ScoreItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public int Score { get; set; }
    }
}

