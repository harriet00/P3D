﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{

    Light myLight;
    public float minWaitTime;
    public float maxWaitTime;
    
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
        StartCoroutine(Flashing());
        
    }

    IEnumerator Flashing ()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
            myLight.enabled = !myLight.enabled;

        }
    }
}
