using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text myText;
    // Start is called before the first frame update
    void Start()
    {
        myText.text = PlayerPrefs.GetFloat("playerScore").ToString();
    }

    // Update is called once per frame
    /*void Update()
    {
        
    } */
}
