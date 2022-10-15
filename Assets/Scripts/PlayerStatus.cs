using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStatus : MonoBehaviour
{
    public TextMeshProUGUI coin;
    public TextMeshProUGUI teamName;
    public TextMeshProUGUI stage;
    public GameObject life;
    public GameObject dead;
    public Transform currentLifePlaceholder;
    private int currentLifeCount;

    // Start is called before the first frame update
    void Start()
    {
        if (stage != null)
            stage.text = "STAGE-" + Player.instance.stage.ToString();
        if (coin != null)
            coin.text = Player.instance.coin.ToString();
        if (teamName != null)
            teamName.text = Player.instance.teamName;
        Debug.Log(Player.instance.currentLife);
        if(currentLifePlaceholder != null)
        {
            for (int i = 0; i < Player.instance.currentLife; i++)
                Instantiate(life, currentLifePlaceholder);
        }

        if(life != null)
            currentLifeCount = Player.instance.maxLife;
        Debug.Log(currentLifeCount);
    }

    // Update is called once per frame
    void Update()
    {
        if(coin != null)
            coin.text = Player.instance.coin.ToString();
        if(teamName != null)
            teamName.text = Player.instance.teamName;
        if(life != null)
        {
            if (currentLifeCount != Player.instance.currentLife)
            {
                int diff;
                if (currentLifeCount > Player.instance.currentLife)
                    diff = currentLifeCount - Player.instance.currentLife;
                else
                    diff = Player.instance.currentLife - currentLifeCount;
                foreach (Transform child in currentLifePlaceholder)
                    Destroy(child.gameObject);
                for (int i = 0; i < Player.instance.currentLife; i++)
                    Instantiate(life, currentLifePlaceholder);
                for (int i = 0; i < Player.instance.maxLife - Player.instance.currentLife; i++)
                    Instantiate(dead, currentLifePlaceholder);
                currentLifeCount = Player.instance.currentLife;
            }
        }
        if (stage != null)
            stage.text = "STAGE-" + Player.instance.stage.ToString();
    }
}
