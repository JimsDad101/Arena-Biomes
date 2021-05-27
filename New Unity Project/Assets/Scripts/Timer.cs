using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject timeUntil;
    float timeHandler = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Clock();
    }
    
    void Clock()
    {
        timeHandler += Time.deltaTime;
        int seconds = Convert.ToInt32(timeHandler % 10);

        Text info = timeUntil.GetComponent<Text>();

        if (timeHandler > 0)
        {
            info.text = "Time Taken: " + seconds + " seconds";
        }
        else
        {

        }
    }
}
