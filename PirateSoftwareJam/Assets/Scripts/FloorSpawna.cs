using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawna : MonoBehaviour
{
    public static int minDist = 1000;
    public static int maxDist = 1500;
    public int width;
    public int height=1;
    [SerializeField] GameObject floor;
    int start=0;
    


    public float secValue;
    public float secValueIncreased = 1f;
    public bool playerDead = false;
    void Start()
    {
        Generation();
    }

    void Generation()//floor making
    {
        width = Random.Range(minDist, maxDist);
        for (int x = 0; x < width; x++)//this will help spawn a tile on the x axis
        {
            width += (int)secValue;
            if (start<5)
            {
                int minHeight = height;
                int maxHeight = height;
                height = Random.Range(minHeight, maxHeight);
                start++;
            }
            else {
                int minHeight = height - 1;
                int maxHeight = height + 2;
                height = Random.Range(minHeight, maxHeight);
            }
            for (int y = 0; y < height; y++)
            {//this will help spawn a tile on the x axis

                spawnObj(floor, x, y);
            }
        }

    }
    

    void spawnObj(GameObject obj, int width, int height)//what ever we spawn will be a child of our procedural generation game obj
    {
        obj = Instantiate(obj, new Vector2(width, height), Quaternion.identity);
        obj.transform.parent = this.transform;
    }
    void FixedUpdate()
    {
        secValue += secValueIncreased * Time.fixedDeltaTime;
    }
    void Update()
    {
        if (playerDead)
        {
            width += (int)secValue;
        }
    }
}
