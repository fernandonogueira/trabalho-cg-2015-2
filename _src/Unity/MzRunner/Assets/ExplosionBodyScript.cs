using UnityEngine;
using System.Collections;

public class ExplosionBodyScript : MonoBehaviour {
	
	public float size = 10;
	public float power = 900;
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
	void Update () {
		
	}
	
	void OnCollisionEnter(Collision collision) {
		
		if (collision.rigidbody) {
			Explodir ();
		}
	}
}
