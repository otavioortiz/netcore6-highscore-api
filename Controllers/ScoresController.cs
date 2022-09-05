using HighscoreApi.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HighscoreApi.Models
{
    [ApiController]
    [Route("[controller]")]
    public class ScoresController:ControllerBase
    {
        public readonly SqliteDataContext dbContext;
        public ScoresController(SqliteDataContext dbContext){
            this.dbContext = dbContext;
        }

        [HttpGet("/scores")]
        public ActionResult<List<ScoreItem>> GetScores()
        {
            List<ScoreItem> scores = this.dbContext.Scores!.OrderByDescending(i => i.Score).Take(10).ToList();
            return scores;
        }

        [HttpPost("/score")]
        public async Task<ActionResult<ScoreItem>> AddScore(ScoreItem scoreItem)
        {
            this.dbContext.Add(scoreItem);
            await this.dbContext.SaveChangesAsync();

            return Ok(scoreItem);
        }
    }
}
