using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmergencyLights : MonoBehaviour
{
    public bool isFlickering = false;
    public float timeDelay;
    void Update()
    {
        if (isFlickering == false)
        {
            StartCoroutine(FlickeringLights());
        }
    }

    IEnumerator FlickeringLights()
    {
        isFlickering = true;
        this.gameObject.GetComponent<Light>().enabled = false;
        timeDelay = Random.Range(0.01f, 0.2f);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        timeDelay = Random.Range(0.01f, 0.2f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;

    }
}
