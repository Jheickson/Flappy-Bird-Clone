using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{

    public GameObject Pipes;
    public float PipeSpawnRate = 5;
    private float PipeTimer = 0;
    public float PipeHeightOffset = 2;

    // Start is called before the first frame update
    void Start()
    {

        spawnPipe();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (PipeTimer < PipeSpawnRate) {

            PipeTimer += Time.deltaTime;

        } else {

            spawnPipe();
            PipeTimer = 0;

        }


    }

    void spawnPipe() {

        Debug.Log("Pipe Created");
        float lowestPoint = transform.position.y - PipeHeightOffset;
        float highestPoint = transform.position.y + PipeHeightOffset;

        Instantiate(Pipes, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

    }

}
