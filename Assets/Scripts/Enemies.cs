using UnityEngine;
using System.Collections;

public class Enemies : Constants
{

    public GameObject enemy;


    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            float eX = Random.Range(STAGE_WIDTH * -1, STAGE_WIDTH);
            float eY = Random.Range(STAGE_HEIGHT * -1, STAGE_HEIGHT);

            Instantiate(enemy, new Vector3(eX, eY, 0), Quaternion.identity);
        }

	}

	// Update is called once per frame
	  void Update () {

    }
}
