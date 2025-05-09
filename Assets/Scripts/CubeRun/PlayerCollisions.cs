using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public PlayerMovement movement;
    //Import a reference to the player's movement script
    public bool touchingGround = false;

    private void OnCollisionEnter(Collision collisionInfo)
        //This Function triggers whenever the Player's box collider is
        //activated. It also outputs information on the Collision that just happened.
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        //This chain allows us to delve deeper into the
        //collider and see if it has an associated tag, and
        //double checks if it is an "Obstacle". If it is, then
        //it disables the player's movement
        {
            movement.enabled = false;
            //When colliding with an Obstacle, it calls the game manager to restart the level
            Object.FindFirstObjectByType<GameManager>().EndGame();
        }


        if (collisionInfo.collider.CompareTag("Ground"))
        {
            touchingGround = true;
            Debug.Log("I AM Touching the Ground");
        }
    }
    private void OnCollisionExit(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Ground"))
        {
            touchingGround = false;
            Debug.Log("I AM Touching the Ground");
        }
    }

    public bool TouchingGround()
    {
        return touchingGround;
    }

}
