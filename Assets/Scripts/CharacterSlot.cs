using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class CharacterSlot : MonoBehaviour, IDropHandler
{
    public Image defaultImage;
    public string originName;
    public Transform characterSlot;
    public Transform characterDeck;
    public Image characterImage;
    public CharacterDetailSO characterDetailSO;
    public GameObject description;
    private string objectName;

    #region Card Detail References
    [Space(10)]
    [Header("Card Detail References")]
    #endregion
    public GameObject cardDetail;
    public Image typeIcon;
    public Image detailImage;
    public TextMeshProUGUI detailName;
    public TextMeshProUGUI detailAttackType;
    public TextMeshProUGUI detailCooldown;
    public TextMeshProUGUI detailAttack;
    public TextMeshProUGUI detailHealth;
    public TextMeshProUGUI detailPrice;
    public TextMeshProUGUI detailAttackSpeed;
    public TextMeshProUGUI detailMoveSpeed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
        {
            Transform findObject = characterSlot.transform.Find(eventData.pointerDrag.GetComponent<Card>().character.name);
            if (findObject)
            {
                findObject.gameObject.name = findObject.GetComponent<CharacterSlot>().originName;
                Debug.Log(gameObject.name);
                findObject.GetComponent<CharacterSlot>().characterImage.sprite = defaultImage.sprite;
                findObject.GetComponent<CharacterSlot>().characterImage.color = new Color(1f, 1f, 1f, 0f);
                findObject.GetComponent<CharacterSlot>().characterDetailSO = null;
                if (findObject.GetComponent<CharacterSlot>().originName.Equals("CharacterSlot1"))
                    Player.instance.characterSlot1 = null;
                else if (findObject.GetComponent<CharacterSlot>().originName.Equals("CharacterSlot2"))
                    Player.instance.characterSlot2 = null;
                else if (findObject.GetComponent<CharacterSlot>().originName.Equals("CharacterSlot3"))
                    Player.instance.characterSlot3 = null;
                else if (findObject.GetComponent<CharacterSlot>().originName.Equals("CharacterSlot4"))
                    Player.instance.characterSlot4 = null;
                else if (findObject.GetComponent<CharacterSlot>().originName.Equals("CharacterSlot5"))
                    Player.instance.characterSlot5 = null;
                if (description != null)
                    findObject.GetComponent<CharacterSlot>().description.SetActive(true);
            }

            if (objectName != null)
                characterDeck.transform.Find(objectName).transform.Find("UseInfo").gameObject.SetActive(false);
            
            characterImage.sprite = eventData.pointerDrag.transform.Find("CharacterSprite").gameObject.GetComponent<Image>().sprite;
            characterImage.color = new Color(1f, 1f, 1f, 1f);
            eventData.pointerDrag.transform.Find("UseInfo").gameObject.SetActive(true);
            objectName = eventData.pointerDrag.GetComponent<Card>().character.name;
            this.gameObject.name = objectName;
            this.characterDetailSO = eventData.pointerDrag.GetComponent<Card>().character;
            AssignSlotToPlayer();
            if (description != null)
                description.SetActive(false);
            Debug.Log(characterDetailSO.name);
        }
    }

    public void AssignSlotToPlayer()
    {
        if (originName.Equals("CharacterSlot1"))
            Player.instance.characterSlot1 = this.characterDetailSO;
        else if (originName.Equals("CharacterSlot2"))
            Player.instance.characterSlot2 = this.characterDetailSO;
        else if (originName.Equals("CharacterSlot3"))
            Player.instance.characterSlot3 = this.characterDetailSO;
        else if (originName.Equals("CharacterSlot4"))
            Player.instance.characterSlot4 = this.characterDetailSO;
        else if (originName.Equals("CharacterSlot5"))
            Player.instance.characterSlot5 = this.characterDetailSO;
    }

    public void OpenDetailCard()
    {
        if(characterDetailSO != null)
        {
            cardDetail.SetActive(true);
            detailImage.sprite = characterDetailSO.characterSprite;
            detailName.text = characterDetailSO.name;
            detailAttackType.text = characterDetailSO.attackType.ToString();
            detailCooldown.text = "Cooldown: " + characterDetailSO.cooldown.ToString() + " S";
            detailAttack.text = characterDetailSO.attack.ToString();
            detailHealth.text = characterDetailSO.health.ToString();
            detailPrice.text = characterDetailSO.price.ToString();
            detailAttackSpeed.text = characterDetailSO.attackSpeed.ToString();
            detailMoveSpeed.text = characterDetailSO.moveSpeed.ToString();
        }
    }
}
