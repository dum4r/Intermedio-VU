using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GC_Semana2 : MonoBehaviour {
	public bool       blnLuz = false;
	public GameObject Luces;
	public GameObject PuertaLuces;

	private bool       blnLlave1 = false;
	private bool       blnLlave2 = false;
	public  GameObject Puerta1AND;

	private bool       blnPuertaRoja = false;
	private bool       blnPuertaAzul = false;
	public  GameObject Puerta1OR;

	void Start() { }
	void Update() { }



	// Operador Lógico NOT (!):
	// Ejercicio 1 - Interruptor de Luz (NOT):
	// Crea un script para un interruptor de luz en Unity. El interruptor debería cambiar el estado 
	// de una luz cuando se activa o desactiva. Utiliza el operador! para invertir el estado actual 
	// de la luz
	public void Interruptor_Luz () {
		blnLuz = !blnLuz;
		Luces.SetActive(blnLuz);
		PuertaLuces.SetActive(!blnLuz);
	}


	// Operador Lógico AND (&&):
	// Ejercicio 1 - Puerta con Dos Llaves:
	// Implementa un Script en el que el jugador tenga que abrir una puerta con dos llaves 
	// diferentes donde se utilice el operador lógico && para verificar si el jugador tiene ambas
	// llaves para abrir la puerta.
	public void TomarLlave1() { blnLlave1 = true; }
	public void TomarLlave2() { blnLlave2 = true; }
	public void AbrirPuerta1AND() {
		if ( blnLlave1 && blnLlave2 )
			Puerta1AND.SetActive(false);
		else Debug.Log("No ha conseguido las dos llaves");
	}


	// Operador Lógico OR (||):
	// Ejercicio 1 - Puertas de Color:
	// Implementa un Script donde hay tres puertas de colores: roja, verde y azul. El jugador 
	// debe elegir entre las puertas para avanzar. Utiliza el operador || para permitir que el 
	// jugador avance si elige la puerta roja o la puerta azul.
	public void PuertaRoja() { blnPuertaRoja = true; }
	public void PuertaAzul() { blnPuertaAzul = true; }
	public void AbrirPuerta1OR() {
		if ( blnPuertaRoja || blnPuertaAzul )
			Puerta1OR.SetActive(false);
		else Debug.Log("Jugador NO AVANZA");
	}
}
