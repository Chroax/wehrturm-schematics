using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingBar : MonoBehaviour
{
    [SerializeField] private GameObject bar;
    public float time;

    private bool stopTimer;

    public void Start()
    {
        LoadBar();
    }
    public void LoadBar()
    {
        LeanTween.scaleX(bar, 0f, time);
    }
    public void Update()
    {
        
        float currentTime = time - Time.time;

        if (bar.transform.localScale.x <= 0)
        {
            SceneManager.LoadScene("Gameplay");
        }
        
        if (bar.transform.localScale.x < 0.5f && bar.transform.localScale.x > 0.3f)
            bar.GetComponent<Image>().color = new Color(1f, 1f, 0f, 1f);
        else if (bar.transform.localScale.x < 0.15f)
            bar.GetComponent<Image>().color = new Color(1f, 0.1456224f, 0f, 1f);
    }
}
