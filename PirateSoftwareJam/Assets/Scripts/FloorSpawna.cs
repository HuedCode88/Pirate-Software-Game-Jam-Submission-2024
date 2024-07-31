using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawna : MonoBehaviour
{
    [SerializeField] int width, height;
    [SerializeField] GameObject floor;
    void Start()
    {
        Generation();
    }

    void Generation()
    {
        for (int x = 0; x < width; x++)//this will help spawn a tile on the x axis
        {
            int minHeight = height - 1;
            int maxHeight = height + 2;

            height = Random.Range(minHeight, maxHeight);
            for (int y = 0; y < height; y++)
            {//this will help spawn a tile on the x axis

                Instantiate(floor, new Vector2(x, y), Quaternion.identity);
                spawnObj(floor, x, y);
            }
        }
        
    }
    void spawnObj(GameObject obj, int width, int height)//what ever we spawn will be a child of our procedural generation game obj
    {
        obj = Instantiate(obj, new Vector2(width, height), Quaternion.identity);
        obj.transform.parent = this.transform;
    }
    void Update()
    {

    }
}
