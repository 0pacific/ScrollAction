using UnityEngine;
using System.Collections;

public class Player : Constants
{

    bool isMoving = false;
    Vector3 newPos;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 current = transform.position;

        if (Input.GetMouseButtonDown(0) && !isMoving)
        {
            newPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,10));
            isMoving = true;
        }

        if (isMoving)
        {
            current = Vector3.MoveTowards(transform.position, newPos, FIRST_SPEED * Time.deltaTime);
            if (current.Equals(newPos))
            {
                isMoving = false;
            }
            if (current.x <= STAGE_WIDTH * -1)
            {
                isMoving = false;
                current.x = STAGE_WIDTH * -1;
            }
            else if (current.x >= STAGE_WIDTH)
            {
                isMoving = false;
                current.x = STAGE_WIDTH;
            }
            if (current.y <= STAGE_HEIGHT * -1)
            {
                isMoving = false;
                current.y = STAGE_HEIGHT * -1;
            }
            else if (current.y >= STAGE_HEIGHT)
            {
                isMoving = false;
                current.y = STAGE_HEIGHT;
            }
            transform.position = current;
        }
    }

    void OnCollisionEnter(Collision c)
    {
        Destroy(c.gameObject);
    }
}
