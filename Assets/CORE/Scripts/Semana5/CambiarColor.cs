using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColor : MonoBehaviour{
	void Start() {
		StartCoroutine("cambiarColor");
	}

	IEnumerator cambiarColor(){
		yield return new WaitForSeconds(0.1f);
		GetComponent<Renderer>().material.color = UnityEngine.Color.red;
		yield return new WaitForSeconds(0.1f);
		GetComponent<Renderer>().material.color = UnityEngine.Color.blue;
		
		StartCoroutine("cambiarColor");
		Debug.Log("Finaliza Coroutine");
	}
}
