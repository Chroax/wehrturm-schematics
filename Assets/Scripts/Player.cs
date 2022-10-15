using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    public string teamName { get; set; }
    public int coin { get; set; }
    public int currentLife;
    public int maxLife { get; set; }
    public int levelSoal { get; set; }
    public int levelMissile { get; set; }
    public int levelTowerHP { get; set; }
    public int levelTowerDefense { get; set; }
    public CharacterDetailSO characterSlot1 { get; set; }
    public CharacterDetailSO characterSlot2 { get; set; }
    public CharacterDetailSO characterSlot3 { get; set; }
    public int stage { get; set; }
    public int maxHealth { get; set; }
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;
        else
        {
            if (instance != this)
                Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
        this.coin = 9999;
        this.currentLife = 3;
        this.maxLife = currentLife;
        this.levelSoal = 1;
        this.levelMissile = 1;
        this.levelTowerHP = 1;
        this.levelTowerDefense = 1;
        this.stage = 1;
        this.maxHealth = 100;
        this.currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
