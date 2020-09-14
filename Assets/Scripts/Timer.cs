using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text txtTimer;
    float time = 0;
    bool isEnabled = true;
    // Start is called before the first frame update
    void Start()
    {
        txtTimer.text = "0:00";
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnabled)
        {
            time += Time.deltaTime;
            string timeStr = TimeSpan.FromSeconds(time).ToString(@"m\:ss");
            txtTimer.text = timeStr;
        }

        if(time > 300)
        {
            isEnabled = false;
        }
    }

    public void ToggleTimer()
    {
        isEnabled = !isEnabled;
    }
}
