using UnityEngine;
using System.Collections;

public class geiser1 : MonoBehaviour {

	public GameObject Geiser;
	public GameObject pos1, pos2, pos3, pos4, pos5;
	public float positionx, positiony, positionz;


	// Use this for initialization
	void Start () {
		StartCoroutine (Geisers ());
	}
	
	// Update is called once per frame
	void Update () {
		RandomPos ();
	}

	IEnumerator Geisers()
	{
		while (true) 
		{
			Instantiate (Geiser, new Vector3(positionx, positiony, positionz), Quaternion.identity);
			yield return new WaitForSeconds(Random.Range(5f, 8f));
		}
	}

	void RandomPos()
	{
		int rnd = Random.Range (0, 5);

		if (rnd == 1) {
						positionx = pos1.rigidbody.position.x;
						positiony = pos1.rigidbody.position.y;
						positionz = pos1.rigidbody.position.z;
				} else if (rnd == 2) {
						positionx = pos2.rigidbody.position.x;
						positiony = pos2.rigidbody.position.y;
						positionz = pos2.rigidbody.position.z;
				} else if (rnd == 3) {
						positionx = pos3.rigidbody.position.x;
						positiony = pos3.rigidbody.position.y;
						positionz = pos3.rigidbody.position.z;
				} else if (rnd == 4) {
						positionx = pos4.rigidbody.position.x;
						positiony = pos4.rigidbody.position.y;
						positionz = pos4.rigidbody.position.z;
				} else if (rnd == 5) {
						positionx = pos5.rigidbody.position.x;
						positiony = pos5.rigidbody.position.y;
						positionz = pos5.rigidbody.position.z;
				}
	}
}