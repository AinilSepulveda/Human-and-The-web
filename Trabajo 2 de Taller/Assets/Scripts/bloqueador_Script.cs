using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloqueador_Script : Enemy_script {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Hpenemy <= 0)
        {
            Destroy(gameObject);
        }
    }
}
