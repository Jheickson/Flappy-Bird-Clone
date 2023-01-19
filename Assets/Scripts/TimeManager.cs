using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public LogicManagerScript logic;
    private float timeMult = 1;

    [Range(1, 3)] public float modifiedScale = 1;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {

        timeMult = (float)logic.getScore() / (float)25;
        //timeMult = (float)2/10;

        Time.timeScale = modifiedScale + timeMult;
        Debug.Log("Timescale: " + Time.timeScale);
        
    }
}
