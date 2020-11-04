using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] luggageSprites;
    public Vector3 spawnValues;
    public int luggageCount;
    public float spawnWait;
    public float startWait;

    private void Start()
    {
        StartCoroutine (SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        for (int i = 0; i < luggageCount; i++)
        {
            GameObject luggage = luggageSprites[Random.Range (0,luggageSprites.Length)];
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(luggage, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(spawnWait);
        }
    }
}
