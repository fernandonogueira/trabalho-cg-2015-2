using UnityEngine;
using System.Collections;

public class release_bouncing_ball : MonoBehaviour {

	public Rigidbody esfera;

	private bool alreadyApplied = false;

	// Caso o personagem ative o trigger, a esfera recebe uma força para que comece a se movimentar
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Personagem") && !alreadyApplied) {
			alreadyApplied = true;
			esfera.AddForce(new Vector3(0,-400,-800));
		}
	}

}
