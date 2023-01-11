using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnScript : MonoBehaviour
{

    public GameObject[] Cloud;
    public float CloudSpawnRate = 1;
    private float CloudTimer = 0;
    public float CloudHeightOffset = 3;

    // Start is called before the first frame update
    void Start()
    {

        spawnCloud();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (CloudTimer < CloudSpawnRate) {

            CloudTimer += Time.deltaTime;

        } else {

            spawnCloud();
            CloudTimer = 0;

        }


    }

    void spawnCloud() {

        Debug.Log("Cloud Created");
        float lowestPoint = transform.position.y - CloudHeightOffset;
        float highestPoint = transform.position.y + CloudHeightOffset;

        Instantiate(Cloud[Random.Range(0, Cloud.Length)], new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

    }

}
