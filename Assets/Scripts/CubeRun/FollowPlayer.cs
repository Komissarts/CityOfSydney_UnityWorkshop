using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    //Connect the Player's location data into this script
    public Vector3 offset;
    //Add a custom location offset

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
        //Every frame, snap the camera's position
        //to the players position, but add a custom offset
    }
}
