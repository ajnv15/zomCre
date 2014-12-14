using UnityEngine;
using System.Collections;

public class caminar : MonoBehaviour {

	private int puntaje=0;
	private float  radio=10f;
	public float incremento=8f;
	private bool muerte=false;
	public int rotacion=0;
	private float tiempoGiro;
	private float ahoraGiro=0f;

	int acumulador=0;


	// Use this for initialization
	void Start () {
		tiempoGiro=Random.Range(15,30);
		ahoraGiro = Time.deltaTime + tiempoGiro;
		Vector3 randomDirection= new Vector3(0,Random.Range(-359, 359),0);
		transform.Rotate(randomDirection);

		animation.wrapMode = WrapMode.Loop;
		animation ["death"].wrapMode = WrapMode.Once;
		animation ["death"].layer = 1;
		animation.Play("walk02");




	}



	void muere(){
		acumulador++;
		if (acumulador == 5  && muerte==false) {

						animation.Stop ();
						animation.Play ("death");
						Destroy (gameObject, 3f);
						acumulador=0;
						muerte=true;
						puntaje=puntaje+10;
						

				}

		}
	void rotar(){
		Vector3 cambioGito= new Vector3(0,Random.Range(60,120),0);
		transform.Rotate(cambioGito);
		ahoraGiro=Time.time+Random.Range(15,30);	
		
		
	
	}

	// Update is called once per frame
	void Update () {



				if (muerte == true) {
								
						transform.Translate (Vector3.zero);
		
		
				} else {
						//radio += incremento * Time.deltaTime;
						//transform.position = new Vector3 (objeto.position.x, transform.position.y, objeto.position.z);
						transform.Translate (Vector3.forward * (Time.deltaTime * 30));
				}

		if (Time.time >= ahoraGiro && muerte==false) {
			rotar ();
		}
		}
}
   