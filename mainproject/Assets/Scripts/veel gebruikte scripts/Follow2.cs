using UnityEngine;
using System.Collections;

public class Follow2 : MonoBehaviour
{


    public Transform Doel2;
    public float moveSpeed2 = 3;
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



        if ((Doel2.position.x - myTransform2.position.x >= 3) || (Doel2.position.z - myTransform2.position.z >= 3) || (Doel2.position.x - myTransform2.position.x <= -3) || (Doel2.position.z - myTransform2.position.z <= -3))
        {
        myTransform2.rotation = Quaternion.Slerp(myTransform2.rotation,
            Quaternion.LookRotation(Doel2.position - myTransform2.position), rotationSpeed2 * Time.deltaTime);
        myTransform2.position += myTransform2.forward * moveSpeed2 * Time.deltaTime;
        }
        else
        {
            myTransform2.rotation = Quaternion.Slerp(myTransform2.rotation,
                Quaternion.LookRotation(Doel2.position - myTransform2.position), rotationSpeed2 * Time.deltaTime);
            myTransform2.position += new Vector3(0, 0, 0);
        }
    }
}
