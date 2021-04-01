using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject prefab;
    float ct = 0;
    float spawnRate = 3;

    // Start is called before the first frame update
    void Start()
    {
        ct = spawnRate;
    }

    // Update is called once per frame
    void Update()
    {
        if (ct < 0)
		{
            GameObject newObject = Instantiate(prefab);
            newObject.transform.position = new Vector3(Random.Range(-0.5f, 0.5f), transform.position.y, 0f);
            ct = spawnRate;
        }

        ct -= Time.deltaTime;
    }
}
