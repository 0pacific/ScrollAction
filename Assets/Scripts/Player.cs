using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    private const float FIRST_SPEED = 5;
    bool moving = false;
    Vector3 newPos;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0) && !moving)
        {
            newPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,10));
            transform.position = Vector3.MoveTowards(transform.position, newPos, FIRST_SPEED * Time.deltaTime);
            moving = true;
        }

        if (moving)
        {
            transform.position = Vector3.MoveTowards(transform.position, newPos, FIRST_SPEED * Time.deltaTime);
            if (transform.position.Equals(newPos))
            {
                moving = false;
            }
        }
    }
}
