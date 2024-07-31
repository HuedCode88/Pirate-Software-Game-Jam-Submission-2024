using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawna : MonoBehaviour
{
    public static int minDist = 100;
    public static int maxDist = 200;
    public int width= Random.Range(minDist, maxDist);
    public int height=1;
    [SerializeField] GameObject floor;
    


    public float secValue;
    public float secValueIncreased = 1f;
    public bool playerDead = false;
    void Start()
    {
        Generation();
    }

    void Generation()//floor making
    {
        for (int x = 0; x < width; x++)//this will help spawn a tile on the x axis
        {
            width += (int)secValue;
            int minHeight = height - 1;
            int maxHeight = height + 2;

            height = Random.Range(minHeight, maxHeight);

            for (int y = 0; y < height; y++)
            {//this will help spawn a tile on the x axis

                spawnObj(floor, x, y);
            }
        }

    }
    void GenerateFlatPlatform()
    {

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
