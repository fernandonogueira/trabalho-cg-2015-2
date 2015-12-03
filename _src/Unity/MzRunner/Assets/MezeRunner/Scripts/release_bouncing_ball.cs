using UnityEngine;
using System.Collections;

public class release_bouncing_ball : MonoBehaviour {

	public Rigidbody esfera;

	private bool alreadyApplied = false;

	void Start() {

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Personagem") && !alreadyApplied) {
			alreadyApplied = true;
			esfera.AddForce(new Vector3(0,-400,-800));
		}
	}

}
