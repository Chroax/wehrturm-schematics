using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public PauseSystem pauseSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        pauseSystem.PauseGame();
        Player.instance.stage += 1;
    }

    private void OnDisable()
    {
        Player.instance.currentHealth = Player.instance.maxHealth;
        pauseSystem.ResumeGame();
    }
}
