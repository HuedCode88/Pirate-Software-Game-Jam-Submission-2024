using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor_spawna : MonoBehaviour
{
    Player player;
    public float groundHeight;
    public float groundRight;
    public float screenRight;
    BoxCollider2D collider;
    
    [SerializeField] public Camera mainCamera;

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<PlayerPrefs>;

        collider = GetComponent<BoxCollider2D>();
        groundHeight = transform.position.y + (collider.size.y / 2);
    }
    void Start()
    {
        Vector3 rightSidePosition = GetRightSidePosition(mainCamera);
        Debug.Log("Right side position: " + rightSidePosition);
    }

    Vector3 GetRightSidePosition(Camera camera)
    {
        float cameraHeight = 2f * camera.orthographicSize;
        float cameraWidth = cameraHeight * camera.aspect;

        Vector3 cameraPosition = camera.transform.position;
        return new Vector3(cameraPosition.x + cameraWidth / 2, cameraPosition.y, cameraPosition.z);
    }
}

// Update is called once per frame
        void Update()
        {
            screenRight = GetRightSidePosition(mainCamera);
}
        void FixedUpdate()
        {
        groundRight = transform.position.x + (collinder.size.x / 2);
    
    if (!didGenerateGround)
    {

        if (GetRightSidePosition(mainCamera) < screenRight)
        {
            didGenerateGround = true;
            generateGround();
        }
    }

        }
        
        void generateGround()
        {
            GameObject go = Instantiate(gameObject);
            BoxCollider2D goCollider = go.GetComponent<BoxCollider2D>;
            Vector2 pos;
        }

}
