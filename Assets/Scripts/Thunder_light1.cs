using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunder_light : MonoBehaviour
{
    public bool isFlickering = false;
    public float timeDelay;

    enum poryroku
    {
        WIOSNA,
        ZIMA
    }

    private void Start()
    {
        if(naszapora == poryroku.ZIMA)
        {

        }
        Debug.Log("Thunder start "+System.DateTime.Now);
        InvokeRepeating("funkcja", 0, 1);
    }

    poryroku naszapora = poryroku.WIOSNA;
    void Update()
    {
        // InvokeRepeating
        if (isFlickering == false)
        {
            StartCoroutine(FlickeringLights());
        }
    }

    IEnumerator FlickeringLights()
    {
        isFlickering = true;
        this.gameObject.GetComponent<Light>().enabled = false;
        timeDelay = Random.Range(0.10f, 0.5f);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        timeDelay = Random.Range(0.01f, 0.2f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;

    }

    int zmienna = 0;
    void funkcja()
    {
        Debug.Log("wywolanie " + zmienna);
        zmienna++;
    }
}
