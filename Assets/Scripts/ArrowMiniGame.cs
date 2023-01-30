using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMiniGame : MonoBehaviour
{
    public float moveSpeed;
    public Transform movePoint;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) & transform.position.y < 3)
            transform.Translate(0, 1.25f, 0);
        else if (Input.GetKeyDown(KeyCode.DownArrow) & transform.position.y > -3)
            transform.Translate(0, -1.25f, 0);
        else if (Input.GetKeyDown(KeyCode.LeftArrow) & transform.position.x > -5)
            transform.Translate(-1.25f, 0, 0);
        else if (Input.GetKeyDown(KeyCode.RightArrow) & transform.position.x < 5)
            transform.Translate(1.25f, 0, 0);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Exit")
        {
            Destroy(collision.gameObject);
        }
    }
}
