using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D myRigid;
    public float flapStrength;
    public GameControl myGame;
    // Start is called before the first frame update
    /*void Start()
    {
        
    } */

    // Update is called once per frame
    void Update()
    {
        // If space bar is pressed 
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Set the velocity of rigidbody 
            // Vector2 uses x, y 
            // Vector2.up = (0,1)
            myRigid.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        myGame.GameOver();
    }

}
