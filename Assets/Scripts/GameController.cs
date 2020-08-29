using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    public Text scoreText;
    public Text bestText;
    public Text levelNumberText;
    private int score;
    private int best;
    private int levelNumber;
    public static GameStates currentState;

    public enum GameStates
    {
        Start, Pause, GameOver
    }

    private void Start()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        Best = PlayerPrefs.GetInt("BestScore", Best);
    }

    private int Score
    {
        get { return score; }
        set { score = value; scoreText.text = value.ToString(); }
    }

    private int Best
    {
        get { return best; }
        set { best = value; bestText.text = "BEST :" + value.ToString(); }
    }

    public void IncScore(int scoreNumber)
    {
        Score += scoreNumber;
        if (Score > Best)
        {
            Best = Score;
            PlayerPrefs.SetInt("BestScore", Best);
        }
    }

}
