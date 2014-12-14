using UnityEngine;
using System.Collections;

public class enemigos : MonoBehaviour {
	public GameObject zombie;
	public GameObject instancia;
	public int totalZombies=1;

	public Transform imagatarget;
	//public Transform centro;
	//public Transform PadreZombie;

	public float espera=2f;
	public float delayGeneracion=7f;
	private float horaSiguienteZombie;
	 
	// Use this for initialization
	void Start () {
		horaSiguienteZombie = Time.time + espera;
		 
	}


	
	
	

	// Update is called once per frame
	void Update () {
	if(Time.time >= horaSiguienteZombie){
			horaSiguienteZombie = Time.time + delayGeneracion;
			//Transform 
			Vector3 pos=new Vector3(0,0,0);
			instancia =	Instantiate(zombie,pos,Quaternion.identity) as GameObject;
			//zombieTransform.GetComponent<caminar>();
			instancia.transform.parent=imagatarget;
			totalZombies++;

		}
}
}	






		