using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
private Rigidbody2D rb2d;
private float speed = .15f;
private float boundX = 8f;
    // Start is called before the first frame update
    void Start()
    {
rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey(KeyCode.D))//move right
        {
            transform.Translate(Vector2.right * speed);
        }
    if (Input.GetKey(KeyCode.A))//move left
        {
            transform.Translate(Vector2.left * speed);
        }
     var pos = transform.position;
        if(pos.x > boundX)
        {
            pos.x = boundX;
        }
        else if(pos.x < -boundX)
        {
            pos.x = -boundX;
        }

        transform.position = pos;
    }
}
