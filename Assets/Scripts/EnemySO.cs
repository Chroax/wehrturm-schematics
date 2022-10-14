using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyDetail", menuName = "Scriptable Objects/Enemy Detail")]

public class EnemySO : ScriptableObject
{
    public float attack;
    public float health;
    public MoveSpeed moveSpeed;
    public AttackSpeed attackSpeed;
    public CharacterType type;
    public AttackType attackType;
    public GameObject enemyPrefab;
}
