using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboCoroutine : MonoBehaviour {
	private Vector3 targetScale; 
	private Vector3 targetPosition;
	public  Color   color;
	public  float   duration    = 1.0f;
	private float   elapsedTime = 0.0f;

	void Start(){
		targetScale    = gameObject.transform.localScale;
		targetPosition = gameObject.transform.position;

		StartCoroutine(Transformar());
	}

	IEnumerator Transformar() {
		Vector3 startScale    = Vector3.one;
		Vector3 startPosition = Vector3.zero;
		gameObject.transform.localScale = startScale;
		gameObject.transform.position   = startPosition;
		yield return new WaitForSeconds(2);
		GetComponent<Renderer>().material.color = color;

		while (elapsedTime < duration) {
			elapsedTime += Time.deltaTime;
			float t = Mathf.Clamp01(elapsedTime / duration);
			gameObject.transform.localScale = Vector3.Lerp(startScale   , targetScale   , t);
			gameObject.transform.position   = Vector3.Lerp(startPosition, targetPosition, t);
			yield return null;
		}
		elapsedTime = 0.0f;
		Debug.Log("Finaliza Transformar");
	}
}
