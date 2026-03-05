using UnityEngine;

public class LevelManager : MonoBehaviour {
    private int currentLevel = 0;
    private int totalLevels = 5;
    public GameObject[] enemies;
    public Transform[] spawnPoints;

    void Start() {
        LoadLevel();
    }

    void LoadLevel() {
        if (currentLevel < totalLevels) {
            SpawnEnemies();
        } else {
            CompleteGame();
        }
    }

    void SpawnEnemies() {
        foreach (Transform spawnPoint in spawnPoints) {
            int enemyIndex = Random.Range(0, enemies.Length);
            Instantiate(enemies[enemyIndex], spawnPoint.position, spawnPoint.rotation);
        }
    }

    public void CompleteLevel() {
        currentLevel++;
        LoadLevel();
    }

    void CompleteGame() {
        Debug.Log("All levels completed!");
    }
}