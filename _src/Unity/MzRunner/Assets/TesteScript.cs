using UnityEngine;
using System.Collections;

public class TesteScript : MonoBehaviour {

	public Camera myCamera;
	
	// Faz a tela tremer ao pressionar T
	void Update () {
	
		if(Input.GetKey ("t")){
			myCamera.GetComponent<CameraPadrao>().Tremer();
		}

	}
}
