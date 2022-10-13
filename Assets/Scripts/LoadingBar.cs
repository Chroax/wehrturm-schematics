using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour
{
    [SerializeField] Image bar;
    [SerializeField] Slider timerBar;
    [SerializeField] float time;

    private bool stopTimer;

    public void Start()
    {
        stopTimer = false;
        timerBar.maxValue = time;
        timerBar.value = time;
        bar.color = new Color(0.06484962f, 1f, 0f, 1f);
    }

    public void Update()
    {
        float currentTime = time - Time.time;

        if(currentTime <= 0)
            stopTimer = true;

        if(stopTimer == false)
            timerBar.value = currentTime;
        
        if (timerBar.value < (0.34 * time) && timerBar.value > (0.167 * time))
            bar.color = new Color(1f, 1f, 0f, 1f);
        else if (timerBar.value < (0.167 * time))
            bar.color = new Color(1f, 0.1456224f, 0f, 1f);
    }
}
