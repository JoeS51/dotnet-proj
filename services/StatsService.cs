public class StatsService
{
    private List<GameStats> games = new List<GameStats>();

    public void addNewGame(GameStats g)
    {
        games.Add(g);
    }
}