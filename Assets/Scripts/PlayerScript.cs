using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private int moveSpeed = 5;
    private bool isRightPressed = false;
    private bool isLeftPressed = false;
    private bool isUpPressed = false;
    private bool isDownPressed = false;

    Rigidbody2D rigidPlayer;

    void Start()
    {
        rigidPlayer = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        isRightPressed = Input.GetKey(KeyCode.RightArrow);
        isLeftPressed = Input.GetKey(KeyCode.LeftArrow);
        isUpPressed = Input.GetKey(KeyCode.UpArrow);
        isDownPressed = Input.GetKey(KeyCode.DownArrow);
    }

    void FixedUpdate()
    {
        Vector3 pos = transform.position;
        if (isRightPressed)
        {
            pos.x += moveSpeed * Time.deltaTime;
            transform.position = pos;
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (isLeftPressed)
        {
            pos.x -= moveSpeed * Time.deltaTime;
            transform.position = pos;
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (isDownPressed)
        {
            pos.y -= moveSpeed * Time.deltaTime;
            transform.position = pos;

        }
        if (isUpPressed)
        {
            pos.y += moveSpeed * Time.deltaTime;
            transform.position = pos;

        }
    }
}
