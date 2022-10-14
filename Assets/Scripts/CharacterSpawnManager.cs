using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterSpawnManager : MonoBehaviour
{
    public GameObject characterSpawn1;
    public GameObject characterSpawn2;
    public GameObject characterSpawn3;
    public GameObject characterSpawn4;
    public GameObject characterSpawn5;
    // Start is called before the first frame update
    void Start()
    {
        if (Player.instance.characterSlot1 != null)
        {
            characterSpawn1.GetComponent<CharacterSpawn>().characterDetail = Player.instance.characterSlot1;
            characterSpawn1.gameObject.name = Player.instance.characterSlot1.name;
            characterSpawn1.GetComponent<CharacterSpawn>().characterSprite.sprite = Player.instance.characterSlot1.characterSprite;
            characterSpawn1.GetComponent<CharacterSpawn>().characterSprite.color = new Color(1f, 1f, 1f, 1f);
            characterSpawn1.GetComponent<CharacterSpawn>().loadBar.SetActive(true);
            characterSpawn1.GetComponent<CharacterSpawn>().coin.SetActive(true);
            characterSpawn1.GetComponent<CharacterSpawn>().coin.transform.Find("Text (TMP)").GetComponent<TextMeshProUGUI>().text = Player.instance.characterSlot1.price.ToString();
            characterSpawn1.GetComponent<CharacterSpawn>().LoadBar();
        }
        if (Player.instance.characterSlot2 != null)
        {
            characterSpawn2.GetComponent<CharacterSpawn>().characterDetail = Player.instance.characterSlot2;
            characterSpawn2.gameObject.name = Player.instance.characterSlot2.name;
            characterSpawn2.GetComponent<CharacterSpawn>().characterSprite.sprite = Player.instance.characterSlot2.characterSprite;
            characterSpawn2.GetComponent<CharacterSpawn>().characterSprite.color = new Color(1f, 1f, 1f, 1f);
            characterSpawn2.GetComponent<CharacterSpawn>().loadBar.SetActive(true);
            characterSpawn2.GetComponent<CharacterSpawn>().coin.SetActive(true);
            characterSpawn2.GetComponent<CharacterSpawn>().coin.transform.Find("Text (TMP)").GetComponent<TextMeshProUGUI>().text = Player.instance.characterSlot2.price.ToString();
            characterSpawn2.GetComponent<CharacterSpawn>().LoadBar();
        }
        if (Player.instance.characterSlot3 != null)
        {
            characterSpawn3.GetComponent<CharacterSpawn>().characterDetail = Player.instance.characterSlot3;
            characterSpawn3.gameObject.name = Player.instance.characterSlot3.name;
            characterSpawn3.GetComponent<CharacterSpawn>().characterSprite.sprite = Player.instance.characterSlot3.characterSprite;
            characterSpawn3.GetComponent<CharacterSpawn>().characterSprite.color = new Color(1f, 1f, 1f, 1f);
            characterSpawn3.GetComponent<CharacterSpawn>().loadBar.SetActive(true);
            characterSpawn3.GetComponent<CharacterSpawn>().coin.SetActive(true);
            characterSpawn3.GetComponent<CharacterSpawn>().coin.transform.Find("Text (TMP)").GetComponent<TextMeshProUGUI>().text = Player.instance.characterSlot3.price.ToString();
            characterSpawn3.GetComponent<CharacterSpawn>().LoadBar();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
