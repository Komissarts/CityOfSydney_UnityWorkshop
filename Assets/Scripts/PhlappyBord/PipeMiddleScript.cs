using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class PipeMiddleScript : MonoBehaviour
{
    //Creates a variable of datatype PBGameManager, the script we made earlier.
    public PBGameManager gameManager;
    public int ScoreValue = 1;

    void Start()
    {
//This starts off by setting the GameManager variable to the first found gameobject with the
//"Manager Tag", making sure to only get the actual PBGameManager component
        gameManager = GameObject.FindGameObjectWithTag("Manager").GetComponent<PBGameManager>();
    }

//Whenever the Player (or in this case anything) collides with the trigger, it will send a
//request to the GameManager to increase the score on the score counter
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.addScore(ScoreValue);
    }
}
