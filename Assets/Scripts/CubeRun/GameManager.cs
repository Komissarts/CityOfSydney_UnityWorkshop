using UnityEngine;
using UnityEngine.SceneManagement;
//An import to be able to use scene management functions

public class GameManager : MonoBehaviour
{

    bool gameEnded = false;
    //Using boolean to keep track on whether
    //or not the game has ended and is due for a restart
    public float delay = 2f;
    //The delay Float is to give some time before restart

    public GameObject completeLevelUI;

    public void EndGame()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("Game Over!");
            Invoke("Restart", delay);
            //"Invoke" allows you to run a function with
            // an inbuilt delay.
        }
        
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Debug.Log("Level Won");
    }

    void Restart()
        //Restart Function reloads the currently loaded scene.
        // As the LoadScene() function requrires a string,
        //We read the name of the current scene and provide that.
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
