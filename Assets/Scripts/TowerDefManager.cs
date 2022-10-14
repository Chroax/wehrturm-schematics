using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TowerDefManager : MonoBehaviour
{
    public List<TowerDefenseSO> towerDefs;
    public TowerDefenseSO towerDefense;
    public TextMeshProUGUI price;
    public TextMeshProUGUI level;

    // Start is called before the first frame update
    void Start()
    {
        GetTowerDefSO();
        price.text = towerDefense.price.ToString();
        level.text = "Level " + towerDefense.level + "/5";
    }


    // Update is called once per frame
    public void Update()
    {
        GetTowerDefSO();
        if (towerDefense != null)
        {
            price.text = towerDefense.price.ToString();
            level.text = "Level " + towerDefense.level + "/5";
        }
    }

    public void GetTowerDefSO()
    {
        foreach(TowerDefenseSO towerDef in towerDefs)
        {
            if (towerDef.level == Player.instance.levelTowerDefense)
            {
                towerDefense = towerDef;
            }
        }
    }

    public void Purchase()
    {
        if (Player.instance.coin >= towerDefense.price && Player.instance.levelTowerDefense <= 5)
        {
            Player.instance.levelTowerDefense += 1;

            if (Player.instance.levelTowerDefense > 5)
                Player.instance.levelTowerDefense = 5;
            else
            {
                Player.instance.coin -= towerDefense.price;
                Player.instance.maxDefense = towerDefense.defense;
                Player.instance.currentDefense = towerDefense.defense;
            }
        }
    }
}
