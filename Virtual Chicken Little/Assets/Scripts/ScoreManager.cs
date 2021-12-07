using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int scoreNum;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreNum.ToString();
    }

    public void scoreNumDecrease(GameObject chicken) {
        scoreNum--;
    }

    void OnTriggerEnter2D(Collider2D target) {
        if(target.tag != "Heading Tag") {
            Destroy(target.gameObject);
            scoreNum--;
        }
    }

    void OnTriggerExit2D(Collider2D target) {
        if(target.tag == "Heading Tag") {
            Destroy(target.gameObject);
            scoreNum++; 
        }
    }
}
