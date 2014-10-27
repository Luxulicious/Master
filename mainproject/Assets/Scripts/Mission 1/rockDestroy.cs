using UnityEngine;
using System.Collections;

public class rockDestroy : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		Destroy (gameObject, 15f);
	}
}
