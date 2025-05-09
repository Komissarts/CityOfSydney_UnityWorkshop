using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    //The GameObject pipe is where we plug in our Prefab Pipe object,
    //as that is what will be spawned. We also have the SpawnRate,
    //which we use as an interval timer to check when it's time to spawn
    //a pipe. Additionally we have the height offset which gives us
    //the range for how high or low we want our pipes to spawn
    public GameObject pipe;
    public float spawnRate = 2;
    public float heightOffset = 3;
    //This Private Float is used for the timer, regulating how often a pipe spawns
    //It is private because we dont want to accidentally mess with it while in the
    //editor, since this variable is purely used internally.
    private float timer = 0;

    void Start()
    { // We immediately spawn a pipe once the level has started
        spawnPipe();
    }

    void FixedUpdate()
    { //We use the Fixed Update method to make the timer consistent across
      //all machines, as it is not dependent on the framerate or quality of
      //machines. It continually ticks up, adding to the timer, and as soon as
      //that timer reaches the set SpawnRate, it resets and spawns a pipe
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    //This Function is what actually spawns the pipes, using the offsets to randomize where the pipes are positioned
    void spawnPipe()
    {
//These are private variables, only used and referenced within the SpawnPipe()
//function, it sets a float (for the y/ up & down axis) for the maximum top
//and bottom spawn location, based on the heightOffset set above.
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
//The Instantiate Spawn function uses the lowest and highest point and
//selects a random spot between those to spawn the pipes. all the other
//axis are inhereted from the PipeSpawner Game Object
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}