using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyPiece : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target) {
        if(target.tag == "header") {
            Destroy(target.gameObject);
            //chicken.scoreNumDecrease();
        } else if(target.tag == "paragraph" ||
                target.tag == "bold" ||
                target.tag == "italic") {
            Destroy(target.gameObject);
            }
    }
}
