using UnityEngine;
using System.Collections;

public class destruir : MonoBehaviour {
	public float tiempoDeVida=7f;


	// Use this for initialization
	void Start () {
		Destroy (gameObject, tiempoDeVida);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
