using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class you_win : MonoBehaviour {
    float timerwin;
    float timeroutwin = 5f;

    // Use this for initialization
    private void Update()
    {
        if (gameObject.activeInHierarchy)
        {
            timerwin += Time.deltaTime;
            if(timerwin >= timeroutwin)
            {
                SceneManager.LoadScene(2);
            }

        }
    }
}
