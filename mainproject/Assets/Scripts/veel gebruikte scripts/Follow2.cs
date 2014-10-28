using UnityEngine;
using System.Collections;

public class Follow2 : MonoBehaviour
{


    public Transform Doel2;
    public float moveSpeed2 = 3;
	public float runSpeed2 = 8;
    public float rotationSpeed2 = 5;
    public Transform myTransform2;


    void Awake()
    {
        myTransform2 = transform;

    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Switch.p1check == true)
        {
            Doel2 = GameObject.FindWithTag("target2").transform;

        }
        else if (Switch.p2check == true)
        {
            Doel2 = GameObject.FindWithTag("target4").transform;
        }
        else if (Switch.p3check == true)
        {
            Doel2 = GameObject.FindWithTag("target6").transform;
        }



		if ((Doel2.position.x - myTransform2.position.x >= 4) && (Doel2.position.x - myTransform2.position.x <= 6) || (Doel2.position.z - myTransform2.position.z >= 4) && (Doel2.position.z - myTransform2.position.z <= 6) || (Doel2.position.x - myTransform2.position.x <= -4) && (Doel2.position.x - myTransform2.position.x >= -6) || (Doel2.position.z - myTransform2.position.z <= -4) && (Doel2.position.x - myTransform2.position.x >= -6))
        {
        myTransform2.rotation = Quaternion.Slerp(myTransform2.rotation,
            Quaternion.LookRotation(Doel2.position - myTransform2.position), rotationSpeed2 * Time.deltaTime);
        myTransform2.position += myTransform2.forward * moveSpeed2 * Time.deltaTime;
        }
		else if ((Doel2.position.x - myTransform2.position.x < 4) || (Doel2.position.z - myTransform2.position.z < 4) || (Doel2.position.x - myTransform2.position.x > -4) || (Doel2.position.z - myTransform2.position.z > -4))
        {
            myTransform2.rotation = Quaternion.Slerp(myTransform2.rotation,
                Quaternion.LookRotation(Doel2.position - myTransform2.position), rotationSpeed2 * Time.deltaTime);
            myTransform2.position += new Vector3(0, 0, 0);

		}else if ((Doel2.position.x - myTransform2.position.x > 6) || (Doel2.position.z - myTransform2.position.z > 6) || (Doel2.position.x - myTransform2.position.x < -6) || (Doel2.position.z - myTransform2.position.z < -6)) {
			myTransform2.rotation = Quaternion.Slerp(myTransform2.rotation,
			Quaternion.LookRotation(Doel2.position - myTransform2.position), rotationSpeed2 * Time.deltaTime);
			myTransform2.position += myTransform2.forward * runSpeed2 * Time.deltaTime;
		}
    }
}
