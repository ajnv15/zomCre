using UnityEngine;
using System.Collections;

public class disparo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody.AddForce (transform.forward * 60000);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void eliminarDisparo(){

		Destroy (gameObject, 1);
	
	}

	void OnTriggerEnter(Collider other){
		if (other.name == "piso") {
						Destroy (gameObject, .5f);
						GetComponentInChildren<ParticleSystem> ().enableEmission = false;
			Destroy(gameObject);

		
		} else if (other.tag == "enemigo") {
			other.SendMessage("muere",SendMessageOptions.DontRequireReceiver);
			Destroy(gameObject);

			
		}

	}
}
