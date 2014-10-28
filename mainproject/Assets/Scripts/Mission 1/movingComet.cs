using UnityEngine;
using System.Collections;

public class movingComet : MonoBehaviour {
	


	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Terrain") {
			rigidbody.velocity = new Vector3 (0,0,0);
			rigidbody.position = new Vector3(rigidbody.position.x, rigidbody.position.y - 10, rigidbody.position.z);
			rigidbody.useGravity = false;
			CameraShake.Shaking = true;
			Destroy(gameObject);

		}
	}
}