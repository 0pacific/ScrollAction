using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	private bool isMoving = false;
	private Vector3 newPos;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

			Vector3 current = transform.position;

			if (!isMoving)
			{
					newPos = new Vector3(Random.Range(Constants.STAGE_WIDTH * -1 + 1,Constants.STAGE_WIDTH - 1),Random.Range(Constants.STAGE_HEIGHT * -1 + 1,Constants.STAGE_HEIGHT - 1),0);
					isMoving = true;
			}
			else{
				current = Vector3.MoveTowards(transform.position, newPos, Constants.FIRST_SPEED * Time.deltaTime / 2f);
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
}
