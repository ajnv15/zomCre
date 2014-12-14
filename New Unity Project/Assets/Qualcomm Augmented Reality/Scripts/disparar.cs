using UnityEngine;
using System.Collections;

public class disparar : MonoBehaviour {
	public Transform rayo;
	public float delay=0.5f;

	private float nextShoot=0f;
	 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetButtonDown ("Fire1") || Input.touchCount > 0) && Time.time > nextShoot) {
			nextShoot=Time.time+delay;
			Instantiate(rayo,transform.position,transform.rotation); 
		
		}  
	}
}
