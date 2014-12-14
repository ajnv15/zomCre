using UnityEngine;
using System.Collections;

public class hide : MonoBehaviour, IVirtualButtonEventHandler {
	GameObject myObject;
	int i;
	// Use this for initialization
	void Start () {
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour> ();
		for (i=0; i < vbs.Length; i++) {
			vbs[i].RegisterEventHandler(this);
		
		
		}

		myObject = GameObject.Find ("Cube"); 
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){
		Debug.Log ("pressed");
		myObject.rigidbody.AddForce (Vector3.forward * 10);


	}


	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
		Debug.Log ("released");
		
		
		
	}

}












