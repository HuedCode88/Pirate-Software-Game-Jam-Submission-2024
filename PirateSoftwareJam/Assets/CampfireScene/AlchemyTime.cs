using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlchemyTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var enemy = GameObject.Find("Enemy");
            enemy.GetComponent<EnemyBehavior>().kill();
        }
    }
}
