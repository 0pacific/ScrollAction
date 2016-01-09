using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    // Use this for initialization
    void Start () {

	}

	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = new Vector3(Input.mousePosition.x,Input.mousePosition.y,10);
						pos = Camera.main.ScreenToWorldPoint(pos);
          	transform.position = pos;

        }
    }
}
