using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hastag : Enemy_script {

    

	// Use this for initialization
	void Start () {
        mytransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Hpenemy <= 0)
        {
            Destroy(gameObject);
        }
        mytransform.Translate(-Vector2.up * speed * Time.deltaTime);
    }
}
