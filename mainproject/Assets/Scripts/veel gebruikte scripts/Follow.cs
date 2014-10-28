using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {


    public Transform target;
    public float moveSpeed = 3;
	public float runSpeed = 8;
    public float rotationSpeed = 5;
    public Transform myTransform;
	Vector3 respawnPos = new Vector3 (3, 0, 3);

   
    void Awake()
    {
        myTransform = transform;
        
    }
    
    // Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {

        if (Switch.p1check == true)
        {
            target = GameObject.FindWithTag("target1").transform;
            
        }
        else if (Switch.p2check == true)
        {
            target = GameObject.FindWithTag("target3").transform;
        }
        else if (Switch.p3check == true)
        {
            target = GameObject.FindWithTag("target5").transform;
        }


		if ((target.position.x - myTransform.position.x >= 4) && (target.position.x - myTransform.position.x <= 6) || (target.position.z - myTransform.position.z >= 4) && (target.position.z - myTransform.position.z <= 6) || (target.position.x - myTransform.position.x <= -4) && (target.position.x - myTransform.position.x >= -6) || (target.position.z - myTransform.position.z <= -4) && (target.position.x - myTransform.position.x >= -6)) {
						myTransform.rotation = Quaternion.Slerp (myTransform.rotation,
                Quaternion.LookRotation (target.position - myTransform.position), rotationSpeed * Time.deltaTime);
						myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
				} else if ((target.position.x - myTransform.position.x < 4) || (target.position.z - myTransform.position.z < 4) || (target.position.x - myTransform.position.x > -4) || (target.position.z - myTransform.position.z > -4)) {
						myTransform.rotation = Quaternion.Slerp (myTransform.rotation,
                Quaternion.LookRotation (target.position - myTransform.position), rotationSpeed * Time.deltaTime);
						myTransform.position += new Vector3 (0, 0, 0);
				} else if ((target.position.x - myTransform.position.x > 6) || (target.position.z - myTransform.position.z > 6) || (target.position.x - myTransform.position.x < -6) || (target.position.z - myTransform.position.z < -6)) {
			myTransform.position = (target.position - respawnPos );		

					/*myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
					Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
					myTransform.position += myTransform.forward * runSpeed * Time.deltaTime;*/
				}
	}
}
