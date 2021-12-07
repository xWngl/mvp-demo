using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript_Farm : MonoBehaviour
{
    public Text scoreText, livesText, winText, lossText;
    public int upperLimit;
    private int score, lives;

    void Start()
    {
      lives = 5;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + score.ToString();
        livesText.text = "Lives:" + lives.ToString();
 
        if (score == upperLimit)
        {
          winText.text = "Congratulations! You've won!";
          SceneManager.LoadScene("Map");
        } else if (lives == 0)
        {
          lossText.text = "You've lost! :(";
          SceneManager.LoadScene("Map");
        }
    }

    void OnTriggerEnter2D(Collider2D target)
    {
      Destroy(target.gameObject);
      if(target.tag == "header")
      {
        score++;
      } else if(target.tag == "bug")
      {
        lives--;
      }
      else
      {
        score--;
      }
    }
}