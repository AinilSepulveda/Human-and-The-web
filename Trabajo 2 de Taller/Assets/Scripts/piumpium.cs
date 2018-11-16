using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piumpium : Enemy_script {

    float starTime;
    float outTime = 2f;
    private Transform playerpos;

    public GameObject shotenemy;
    public GameObject canonpium;

    // Use this for initialization
    void Start () {
        mytransform.GetComponent<Transform>();
        InvokeRepeating("Disparo", starTime, outTime);


    }
	
	// Update is called once per frame
	void Update () {
        mytransform.Translate(-Vector2.up * speed);
        if (Hpenemy <= 0)
        {
            Destroy(gameObject);
        }

    }
    void Disparo()
    {
        playerpos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        Instantiate(shotenemy, canonpium.transform.position, playerpos.rotation);
        
        
        Debug.Log("Encontradoo");
    }
}
