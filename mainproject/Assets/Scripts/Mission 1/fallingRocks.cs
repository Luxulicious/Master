using UnityEngine;
using System.Collections;

public class fallingRocks : MonoBehaviour {

	public GameObject rock1;
	public GameObject rock2;


	// Use this for initialization
	void Start () {
		StartCoroutine (fallingRock1());
		StartCoroutine (fallingRock2());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	 IEnumerator fallingRock1()
	{
		while (true) 
		{
			Instantiate (rock1, new Vector3(Random.Range (30, 460), 200,Random.Range (0, 460)), Quaternion.identity);
			yield return new WaitForSeconds(Random.Range(1f, 3f));
		}
	}
	IEnumerator fallingRock2()
	{
		while (true) 
		{
			Instantiate (rock2, new Vector3(Random.Range (30, 220), 200,Random.Range (0, 250)), Quaternion.identity);
			yield return new WaitForSeconds(Random.Range(1f, 3f));
		}
	}
}
