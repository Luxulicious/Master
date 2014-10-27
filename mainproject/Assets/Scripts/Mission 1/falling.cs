using UnityEngine;
using System.Collections;

public class falling : MonoBehaviour {

	//public bool gravitySwitch = false;
	public Rigidbody rb;
	
	void Start(){
		rb = this.gameObject.GetComponent<Rigidbody>();
		rb.useGravity = false;
		}

	void OnTriggerEnter(Collider other)
	{
		if (rb==null) {
			Debug.Log ("rb = null");
				}

		if (other.gameObject.tag == "player")
		{
			rb.useGravity = true;
		}
	}

	



	
	/*void OnTriggerEnter(Collider other)
	{
		Debug.Log ("collider: " + other.gameObject.tag);
		if (other.gameObject.tag == "player")
		{
			gravitySwitch = true;            
		}
	}
	
	// Use this for initialization
	void Start () {
		rb = this.gameObject.GetComponent<Rigidbody>();
		if (rb != null)
		{
			Debug.Log("rb = " + rb.tag);
			rb.useGravity = false;
		}
		else
			Debug.Log("rb = null");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (rb.useGravity);
		rb = this.gameObject.GetComponent<Rigidbody>();

		if (gravitySwitch)
			rb.useGravity = true;
	}
	*/
}
