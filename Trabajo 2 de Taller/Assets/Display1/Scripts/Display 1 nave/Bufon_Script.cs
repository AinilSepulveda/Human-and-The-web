using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bufon_Script : Enemy_script {

    float timerStart;
    float timerOut = 2f;

   public bool MovVertical;
    bool MovHorizontal = false;

    float timerHorStart;
    public float timerHorOut;

    // Use this for initialization
    void Start () {
        mytransform.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

        timerStart += Time.deltaTime;
        timerHorStart += Time.deltaTime;


        MovimientoVertical();
        MovimientoHorizontal();

        timerHorOut = Random.Range(2f, 5f);

        if (Hpenemy <= 0)
        {
            Destroy(gameObject);
        }

    }

    void MovimientoVertical()
    {
        if (MovVertical)
        {
            if (mytransform.position.x <= -26)
            {

                mytransform.Translate(Vector2.right * speed);
            }
            else if ((mytransform.position.x <= -27))
            {
                MovVertical = false;
            }


            if (timerStart >= timerOut)
            {
                MovVertical = false;
                timerStart = 0;
            }
        }
         if (!MovVertical)
         {
             if (mytransform.position.x >= -37)
             {

                 mytransform.Translate(-Vector2.right * speed);
             }
            else if ((mytransform.position.x >= -38))
            {
                MovVertical = true;
            }



            if (timerStart >= timerOut)
             {
                 MovVertical = true;
                 timerStart = 0; 
             }
         }
    }
    void MovimientoHorizontal()
    {
        if (MovHorizontal)
        {

            mytransform.Translate(Vector2.up * speed);

            if (timerHorStart >= timerHorOut)
            {
                MovHorizontal = false;
                timerHorStart = 0;
            }
        }
        if (!MovHorizontal)
        {
            mytransform.Translate(-Vector2.up * speed);

            if (timerHorStart >= timerHorOut)
            {
                MovHorizontal = true;
                timerHorStart = 0;
            }
        }
    }
}
