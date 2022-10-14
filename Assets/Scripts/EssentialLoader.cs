using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssentialLoader : MonoBehaviour
{
    [SerializeField] GameObject gameManager;
    [SerializeField] GameObject player;
    [SerializeField] List<CharacterDetailSO> characterSlot;

    // Start is called before the first frame update
    void Start()
    {
        if (Player.instance == null)
        {
            Player.instance = Instantiate(player).GetComponent<Player>();
            Player.instance.teamName = "Cahyadi";
            Player.instance.coin = 9999;
            Player.instance.currentLife = 3;
            Player.instance.maxLife = 3;
            Player.instance.levelSoal = 1;
            Player.instance.levelMissile = 1;
            Player.instance.levelTowerHP = 1;
            Player.instance.levelTowerDefense = 1;
            Player.instance.characterSlot1 = characterSlot[0];
            Player.instance.characterSlot2 = characterSlot[1];
            Player.instance.characterSlot3 = characterSlot[2];
            Player.instance.characterSlot4 = characterSlot[3];
            Player.instance.characterSlot5 = characterSlot[4];
            Player.instance.stage = 1;
            Player.instance.maxHealth = 100;
            Player.instance.currentHealth = Player.instance.maxHealth;
            Player.instance.maxDefense = 10;
            Player.instance.currentDefense = Player.instance.maxDefense;
        }
        if (GameManager.instance == null)
        {
            GameManager.instance = Instantiate(gameManager).GetComponent<GameManager>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
