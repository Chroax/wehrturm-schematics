using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TowerHPManager : MonoBehaviour
{
    public List<TowerHPSO> towerHP;
    public TowerHPSO selectedTowerHPSO;
    public Image towerHPImage;
    public TextMeshProUGUI price;
    public TextMeshProUGUI level;

    // Start is called before the first frame update
    void Start()
    {
        GetTowerHPSO();
        price.text = selectedTowerHPSO.price.ToString();
        level.text = "Level " + selectedTowerHPSO.level + "/5";
        towerHPImage.sprite = selectedTowerHPSO.towerImage;
    }


    // Update is called once per frame
    public void Update()
    {
        GetTowerHPSO();
        if(selectedTowerHPSO != null)
        {
            price.text = selectedTowerHPSO.price.ToString();
            level.text = "Level " + selectedTowerHPSO.level + "/5";
            towerHPImage.sprite = selectedTowerHPSO.towerImage;
        }
    }

    public void GetTowerHPSO()
    {
        foreach(TowerHPSO towerHP in towerHP)
        {
            if (towerHP.level == Player.instance.levelTowerHP)
            {
                selectedTowerHPSO = towerHP;
            }
        }
    }

    public void Purchase()
    {
        if (Player.instance.coin >= selectedTowerHPSO.price && Player.instance.levelTowerHP <= 5)
        {
            Player.instance.levelTowerHP += 1;
            if (Player.instance.levelTowerHP > 5)
                Player.instance.levelTowerHP = 5;
            else
            { 
                Player.instance.coin -= selectedTowerHPSO.price;
                Player.instance.maxHealth = selectedTowerHPSO.health;
                Player.instance.currentHealth = selectedTowerHPSO.health;
            }
        }
    }
}
