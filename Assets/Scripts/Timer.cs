using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using static Score;

public class Timer : MonoBehaviour
{
    public static float timerCount = 0;
    Text timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreValue != 6)
        {
            timerCount += Time.deltaTime;
            int timerInt = (int)timerCount;
            timer.text = timerInt.ToString();
        }
       
    }
}
