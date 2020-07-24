using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour
{
    public GameObject hoopPrefab;
    public float spawnInterval;
    float spawnTimer;
    

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer < 0)
        {
            spawnTimer = spawnInterval;

            float x = Random.Range(-6.7f,6.7f);
            float y = Random.Range(0.15f,2.5f);
            Instantiate(hoopPrefab,new Vector3(x,y,0),Quaternion.identity,transform);
        }
    }
}
