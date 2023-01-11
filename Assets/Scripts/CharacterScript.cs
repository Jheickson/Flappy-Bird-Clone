using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public float flapStrength = 10;
    public LogicManagerScript logic;
    public bool birdIsAlive = true;
    public Animator animator;

    private BirdSounds sounds;


    // Start is called before the first frame update
    void Start()
    {

        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();

        sounds = GetComponent<BirdSounds>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive) {

            myRigidBody.velocity = Vector2.up * flapStrength;

            sounds.Flaps();
            
        }

        animator.SetFloat("Vertical Speed", myRigidBody.velocity.y);
        animator.SetBool("Alive", birdIsAlive);

        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (birdIsAlive)
        {

            logic.gameOver();
            birdIsAlive = false;
            sounds.Dies();

        }
        else Debug.Log("Bird is already dead");

    }

}
