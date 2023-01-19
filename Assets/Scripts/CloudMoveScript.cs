using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMoveScript : MonoBehaviour
{

    public float moveSpeed = 1;
    public float deleteZone = -15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        moveObject(2);
        
        if (transform.position.x < deleteZone) {

            Debug.Log("Cloud Deleted");
            Destroy(gameObject);

        }

    }

    public void moveObject(float multiplier)
    {

        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime * multiplier;

    }

}
