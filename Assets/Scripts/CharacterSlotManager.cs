using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSlotManager : MonoBehaviour
{
    public GameObject characterSlot1;
    public GameObject characterSlot2;
    public GameObject characterSlot3;
    public GameObject characterSlot4;
    public GameObject characterSlot5;

    // Start is called before the first frame update
    void Start()
    {
        if (Player.instance.characterSlot1 != null)
        {
            characterSlot1.GetComponent<CharacterSlot>().characterDetailSO = Player.instance.characterSlot1;
            characterSlot1.gameObject.name = Player.instance.characterSlot1.name;
            characterSlot1.GetComponent<CharacterSlot>().characterImage.sprite = Player.instance.characterSlot1.characterSprite;
            characterSlot1.GetComponent<CharacterSlot>().characterImage.color = new Color(1f, 1f, 1f, 1f);
            if (characterSlot1.GetComponent<CharacterSlot>().description != null)
                characterSlot1.GetComponent<CharacterSlot>().description.SetActive(false);
        }
        if (Player.instance.characterSlot2 != null)
        {
            characterSlot2.GetComponent<CharacterSlot>().characterDetailSO = Player.instance.characterSlot2;
            characterSlot2.gameObject.name = Player.instance.characterSlot2.name;
            characterSlot2.GetComponent<CharacterSlot>().characterImage.sprite = Player.instance.characterSlot2.characterSprite;
            characterSlot2.GetComponent<CharacterSlot>().characterImage.color = new Color(1f, 1f, 1f, 1f);
            if (characterSlot2.GetComponent<CharacterSlot>().description != null)
                characterSlot2.GetComponent<CharacterSlot>().description.SetActive(false);

        }
        if (Player.instance.characterSlot3 != null)
        {
            characterSlot3.GetComponent<CharacterSlot>().characterDetailSO = Player.instance.characterSlot3;
            characterSlot3.gameObject.name = Player.instance.characterSlot3.name;
            characterSlot3.GetComponent<CharacterSlot>().characterImage.sprite = Player.instance.characterSlot3.characterSprite;
            characterSlot3.GetComponent<CharacterSlot>().characterImage.color = new Color(1f, 1f, 1f, 1f);
            if (characterSlot3.GetComponent<CharacterSlot>().description != null)
                characterSlot3.GetComponent<CharacterSlot>().description.SetActive(false);

        }
        if (Player.instance.characterSlot4 != null)
        {
            characterSlot4.GetComponent<CharacterSlot>().characterDetailSO = Player.instance.characterSlot4;
            characterSlot4.gameObject.name = Player.instance.characterSlot4.name;
            characterSlot4.GetComponent<CharacterSlot>().characterImage.sprite = Player.instance.characterSlot4.characterSprite;
            characterSlot4.GetComponent<CharacterSlot>().characterImage.color = new Color(1f, 1f, 1f, 1f);
            if (characterSlot4.GetComponent<CharacterSlot>().description != null)
                characterSlot4.GetComponent<CharacterSlot>().description.SetActive(false);
        }
        if (Player.instance.characterSlot5 != null)
        {
            characterSlot5.GetComponent<CharacterSlot>().characterDetailSO = Player.instance.characterSlot1;
            characterSlot5.gameObject.name = Player.instance.characterSlot5.name;
            characterSlot5.GetComponent<CharacterSlot>().characterImage.sprite = Player.instance.characterSlot5.characterSprite;
            characterSlot5.GetComponent<CharacterSlot>().characterImage.color = new Color(1f, 1f, 1f, 1f);
            if (characterSlot5.GetComponent<CharacterSlot>().description != null)
                characterSlot5.GetComponent<CharacterSlot>().description.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
