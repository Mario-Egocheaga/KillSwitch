using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMiniGame : MonoBehaviour
{
    public float moveSpeed;
    public Transform movePoint;

    public GameObject NextSeq;
    public GameObject PrevSeq;
    public float tally = 0;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) & transform.position.y < 3)
            transform.Translate(0, 1.25f, 0);
        else if (Input.GetKeyDown(KeyCode.DownArrow) & transform.position.y > -3)
            transform.Translate(0, -1.25f, 0);
        else if (Input.GetKeyDown(KeyCode.LeftArrow) & transform.position.x > -7)
            transform.Translate(-1.25f, 0, 0);
        else if (Input.GetKeyDown(KeyCode.RightArrow) & transform.position.x < 7)
            transform.Translate(1.25f, 0, 0);
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Exit") 
        {

            if (Input.GetKey(KeyCode.Space))
            {
                Destroy(collision.gameObject);
                tally++;

                if (tally == 8)
                {
                    NextSeq.SetActive(true);
                    PrevSeq.SetActive(false);
                }
            }

        }
    }
}
