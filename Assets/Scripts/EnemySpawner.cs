using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<LevelingSO> stage;
    public LevelingSO selectedStage;
    public Transform enemyPlaceholder;
    public GameObject loseLayout;
    public GameObject winLayout;
    public float cooldownEnemy;
    public float health;

    private void Start()
    {
        if(Player.instance.stage != 0)
            selectedStage = stage[Player.instance.stage - 1];
        else
            selectedStage = stage[0];
        health = selectedStage.health;
        cooldownEnemy = selectedStage.enemySpawnCooldown;
        StartCoroutine(spawnEnemy());
    }

    private void Update()
    {
        if (Player.instance.currentHealth <= 0)
            loseLayout.SetActive(true);
        if (health <= 0)
            winLayout.SetActive(true);
    }

    IEnumerator spawnEnemy()
    {
        while(health > 0)
        {
            int randomIndex = Random.Range(0, selectedStage.enemies.Count);
            Debug.Log(randomIndex);
            Instantiate(selectedStage.enemies[randomIndex], enemyPlaceholder);
            yield return new WaitForSeconds(selectedStage.enemySpawnCooldown);
        }
    }
}
