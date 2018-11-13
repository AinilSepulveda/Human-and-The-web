using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotenemy_script : Enemy_script {

    public GameObject target;
    public float rotationSpeed;

    // Use this for initialization
    void Start () {
        target = GameObject.FindGameObjectWithTag("Player");
        mytransform.GetComponent<Transform>();
        Direccion();
        Destroy(gameObject, 5f);
    }
	
	// Update is called once per frame
	void Update () {
        mytransform.Translate(Vector2.right * speed);

    }

    void Direccion()
    {
        
        Vector3 vectorToTarget = target.transform.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion qt = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, qt,  rotationSpeed);
    }
}
