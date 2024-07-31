using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampfireHealth : MonoBehaviour
{
    //health points and dealing damage easy
    public int hp = 3;
    public void campDamage()
    {
        hp -= 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0) {
            Destroy(gameObject);
        }
    }
}
