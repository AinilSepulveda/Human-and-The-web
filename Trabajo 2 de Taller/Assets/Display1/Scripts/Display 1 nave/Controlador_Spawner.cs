using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador_Spawner : MonoBehaviour {

    public GameObject enemyKamikaze;
    public GameObject hashTag;
    public GameObject piumpium;
    public GameObject target;

    public GameObject bossBufon;

    float timeStart;
   public float timeout;

   public float maxRandomX;
   public float minRandomX;

   public float maxRandomY;

    bool feo;
    float startimebool;
    float outtimerbool = 10f;

    float spwanhashtime;
    float spawnhashouttime = 4.5f;

    float spwanpiumpiumtime;
   public float spawnpiumpiumOut = 2f;


    float timerBosstar;
  public float timerBoosOut;

  public  int Bossvaaallegar;

    GameObject targetBoos;

    bool Boosvivo;

   public GameObject canvasActive;
    
    // Use this for initialization
    void Start () {
        target = GameObject.FindGameObjectWithTag("Player");

        Vector3 Bosspos = new Vector3(transform.position.x, transform.position.y, transform.position.z);     
    }
	
	// Update is called once per frame
	void Update () {

        timeStart += Time.deltaTime;
        spwanhashtime += Time.deltaTime;
        spwanpiumpiumtime += Time.deltaTime;

        

        if (feo)
        {
            startimebool += Time.deltaTime;
            if (timeStart > timeout)
            {

                Vector3 ramdonVector3 = new Vector3(Random.Range(minRandomX, maxRandomX), maxRandomY, 0f);
                Instantiate(enemyKamikaze, ramdonVector3, enemyKamikaze.transform.rotation);
                timeStart = 0;

            }
            if (startimebool >= outtimerbool)
            {
                feo = false;
                Debug.Log("apagado");
            }
            if (spwanhashtime >= spawnhashouttime)
                {
                Vector3 ramdonVector3 = new Vector3(Random.Range(minRandomX, maxRandomX), maxRandomY, 0f);
                Instantiate(hashTag, ramdonVector3, enemyKamikaze.transform.rotation);
                spwanhashtime = 0;
                Debug.Log("Hashtag aparecio");
            }
            if (spwanpiumpiumtime >= spawnpiumpiumOut)
            {
                if (target.transform.position.x >= -30f)
                {
                    Vector3 piumpos = new Vector3((minRandomX), maxRandomY, 0f);
                    Instantiate(piumpium, piumpos, piumpium.transform.rotation);
                    spwanpiumpiumtime = 0;
                    Debug.Log("Piumpium Aparecio");
                }
                else if (target.transform.position.x <= -30f)
                {
                    Vector3 piumpos = new Vector3((maxRandomX), maxRandomY, 0f);
                    Instantiate(piumpium, piumpos, piumpium.transform.rotation);
                    spwanpiumpiumtime = 0;
                    Debug.Log("Piumpium Aparecio");
                }
            }
        }

       if (Bossvaaallegar == 3)
        {
            timerBosstar += Time.deltaTime;
            if (timerBosstar >= timerBoosOut)
            {
                Jefe();
                Debug.Log("llegue perras");
            }
            
        } 

       if (Boosvivo)
        {

           if (!targetBoos)
            {
                Debug.Log("notoyvivo"+ canvasActive.activeInHierarchy);
                canvasActive.SetActive(true);

            }
        }


    }
    public void Oleada1()
    {
        Debug.Log("puseado");
        feo = true;
        startimebool = 0;
        outtimerbool = 10f;
        Bossvaaallegar++;
    }
    public void Oleada2()
    {
        feo = true;
        startimebool = 0;
        outtimerbool = 30f;
        Bossvaaallegar++;
    }
    public void Oleada3()
    {

        Bossvaaallegar++;
        Debug.Log("Very bien");
    }
    public void Jefe()
    {
        Instantiate(bossBufon, new Vector3(-32.05f, 7.5f , transform.position.z), bossBufon.transform.rotation);
        Boosvivo = true;
        targetBoos = GameObject.FindGameObjectWithTag("BossEnemy");
        Bossvaaallegar++;
    }
    void Sumoon()
    {
        Vector3 ramdonVector3 = new Vector3(Random.Range(minRandomX, maxRandomX), maxRandomY, 0f);
        Instantiate(hashTag, ramdonVector3, enemyKamikaze.transform.rotation);
    }
}
