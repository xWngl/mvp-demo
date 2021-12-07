using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScriptTutorial : MonoBehaviour
{
    public Text scoreText, winText, lossText;
    public int upperLimit, lowerLimit;
    private int score;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + score.ToString();

        if (score == upperLimit)
        {
          winText.text = "Congratulations! You've won!";
          SceneManager.LoadScene("Map");
        } else if (score == lowerLimit)
        {
          lossText.text = "You've lost! :(";
          SceneManager.LoadScene("Map");
        }
    }

    void OnTriggerEnter2D(Collider2D target)
    {
      Destroy(target.gameObject);
      if(target.tag == "header" || target.tag == "paragraph" || target.tag == "italic" || target.tag == "bold")
      {
        score++;
      } else
      {
        score--;
      }
    }
}
