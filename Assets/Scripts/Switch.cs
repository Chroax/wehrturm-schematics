using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject onSwitch;
    public GameObject offSwitch;

    public void OnAndOffSwitch()
    {
        if(onSwitch.activeInHierarchy)
        {
            onSwitch.SetActive(false);
            offSwitch.SetActive(true);
        }
        else if (offSwitch.activeInHierarchy)
        {
            offSwitch.SetActive(false);
            onSwitch.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
