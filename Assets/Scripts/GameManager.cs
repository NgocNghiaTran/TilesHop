using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{

    private int gameSpeed = 1;
    public float GameSpeed => ((gameSpeed - 1) * 0.2f) + 1;
    public GameState CurrentGameState => gameState;

    GameState gameState;
    Player player;
    protected override void Awake()
    {
        base.Awake();

        player = FindObjectOfType<Player>();
    }

    public void PlayerFailed()
    {
       
        gameState = GameState.Lost;
    }


    public void StartGame()
    {
        if (CurrentGameState == GameState.Menu)
        {
            gameState = GameState.Gameplay;
            player.StartMoving();
            SoundManager.Instance.PlayMusicFromBeat(player.platformHitCount);
        }
        else if (CurrentGameState == GameState.Lost)
        {
            gameState = GameState.Gameplay;
            player.StartMoving();
            SoundManager.Instance.PlayMusicFromBeat(player.platformHitCount);
        }
    }

    public void IncreaseGameSpeed()
    {
        if (gameSpeed < 5)
            gameSpeed++;
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
