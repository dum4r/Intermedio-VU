using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent (typeof (NavMeshAgent))]
public class Cmove : MonoBehaviour{
	public Transform[] pointsWay;
	public float velocidadMovimiento = 3f;
	private int indx = 0;
	NavMeshAgent agente;

	void Start(){
		agente = GetComponent<NavMeshAgent>();
		StartCoroutine(MoverPoint());
	}

	IEnumerator MoverPoint(){
		Debug.Log("Entra a MoverPoint");
		while (true) {
			Vector3 nextPoint = pointsWay[indx].position;
			transform.LookAt(nextPoint);
			agente.SetDestination(nextPoint);

			yield return new WaitUntil(() => Vector3.Distance(transform.position, nextPoint) < 1f);
			indx++;
			if ( indx >=  pointsWay.Length) indx = 0;
		}
	}

	// IEnumerator MoverPoint(){
	// 	Vector3 nextPoint = pointsWay[indx].position;
	// 	transform.LookAt(nextPoint);
	// 	while(Vector3.Distance(transform.position, nextPoint) > 1f) {
	// 		agente.destination = nextPoint;
	// 		yield return Vector3.Distance(transform.position, nextPoint) > 1f;
	// 	}
	// 	indx++;
	// 	if ( indx >=  pointsWay.Length) indx = 0;
	// 	StartCoroutine(MoverPoint());
	// }

	// IEnumerator MoverPoint(){
	// 	Vector3 nextPoint = pointsWay[indx].position;
	// 	transform.LookAt(nextPoint);
	// 	while(transform.position != nextPoint) {
	// 		transform.position = Vector3.MoveTowards(transform.position, nextPoint, velocidadMovimiento*Time.deltaTime);
	// 		yield return null;
	// 	}
	// 	indx++;
	// 	if ( indx >=  pointsWay.Length) indx = 0;
	// 	StartCoroutine(MoverPoint());
	// }

}
