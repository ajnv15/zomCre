using UnityEngine;
using System.Collections;

public class frameFuera : MonoBehaviour {
	public GUIText notificacion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
				
						perdido ();  
		
				} else if (Input.GetKeyDown (KeyCode.A)) {
				
			encontrado();
		}
	}




	public void encontrado(){
		Time.timeScale = 1f;


		notificacion.enabled = false;
	}

	public void perdido(){
		Time.timeScale = 0f;
		if (notificacion != null) {
			notificacion.enabled=true;	
		}

	}


}
