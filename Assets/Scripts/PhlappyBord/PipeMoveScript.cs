using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    //The Move Speed is just how fast we want the pipes moving towards the player,
    //with the remove zone being set out of frame so once the obstacles have passed
    //a certain distance,they can be deleted and save on memory space
    public float moveSpeed = 5;
    public float removeZone = -45;

    void FixedUpdate()
    {
        //This moves the obstacles across the screen,
        //adding the set movespeed to the obstacles current position every frame
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
        
        //It also constantly checks that once it goes
        //past the set position, it is then deleted
        if (transform.position.x < removeZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
