using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSpawn : MonoBehaviour
{
    public Image characterSprite;
    public CharacterDetailSO characterDetail;
    public GameObject loadBar;
    public GameObject coin;
    public Transform characterSpawn;
    
    // Start is called before the first frame update
    void Start()
    {
        loadBar.transform.Find("Background").Find("Load").localScale = new Vector3(0f, 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SpawnCharacter()
    {
        if (loadBar.transform.Find("Background").Find("Load").localScale.x == 1f)
        {
            Instantiate(characterDetail.characterPrefab, characterSpawn);
            Player.instance.coin -= characterDetail.price;
            loadBar.transform.Find("Background").Find("Load").localScale = new Vector3(0f, 1f, 1f);
            LoadBar();
        }
    }

    public void LoadBar()
    {
        LeanTween.scaleX(loadBar.transform.Find("Background").Find("Load").gameObject, 1f, characterDetail.cooldown);
    }
}
