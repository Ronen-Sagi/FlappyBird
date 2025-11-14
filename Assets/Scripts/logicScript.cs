using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject gameOverScreen;
    
    [ContextMenu("Increase Score")]
    public void addScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void RestartGame()
    {
        Debug.Log("Game restarted");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void GameOver()
    {
        Debug.Log("Game Over");
        gameOverScreen.SetActive(true);
    }
}
