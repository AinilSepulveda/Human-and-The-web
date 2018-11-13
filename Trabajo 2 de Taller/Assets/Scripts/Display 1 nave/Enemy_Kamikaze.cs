using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Kamikaze : Enemy_script {
   
    
	// Use this for initialization
	void Start () {
        mytransform.GetComponent<Transform>();
       

	}
	
	// Update is called once per frame
	void Update () {
        mytransform.Translate(-Vector2.up * speed);

        if (Hpenemy <= 0)
        {
            Destroy(gameObject);
        }
    }

}
