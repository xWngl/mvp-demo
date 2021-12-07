using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D body;
    public float speed, bound1, bound2;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        if (horizontal > 0)
        {
          body.velocity = Vector2.right * speed;
        } else if (horizontal < 0)
        {
          body.velocity = Vector2.left * speed;
        } else 
        {
          body.velocity = Vector2.zero;
        }

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, bound1, bound2), transform.position.y);
    }
}
