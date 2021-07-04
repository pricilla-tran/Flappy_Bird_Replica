using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnTime;
    public float startingX;
    public float minY;
    public float maxY;
    // Start is called before the first frame update
    void Start()
    {
        // Call SpawnPipe() function 
        SpawnPipe();
    }

    // Update is called once per frame
    /*void Update()
    {
        
    } */ 

    void SpawnPipe()
    {
        // Instantiate creates a new object 
        // Quaternion.identity means no rotation 
        // Pos of object to be made new Vector3(.....)
        // Invoke() is a special function that tells Unity to call given function again after a certain amount of time 
        // Call SpawnPipe() again after spawnTime (in seconds)
        // so the function will loop and create a new pipe every spawnTime seconds
        GameObject.Instantiate(
            pipe, new Vector3(startingX, Random.Range(minY, maxY), 0), Quaternion.identity);
        Invoke("SpawnPipe", spawnTime);
    }
}
