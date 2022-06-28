using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] Material[] enemyMaterials;

    [SerializeField] Transform[] enemySpawners;

    [SerializeField] float timeBetweenSpawning;

    [SerializeField] int addedEnemiesPerPoints; //Enemigos que se añaden al maximo cada 50 puntos

    bool allowedSpawning = true;

    public int AddedEnemiesPerPoints
    {
        get { return addedEnemiesPerPoints; }
        set { addedEnemiesPerPoints = value; }
    }

    [SerializeField] int enemiesPerSpawn;

    public int EnemiesPerSpawn
    {
        get { return enemiesPerSpawn; }
        set { enemiesPerSpawn = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemyCoroutine());
    }

    public void AddMaxEnemiesPerSpawn()
    {
        enemiesPerSpawn += addedEnemiesPerPoints;
    }

    void SpawnEnemy()
    {
        for (int i = 0; i < enemiesPerSpawn; i++)
        {
            GameObject go = Instantiate(enemyPrefab, enemySpawners[Random.Range(0, enemySpawners.Length)].transform.position, Quaternion.identity);
            go.GetComponentInChildren<MeshRenderer>().material = enemyMaterials[Random.Range(0, enemyMaterials.Length)];
        }
    }

    IEnumerator SpawnEnemyCoroutine()
    {
        while (allowedSpawning)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(timeBetweenSpawning);
        }
    }
}
