using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSystem : MonoBehaviour
{
    public static PauseSystem instance;
    public bool gameIsPaused;
    public bool spawningCharacter;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PauseGame()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        gameIsPaused = true;
        //AudioSource.ignoreListenerPause=true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        gameIsPaused = false;
    }
}
