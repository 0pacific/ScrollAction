using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    bool isMoving = false;
    float velocity = 1;
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
            current = Vector3.MoveTowards(transform.position, newPos, Constants.FIRST_SPEED * Time.deltaTime * velocity);
            if (current.Equals(newPos))
            {
                isMoving = false;
            }
            if (current.x <= Constants.STAGE_WIDTH * -1)
            {
                isMoving = false;
                current.x = Constants.STAGE_WIDTH * -1;
            }
            else if (current.x >= Constants.STAGE_WIDTH)
            {
                isMoving = false;
                current.x = Constants.STAGE_WIDTH;
            }
            if (current.y <= Constants.STAGE_HEIGHT * -1)
            {
                isMoving = false;
                current.y = Constants.STAGE_HEIGHT * -1;
            }
            else if (current.y >= Constants.STAGE_HEIGHT)
            {
                isMoving = false;
                current.y = Constants.STAGE_HEIGHT;
            }
            transform.position = current;
        }
    }

    void OnCollisionEnter(Collision c)
    {
        Destroy(c.gameObject);
        velocity+=0.3f;
    }
}
