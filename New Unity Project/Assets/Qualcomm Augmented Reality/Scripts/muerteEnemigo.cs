using UnityEngine;
using System.Collections;

public class muerteEnemigo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void Muere(){
		transform.animation.animation ["death"].wrapMode = WrapMode.Once;	
		Destroy (gameObject);
		
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
