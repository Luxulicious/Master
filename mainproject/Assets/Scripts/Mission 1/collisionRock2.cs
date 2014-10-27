using UnityEngine;
using System.Collections;

public class collisionRock2 : MonoBehaviour {
	
	
	public GameObject dust;
	
	
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "p1" || other.tag == "p2" || other.tag == "p3") {
			Destroy (other.gameObject);
		}
		if (other.tag == "Terrain") {
			Instantiate (dust, new Vector3(transform.position.x, transform.position.y+1f, transform.position.z), transform.rotation);
			rigidbody.velocity = new Vector3 (0,0,0);
			rigidbody.position = new Vector3(rigidbody.position.x, rigidbody.position.y+1f, rigidbody.position.z);
			rigidbody.useGravity = false;
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
