using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyPiece : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target) {
        if(target.tag == "Heading Tag") {
            Destroy(target.gameObject);
            //chicken.scoreNumDecrease();
        } else if(target.tag == "Paragraph Tag" ||
                target.tag == "Bold Tag" ||
                target.tag == "Italics Tag") {
            Destroy(target.gameObject);
            }
    }
}
