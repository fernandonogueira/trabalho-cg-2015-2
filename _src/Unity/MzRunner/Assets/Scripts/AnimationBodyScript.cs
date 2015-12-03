using UnityEngine;
using System.Collections;

public class AnimationBodyScript : MonoBehaviour {

	public bool moveLeft = false;

	public float size = 5;
	public float power = 100;
	public GameObject effect;
	
	void Explodir(){
		Vector3 explosionPos = transform.position;
		Collider[] colliders = Physics.OverlapSphere(explosionPos, size);
		
		Instantiate (effect, transform.position, transform.rotation);
		
		foreach (Collider hit in colliders) {
			
			Rigidbody rb = hit.GetComponent<Rigidbody>();
			
			if (rb != null)
				rb.AddExplosionForce(power, explosionPos, size, 3.0F);
			
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(moveLeft)
		{
			transform.Translate(Vector3.forward * Time.deltaTime);
		}
		
		else
		{
			transform.Translate(Vector3.back * Time.deltaTime);
		}
	}

	void OnTriggerEnter (Collider other)
	{
			moveLeft = !moveLeft;

		if (other.CompareTag ("Personagem")) {
		
			Explodir ();

		}

	}

}
