using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody.velocity = new Vector2(10, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) & rigidBody.velocity != new Vector2(-10, 0))
        {
            rigidBody.velocity = new Vector2(10, 0);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && rigidBody.velocity != new Vector2 (10, 0))
        {
            rigidBody.velocity = new Vector2(-10, 0);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && rigidBody.velocity != new Vector2(0, -10))
        {
            rigidBody.velocity = new Vector2(0, 10);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && rigidBody.velocity != new Vector2(0, 10))
        {
            rigidBody.velocity = new Vector2(0, -10);
        }
    }
}
