using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TowerDefense", menuName = "Scriptable Objects/Tower Defense")]

public class TowerDefenseSO : ScriptableObject
{
    public int level;
    public int price;
    public int defense;
}
