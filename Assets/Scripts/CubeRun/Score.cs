using TMPro;
using UnityEngine;
using UnityEngine.UI;
//Imports all the libraries we need to refer to the UI and Text

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI score;
    //A variable for the Player's position and the text on screen

    // Update is called once per frame
    void Update()
    {
        score.text = player.position.z.ToString("0");
        //Updates the text to read out the player's distance as the score
    }
}
