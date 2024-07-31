using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Camera tracks "target" player. Note that vector is three-dimensional to ensure no issues with layers displaying improperly.
        // Note for later: Implement "barriers" (i.e prevent camera from going past left starting wall)
        transform.position = new Vector3(target.transform.position.x+7, target.transform.position.y+2, -10);
    }
}
