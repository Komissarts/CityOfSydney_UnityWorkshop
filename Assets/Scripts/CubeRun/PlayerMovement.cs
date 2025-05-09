using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    //Reference to the Player's Rigidbody
    public Rigidbody rb;
    //The Player's Movement Force
    public float forwardForce = 3000f; 
    public float sidewaysForce = 100f;
    public float jumpForce = 50f;

    //Yes/No Check if the player is touching the ground
    public bool touchingGround = false;

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 
        // Constantly adds force forwards
        if (Input.GetKey("d")) 
        // Adds sideways force to the right only IF the "d" key is pressed.
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //the ForceMode allows you to change HOW the force is applied
            //to the object. VelocityChange allows you to immediately
            //change the velocity of the player
        }

        if (Input.GetKey("a")) 
        // Adds sideways force to the left only IF the "a" key is pressed.
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (touchingGround && Input.GetKey("space")) 
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        //DO THIS SECTION AFTER FINISHING OFF THE GAME MANAGER
        if ( rb.position.y < -1f)
        // this is to check if the player has fallen off the edge,
        // and then call the game manager to restart the level
        {
            Object.FindFirstObjectByType<GameManager>().EndGame();
        }
    }

    //Collision Check Block
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
            this.enabled = false;
            //When colliding with an Obstacle, it calls the game manager to restart the level
            Object.FindFirstObjectByType<GameManager>().EndGame();
        }

        if (collisionInfo.collider.CompareTag("Ground"))
        {
            touchingGround = true;
            Debug.Log("I AM Touching the Ground");
        }
    }
    //Triggers whenever the player leaves collision with the ground
    private void OnCollisionExit(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Ground"))
        {
            touchingGround = false;
            Debug.Log("I AM NOT Touching the Ground");
        }
    }
}
