using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceCollector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
      Destroy(target.gameObject);
    }
}
