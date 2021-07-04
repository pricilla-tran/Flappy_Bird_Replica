using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public float score;
    public Text myText;
    // Start is called before the first frame update
    /*void Start()
    {
        
    } */

    // Update is called once per frame
    void Update()
    {
        score = score + Time.deltaTime;
        myText.text = score.ToString();
    }

    public void GameOver()
    {
        PlayerPrefs.SetFloat("playerScore", score);
        // got to result scene
        SceneManager.LoadScene("loseScene");
    }

}
