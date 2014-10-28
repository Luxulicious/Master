using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {
    
    public Transform p1;
    public Transform p2;
    public Transform p3;
	public Transform startCamera;
	public Transform p1Camera;
	public Transform p2Camera;
	public Transform p3Camera;


    public static bool p1check = true;
    public static bool p2check = false;
    public static bool p3check = false;

	// Use this for initialization
	void Start () {

		(p1.GetComponent("MouseLook") as MonoBehaviour).enabled = false;
        (p1.GetComponent("Follow") as MonoBehaviour).enabled = false;
        (p1.GetComponent("Follow2") as MonoBehaviour).enabled = false;
		 p1.rigidbody.isKinematic = true;


       
        (p2.GetComponent("CharacterController") as CharacterController).enabled = false;
		(p2.GetComponent("MouseLook") as MonoBehaviour).enabled = false;
        (p2.GetComponent("FPSInputController") as MonoBehaviour).enabled = false;
        (p2.GetComponent("Follow2") as MonoBehaviour).enabled = false;
		 p2.rigidbody.isKinematic = false;
	


        (p3.GetComponent("CharacterController") as CharacterController).enabled = false;
		(p3.GetComponent("MouseLook") as MonoBehaviour).enabled = false;
        (p3.GetComponent("FPSInputController") as MonoBehaviour).enabled = false;
        (p3.GetComponent("Follow") as MonoBehaviour).enabled = false;
		 p3.rigidbody.isKinematic = false;

		p1Camera.camera.active = false;
		p2Camera.camera.active = false;
		p3Camera.camera.active = false;

	}

	void OnGUI () {
				//boxes for each character
				GUI.Box (new Rect (10, 10, 100, 120), "Characters");

				if (p1check == true) {
						GUI.Box (new Rect (20, 40, 80, 20), " Character 1"); 
				}
				else if(p2check == true){
						GUI.Box (new Rect (20, 70, 80, 20), " Character 2");
				}
				else if(p3check == true){
						GUI.Box (new Rect (20, 100, 80, 20), " Character 3");
				}
	}
	// Update is called once per frame
	void Update () {

		if(CameraShake.cameraSwitch == true){
			startCamera.camera.active = false;
			p1Camera.camera.active = true;
			p2Camera.camera.active = false;
			p3Camera.camera.active = false;
			(p1.GetComponent ("MouseLook") as MonoBehaviour).enabled = true;
			CameraShake.cameraSwitch = false;

		}
				if (Input.GetKey ("1")) {

						(p1.GetComponent ("CharacterController") as CharacterController).enabled = true;
						(p1.GetComponent ("MouseLook") as MonoBehaviour).enabled = true;
						(p1.GetComponent ("FPSInputController") as MonoBehaviour).enabled = true;
						(p1.GetComponent ("Follow") as MonoBehaviour).enabled = false;
						(p1.GetComponent ("Follow2") as MonoBehaviour).enabled = false;



						(p2.GetComponent ("CharacterController") as CharacterController).enabled = false;
						(p2.GetComponent ("MouseLook") as MonoBehaviour).enabled = false;
						(p2.GetComponent ("FPSInputController") as MonoBehaviour).enabled = false;
						(p2.GetComponent ("Follow2") as MonoBehaviour).enabled = true;
						(p2.GetComponent ("Follow") as MonoBehaviour).enabled = false;



						(p3.GetComponent ("CharacterController") as CharacterController).enabled = false;
						(p3.GetComponent ("MouseLook") as MonoBehaviour).enabled = false;
						(p3.GetComponent ("FPSInputController") as MonoBehaviour).enabled = false;
						(p3.GetComponent ("Follow2") as MonoBehaviour).enabled = false;
						(p3.GetComponent ("Follow") as MonoBehaviour).enabled = true;

						p1.rigidbody.isKinematic = true;
						p2.rigidbody.isKinematic = false;
						p3.rigidbody.isKinematic = false;

						p1Camera.camera.active = true;
						p2Camera.camera.active = false;
						p3Camera.camera.active = false;

						p1check = true;
						p2check = false;
						p3check = false;
				}
				if (Input.GetKey ("2")) {
						(p1.GetComponent ("CharacterController") as CharacterController).enabled = false;
						(p1.GetComponent ("MouseLook") as MonoBehaviour).enabled = false;
						(p1.GetComponent ("FPSInputController") as MonoBehaviour).enabled = false;
						(p1.GetComponent ("Follow") as MonoBehaviour).enabled = true;
						(p1.GetComponent ("Follow2") as MonoBehaviour).enabled = false;



						(p2.GetComponent ("CharacterController") as CharacterController).enabled = true;
						(p2.GetComponent ("MouseLook") as MonoBehaviour).enabled = true;
						(p2.GetComponent ("FPSInputController") as MonoBehaviour).enabled = true;
						(p2.GetComponent ("Follow") as MonoBehaviour).enabled = false;
						(p2.GetComponent ("Follow2") as MonoBehaviour).enabled = false;



						(p3.GetComponent ("CharacterController") as CharacterController).enabled = false;
						(p3.GetComponent ("MouseLook") as MonoBehaviour).enabled = false;
						(p3.GetComponent ("FPSInputController") as MonoBehaviour).enabled = false;
						(p3.GetComponent ("Follow") as MonoBehaviour).enabled = false;
						(p3.GetComponent ("Follow2") as MonoBehaviour).enabled = true;


						p1.rigidbody.isKinematic = false;
						p2.rigidbody.isKinematic = true;
						p3.rigidbody.isKinematic = false;

						p1Camera.camera.active = false;
						p2Camera.camera.active = true;
						p3Camera.camera.active = false;

						p1check = false;
						p2check = true;
						p3check = false;
				}
				if (Input.GetKey ("3")) {
						(p1.GetComponent ("CharacterController") as CharacterController).enabled = false;
						(p1.GetComponent ("MouseLook") as MonoBehaviour).enabled = false;
						(p1.GetComponent ("FPSInputController") as MonoBehaviour).enabled = false;
						(p1.GetComponent ("Follow") as MonoBehaviour).enabled = false;
						(p1.GetComponent ("Follow2") as MonoBehaviour).enabled = true;


						(p2.GetComponent ("CharacterController") as CharacterController).enabled = false;
						(p2.GetComponent ("MouseLook") as MonoBehaviour).enabled = false;
						(p2.GetComponent ("FPSInputController") as MonoBehaviour).enabled = false;
						(p2.GetComponent ("Follow") as MonoBehaviour).enabled = true;
						(p2.GetComponent ("Follow2") as MonoBehaviour).enabled = false;



						(p3.GetComponent ("CharacterController") as CharacterController).enabled = true;
						(p3.GetComponent ("MouseLook") as MonoBehaviour).enabled = true;
						(p3.GetComponent ("FPSInputController") as MonoBehaviour).enabled = true;
						(p3.GetComponent ("Follow") as MonoBehaviour).enabled = false;
						(p3.GetComponent ("Follow2") as MonoBehaviour).enabled = false;

						p1.rigidbody.isKinematic = false;
						p2.rigidbody.isKinematic = false;
						p3.rigidbody.isKinematic = true;

						p1Camera.camera.active = false;
						p2Camera.camera.active = false;
						p3Camera.camera.active = true;

						p1check = false;
						p2check = false;
						p3check = true;
				}
		}
}
