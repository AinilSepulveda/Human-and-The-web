using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1Controler : MonoBehaviour {
    Rigidbody2D rb2d;
    Transform myTransform;
    Animator anim;
  public float speed;
   public int vida = 100;

    public GameObject bala;
    public GameObject canon;

   public float posXmax;
   public float posXmin;
    float posYmin;
    float posYmax;



   public bool shooton;


    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        myTransform = GetComponent<Transform>();
        anim = GetComponent<Animator>();
        posYmin = -4.34f;
        posYmax = 18f;

    }
	
	// Update is called once per frame
	void Update () {
        MovimientodeNave();

        // timer de disparo

        // Disparoo
        if (Input.GetKeyDown(KeyCode.Joystick1Button5) || Input.GetKeyDown(KeyCode.Space))
        {

                Instantiate(bala, canon.transform.position, transform.rotation);

            

         //   Destroy(bala, 3f);


        }
    if (vida <= 0){

            Destroy(gameObject);
        }






    }

    void MovimientodeNave()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 movemet = new Vector2(h, v);


        rb2d.velocity = movemet * speed;



        anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.y));
       rb2d.position = new Vector2((Mathf.Clamp(rb2d.position.x, posXmin, posXmax)), (Mathf.Clamp(rb2d.position.y, posYmin, posYmax)));

      //  transform.Rotate(rotation);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Enemy_script enemy;
            enemy = collision.gameObject.GetComponent<Enemy_script>();
            vida -= enemy.hit;
            Debug.Log(vida);
        }
        if (collision.gameObject.tag == "EnemyShoot")
        {
            Enemy_script enemy;
            enemy = collision.gameObject.GetComponent<Enemy_script>();
            vida -= enemy.hit;
            Debug.Log(vida);
            Destroy(collision.gameObject);
        }
    }

}
