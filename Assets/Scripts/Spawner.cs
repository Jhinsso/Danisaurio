using UnityEngine;
using System.Collections.Generic; // Necesario para usar List

public class Spawner : MonoBehaviour
{
    [Header("Spawn Settings")]
    public List<GameObject> enemyPrefabs = new List<GameObject>(); // ahora es una lista
    public float spawnInterval = 3f;
    public Vector2 spawnArea = new Vector2(5f, 0f);

    // Direccion y velocidad del spawner
    private float direction = -1f;
    private float timer = 0f;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        SpawnEnemy();
    }

    void Update() 
    {

        // Temporizador para crear nuevos enemigos
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    public void SpawnEnemy()
    {
        if (enemyPrefabs.Count == 0)
        {
            Debug.LogWarning("No hay prefabs de enemigos asignados en la lista!");
            return;
        }

        // Selecciona un enemigo aleatorio de la lista
        int randomIndex = Random.Range(0, enemyPrefabs.Count);
        GameObject selectedEnemy = enemyPrefabs[randomIndex];

        // Calcula la posición de spawn
        Vector2 spawnPos = transform.position + new Vector3(Random.Range(-spawnArea.x, spawnArea.x), spawnArea.y, 0f);

        // Instancia el enemigo
        Instantiate(selectedEnemy, spawnPos, Quaternion.identity);
    }
}