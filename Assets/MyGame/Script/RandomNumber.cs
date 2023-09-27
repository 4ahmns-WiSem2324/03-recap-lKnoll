using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class RandomNumber : MonoBehaviour
{
    int randomNumber;
    int currentScore;
    int input;
    float timer;
    float reaktionszeit = 1.5f;
    int zeitVerkuerzenScore = 10;
    [SerializeField] TextMeshProUGUI randomNumberText;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI highScoreText;


    void Start()
    {
        randomNumber = Random.Range(1, 7);
        randomNumberText.text = randomNumber.ToString();
        highScoreText.text = $"HighScore:  { PlayerPrefs.GetInt("HighScore", 0)}";
    }

    void Update()
    {
        scoreText.text = currentScore.ToString();
        timer += Time.deltaTime;
        if (timer >= reaktionszeit)
        {
            timer = 0;
            SceneManager.LoadScene(1);
        }
        if (input == randomNumber)
        {
            ButtonStimmen();
        }
        if (currentScore == zeitVerkuerzenScore)
        {
            reaktionszeit = reaktionszeit- 0.1f;
            zeitVerkuerzenScore = zeitVerkuerzenScore + 10;
        }
    }

    public void ButtonStimmen()
    {
        currentScore++;
        timer = 0;
        randomNumber = Random.Range(1, 6);
        randomNumberText.text = randomNumber.ToString();
        PlayerPrefs.GetInt("HighScore");
        CheckHighScore();
    }

    void CheckHighScore()
    {
        if (currentScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", currentScore);
            highScoreText.text = $"HighScore:  { PlayerPrefs.GetInt("HighScore", 0)}";
        }
    }

    public void Button1Gedrueckt()
    {
        input = 1;
        if (input != randomNumber)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void Button2Gedrueckt()
    {
        input = 2;
        if (input != randomNumber)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void Button3Gedrueckt()
    {
        input = 3;
        if (input != randomNumber)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void Button4Gedrueckt()
    {
        input = 4;
        if (input != randomNumber)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void Button5Gedrueckt()
    {
        input = 5;
        if (input != randomNumber)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void Button6Gedrueckt()
    {
        input = 6;
        if (input != randomNumber)
        {
            SceneManager.LoadScene(1);
        }
    }
}
