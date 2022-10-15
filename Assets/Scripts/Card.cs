using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Card : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IPointerDownHandler
{
    public GameObject characterDrag;
    public TextMeshProUGUI characterName;
    public TextMeshProUGUI characterAttack;
    public TextMeshProUGUI characterHealth;
    public TextMeshProUGUI characterPrice;
    public CharacterDetailSO character;
    public Canvas canvas;
    public Image characterImage;

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

    private RectTransform rectTransform;
    private Vector3 originPosition;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = character.name;
        characterName.text = character.name;
        characterAttack.text = character.attack.ToString();
        characterHealth.text = character.health.ToString();
        characterPrice.text = character.price.ToString();
        characterImage.sprite = character.characterSprite;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        characterDrag.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
        characterDrag.GetComponent<Image>().sprite = characterImage.sprite;
        characterDrag.GetComponent<CanvasGroup>().alpha = 0.6f;
        characterDrag.GetComponent<RectTransform>().anchoredPosition = Input.mousePosition - new Vector3(0, 380, 0);
        characterDrag.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        characterDrag.GetComponent<RectTransform>().anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        characterDrag.GetComponent<RectTransform>().anchoredPosition = originPosition;
        characterDrag.GetComponent<CanvasGroup>().alpha = 1f;
        characterDrag.GetComponent<CanvasGroup>().blocksRaycasts = true;
        characterDrag.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        originPosition = rectTransform.anchoredPosition;
    }
    public void OpenDetailCard()
    {
        cardDetail.SetActive(true);
        detailImage.sprite = character.characterSprite;
        detailName.text = character.name;
        detailCooldown.text = "Cooldown: " + character.cooldown.ToString() + " S";
        detailAttack.text = character.attack.ToString();
        detailHealth.text = character.health.ToString();
        detailPrice.text = character.price.ToString();
        detailMoveSpeed.text = character.moveSpeed.ToString();
    }
}
