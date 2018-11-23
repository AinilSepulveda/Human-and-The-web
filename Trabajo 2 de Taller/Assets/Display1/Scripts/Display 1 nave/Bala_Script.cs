using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala_Script : MonoBehaviour {
    float timerStart;
    float timerOut = 3;
    Transform myTransform;
   public int hitbala = 1;
	// Use this for initialization
	void Start () {
        myTransform = GetComponent<Transform>();
        

    }
	
	// Update is called once per frame
	void Update () {
       MovimientodeBala(0.2f);
        
        timerStart += Time.deltaTime;
        if (timerStart > timerOut)
        {
             Destroy(gameObject);
            
        }


    }
    public void MovimientodeBala(float speed) {
        
        myTransform.Translate(Vector2.up * speed);

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Enemy_script enemy;
            enemy = collision.gameObject.GetComponent<Enemy_script>();
            enemy.Hpenemy -= hitbala; 
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "BossEnemy")
        {
            Enemy_script enemy;
            enemy = collision.gameObject.GetComponent<Enemy_script>();
            enemy.Hpenemy -= hitbala;
            Destroy(gameObject);
        }
    }

}
