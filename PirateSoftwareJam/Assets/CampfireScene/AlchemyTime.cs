using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlchemyTime : MonoBehaviour
{
    private bool redSelect = false;
    private bool blueSelect = false;
    private bool greenSelect = false;
    //EnemyBehavior enemy;
    private void killer(GameObject[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i].GetComponent<EnemyBehavior>().kill();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            redSelect = !redSelect;

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            blueSelect = !blueSelect;

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            greenSelect = !greenSelect;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(redSelect)
            {
                if (redSelect && blueSelect)
                {
                    var enemy = GameObject.FindGameObjectsWithTag("Purple");
                    killer(enemy);
                    redSelect = false;
                    blueSelect = false;
                }
                else if(redSelect && greenSelect)
                {
                    var enemy = GameObject.FindGameObjectsWithTag("Yellow");
                    killer(enemy);
                    redSelect = false;
                    greenSelect = false;
                }
                else
                {
                    var enemy = GameObject.FindGameObjectsWithTag("Red");
                    killer(enemy);
                    redSelect = false;
                }
            }
            if (blueSelect)
            {
                if(blueSelect && greenSelect)
                {
                    var enemy = GameObject.FindGameObjectsWithTag("Cyan");
                    killer(enemy);
                    blueSelect = false;
                    greenSelect = false;
                }
                else
                {
                    var enemy = GameObject.FindGameObjectsWithTag("Blue");
                    killer(enemy);
                    blueSelect = false;
                }
            }
            if (greenSelect)
            {
                var enemy = GameObject.FindGameObjectsWithTag("Green");
                killer(enemy);
                greenSelect = false;
            }
        }
    }
}
