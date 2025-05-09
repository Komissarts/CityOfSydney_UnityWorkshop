using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
//We Are asking Unity to give us access to all the
//UI related functions and methods for us to call
//and interact with our UI Elements
using UnityEngine.UI;

public class PBGameManager : MonoBehaviour
{
// A simple round number Integer for us to print to the Score Text
    public int playerScore;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverScreen;

//All the below functions are public because we
//want to run them from other in-game scripts
//The AddScore() Function requires a number input
//whenever its called, specifically it requires an
//integer, which is added to the score
    public void addScore(int scoreToAdd)
    {
// We have to convert the number into a computer-readable
// string to be printed to the text box
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }
//This function checks for what the current active scene is,
//and then loads it again, effectively restarting it.
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
//This just activates our Game Over Screen
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

}
