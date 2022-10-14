using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterDetail", menuName = "Scriptable Objects/Card Detail")]
public class CharacterDetailSO : ScriptableObject
{
    public Sprite characterSprite;
    public string name;
    public float attack;
    public float health;
    public int price;
    public MoveSpeed moveSpeed;
    public AttackSpeed attackSpeed;
    public CharacterType type;
    public AttackType attackType;
    public float cooldown;
    public GameObject characterPrefab;
}
