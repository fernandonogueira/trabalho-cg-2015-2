using UnityEngine;
using System.Collections;

public class TesteScript : MonoBehaviour {

	public Camera myCamera;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKey ("t")){
			myCamera.GetComponent<CameraPadrao>().Tremer();
		}

	}
}
