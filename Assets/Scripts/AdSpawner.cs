using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdSpawner : MonoBehaviour
{
    public Transform parent;
    public GameObject[] spawnPoints;

    public GameObject[] prefabs;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("Grid");

        InvokeRepeating("Spawn", 1f, 2f);

    }

    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        Vector2 randomizePos = new Vector2(Random.Range(1, 5), Random.Range(1, 5));

        int prefabSelected = Random.Range(0, prefabs.Length);

        GameObject ad = Instantiate(prefabs[prefabSelected], spawnPoints[spawnPointIndex].transform.position, Quaternion.identity);

        ad.transform.parent = parent.transform;

    }
}
