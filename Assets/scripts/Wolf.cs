﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : MonoBehaviour
{

    private float timerCounter = 0;
    private bool wolfInScene;

    // Start is called before the first frame update
    void Start()
    {
        wolfInScene = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(wolfInScene)
        { 
            timerCounter += Time.deltaTime * 0.5f;

            float x = 50 + Mathf.Cos(timerCounter) * 35;
            float y = 0;
            float z = 37 + Mathf.Sin(timerCounter) * 20;

            Vector3 nextPoint = new Vector3(x, y, z);

            transform.LookAt(nextPoint);

            transform.position = Vector3.Lerp(transform.position, nextPoint, Time.deltaTime);

        } else
        {
            timerCounter += Time.deltaTime * 0.3f;
            if (timerCounter > 1.0f) wolfInScene = true;
        }
    }
}
