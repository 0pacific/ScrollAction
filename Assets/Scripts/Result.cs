using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GoToStageSelect(){
		SceneManager.LoadScene ("StageSelect");
	}
}
