using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] Material[] enemyMaterials;

    [SerializeField] GameObject[] enemySpawners;

    [SerializeField] float timeBetweenSpawning;
    [SerializeField] int enemiesPerSpawn;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemyCoroutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemy()
    {
        for (int i = 0; i < enemiesPerSpawn; i++)
        {
            GameObject prefab = enemyPrefab;
            Instantiate(prefab, enemySpawners[Random.Range(0, enemySpawners.Length)].transform.position, Quaternion.identity);
            prefab.GetComponentInChildren<MeshRenderer>().material = enemyMaterials[Random.Range(0, enemyMaterials.Length)];
        }
    }

    IEnumerator SpawnEnemyCoroutine()
    {
        while (true)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(timeBetweenSpawning);
        }
    }
}
