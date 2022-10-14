using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelingSO", menuName = "Scriptable Objects/Game Stage")]
public class LevelingSO : ScriptableObject
{
    public int level;
    public float health;
    public List<GameObject> enemies;
    public float enemySpawnCooldown;
}
