using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Variables list
    public int score = 0;
    public int highScore = 0;
    public bool gameOver = false;
    public bool hasGameStarted = false;
    public Rigidbody2D playerControllerRigidbody;


    //Singleton pattern
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindFirstObjectByType<GameManager>();
            }

            return _instance;
        }
    }

    //Function list
    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        playerControllerRigidbody.gravityScale = 0;
    }

    public void GameStart()
    {
        hasGameStarted = true;
        playerControllerRigidbody.gravityScale = 1;
    }

    public void GameOver()
    {
        gameOver = true;
        AudioManager.Instance.PlayGameOverSound();
        UIManager.Instance.HandleGameOverUI();
    }

    public void SaveGame()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
    }

    public void Score()
    {
        score++;
        UIManager.Instance.UpdateUserScore(score);

        if (highScore < score)
        {
            highScore = score;
            SaveGame();
        }

        AudioManager.Instance.PlayScoreSound();
    }
}
