using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyBehavior : MonoBehaviour
{
    //variable to access the camp health code
    public CampfireHealth campHealth;
    //variable to access position of camp
    public Transform Camp;
    
    //self explanatory variables
    int MoveSpeed = 4;
    int MinDist = 1;
    private float range;
    public bool isAlive = true;
    
    //kills monster gonna be used for when player uses right colors and when monster reaches fire
    public void kill()
    {
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gets the distance from the enemy to the camp
        range = Vector2.Distance(transform.position, Camp.position);

        //if the enemy is far away it moves towards the camp until it hits the camp
        if (range > MinDist)
        {
            Debug.Log(range);

            transform.position = Vector2.MoveTowards(transform.position, Camp.position, MoveSpeed * Time.deltaTime);
        }
        
        //when it reaches the camp it deals damage then burns away
        else
        {
            campHealth.campDamage();
            kill();
        }

        if (isAlive == false)
        {
            kill();
        }
    }
}
