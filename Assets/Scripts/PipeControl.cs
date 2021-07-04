using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeControl : MonoBehaviour
{
    public float speed;
    public float destroyPos = -12;
    // Start is called before the first frame update
    /*void Start()
    {
        
    } */

    // Update is called once per frame
    void Update()
    {
        // transform.position is what we use to refer to the pos of the object
        // Vector3 has an x, y and z
        // Vector3 left = (-1, 0, 0)
        // Delta Time is the time in seconds since the last frame. Since there are many frames per sec, you can 
        // think of this as a percentage of a second that one frame takes up 
        transform.position = transform.position + Vector3.left * speed * Time.deltaTime; 
        if (transform.position.x < destroyPos)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
