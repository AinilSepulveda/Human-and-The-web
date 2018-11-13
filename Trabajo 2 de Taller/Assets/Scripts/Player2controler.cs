using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2controler : MonoBehaviour
{

    float speed = 5f;
    private Rigidbody2D rb2d;
    bool ground;
    float salto = 6.5f;
    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        rb2d.AddForce(Vector2.right * h * speed);

        if ( Input.GetKeyDown(KeyCode.Space) && ground == true)
        {
            rb2d.velocity = Vector2.zero;
            rb2d.velocity = (new Vector2(0, salto));
        }
    
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Ground"))
        {
            ground = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Ground"))
        {
            ground = false;
        }
    }
}
