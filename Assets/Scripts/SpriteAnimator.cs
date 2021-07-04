using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimator : MonoBehaviour
{
    public Sprite[] mySprites;
    public SpriteRenderer mySpriteRenderer;
    public float framesPerSecond;
    public float secondsPerFrame;
    public int currentFrame; 

    // Start is called before the first frame update
    void Start()
    {
        // find sprite renderer component
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        // invert frames per second
        secondsPerFrame = 1 / framesPerSecond;
        Invoke("NextFrame", secondsPerFrame);
    }

    void NextFrame()
    {
        // add 1 so we will not have a mySprites[4]
        currentFrame = (currentFrame + 1) % mySprites.Length;
        // sets sprite of sprite Renderer to new one that we want
        mySpriteRenderer.sprite = mySprites[currentFrame];
        // Tells it what function to call and how much time 
        Invoke("NextFrame", secondsPerFrame);
    }

    // Update is called once per frame
    /*void Update()
    {
        
    } */
}
