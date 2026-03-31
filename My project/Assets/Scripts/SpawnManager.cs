using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20f;
    private float spawnPositionZ = 20f;
    public float spawnInterval = 1.5f;

    private bool corrotina;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spawnInterval -= Time.deltaTime / 100f;

        if (corrotina == false)
        {
            StartCoroutine(Timer());
            corrotina = true;
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(spawnInterval);
        SpawnAnimal();
        corrotina = false;
    }

    void SpawnAnimal()
    {
        // escolhe um animal aleatoriamente
        // animalPrefabs.Length retorna o tamanho do vetor
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        // escolhe um posição x aleatoriamente
        Vector3 randomPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);
        Instantiate(animalPrefabs[animalIndex], randomPosition,
            animalPrefabs[animalIndex].transform.rotation);
    }
}
