using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {


    public Transform target;
    public float moveSpeed = 3;
    public float rotationSpeed = 5;
    public Transform myTransform;

   
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


        if ((target.position.x - myTransform.position.x >= 3) || (target.position.z - myTransform.position.z >= 3) || (target.position.x - myTransform.position.x <= -3) || (target.position.z - myTransform.position.z <= -3))
        {
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
                Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
            myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
        }
        else
        {
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
                Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
            myTransform.position  += new Vector3(0, 0, 0);
        }
	}
}
