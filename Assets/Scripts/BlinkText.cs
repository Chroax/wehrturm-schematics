using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlinkText : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float blinkStay = 2f;
    public float fadeInTime = 0.5f;
    public float fadeOutTime = 0.5f;
    public float timeChecker = 0;
    private Color originColor;
    // Start is called before the first frame update
    void Start()
    {
        originColor = text.color;
    }

    // Update is called once per frame
    void Update()
    {
        timeChecker += Time.deltaTime;
        if(timeChecker < fadeInTime)
        {
            text.color = new Color(originColor.r, originColor.g, originColor.b, timeChecker / fadeInTime);
        }
        else if (timeChecker < fadeInTime + blinkStay)
        {
            text.color = new Color(originColor.r, originColor.g, originColor.b, 1);
        }
        else if (timeChecker < fadeInTime + blinkStay + fadeOutTime)
        {
            text.color = new Color(originColor.r, originColor.g, originColor.b, 1 - (timeChecker - (fadeInTime + blinkStay)) / fadeOutTime);
        }
        else
        {
            timeChecker = 0f;
        }
    }
}
