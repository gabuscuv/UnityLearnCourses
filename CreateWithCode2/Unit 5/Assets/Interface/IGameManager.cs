public interface IGameManager
{
    public void UpdateScore(int scoreToAdd);
    public void GameOver();

    public void StartGame(int difficulty);
}