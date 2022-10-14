using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TowerHP", menuName = "Scriptable Objects/Tower HP")]
public class TowerHPSO : ScriptableObject
{
    public Sprite towerImage;
    public int level;
    public int price;
    public int health;
}
