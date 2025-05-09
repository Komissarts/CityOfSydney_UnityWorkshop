using UnityEngine;

public class BordScript : MonoBehaviour
{
    // Creating a reference that we add, for the bord's Rigidbody2D
    // as well as a "floating point" varible for the flap strength,
    // that we can edit on the fly (pun intended)

    public Rigidbody2D bordBody;
    public float flapStrength;
    //Like usual, add a reference to the GameManager, allowing us to call it's functions
    public PBGameManager gameManager;
    //Simple Yes/No if the bord is alive
    public bool isAlive = true;

    // Update is called once per frame, We are currently
    // checking each frame if the Space Bar has been pressed
    // and if it has, we add velocity to the bord's rigidbody,
    // moving the bord up ^ by however strong out flapstrength it
    void Update()
    {//only allows the flapping if the bord is still alive
        if (Input.GetKeyDown(KeyCode.Space) == true && isAlive)
        {
            bordBody.linearVelocity = Vector2.up * flapStrength;
        }
    }

    //When Colliding, call the GameManager, telling it that it's game over
    private void OnCollisionEnter2D(Collision2D collision)
    {// upon collision, the bord is no longer alive
        gameManager.gameOver();
        isAlive = false;
    }
}
