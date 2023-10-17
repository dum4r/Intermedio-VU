using System.Collections;
using UnityEngine;
using TMPro;
using System.Dynamic;
using System.Collections.Generic;
using System.Reflection;
using System;

public class GC_Semana3 : MonoBehaviour{
	public TMP_InputField cantidadTXT;
	public TMP_InputField nombreTXT;
	public TMP_Text       listaTXT;
	private List<string>  lista;

	public TMP_InputField SaborTXT;
	public TMP_Text       listaTXT2;
	private List<string>  lista2;

	public TMP_Text       Ejer34LBL;

	public TMP_InputField Ejer5TXT;
	public TMP_Text       Ejer5LBL;

	void Start() {
		lista  = new List<string>();
		lista2 = new List<string>();
	}

	public void AgregarLista(){
		int    cantidad = int.Parse(cantidadTXT.text);
		string nombre   = nombreTXT.text;

		lista.Add(nombre);

		if (lista.Count == cantidad ) UpdateLista();
		nombreTXT.text = "";
	}

	private void UpdateLista(){
		listaTXT.text = "Lista de compras\n";
		foreach (var producto in lista) {
			listaTXT.text += " - " + producto +"\n";
		}
	}


	public void AgregarSabor(){
		if (SaborTXT.text == "fin"){
			MostrarSabor();
			return ;
		}
		lista2.Add(SaborTXT.text);
		SaborTXT.text = "";
	}
	private void MostrarSabor(){
		listaTXT2.text = "Lista de Helados\n";
		int i = 0;
		while (i < lista2.Count) {
			listaTXT2.text += " - " + lista2[i] + "\n";
			i++;
		}
	}


	public void Ejer3() {
		Ejer34LBL.text = "";
		int numeroGenerado;
		do {
			numeroGenerado  = UnityEngine.Random.Range(0, 101); // Genera un número aleatorio entre 0 y 100
			Ejer34LBL.text += "Número generado: " + numeroGenerado +"\n";
		} while (numeroGenerado % 2 == 0);
		Ejer34LBL.text += "Se generó un número impar. El ciclo se detiene.\n";
	}
	public void Ejer4() {
		int suma = 0;
		int contador = 0;
		while (contador < 100) {
			contador++;
			if ( contador % 7 != 0 && contador % 19 != 0 ) 
				suma += contador;
		}
		Ejer34LBL.text = "La suma 4 es: " + suma ;
	}


	public void Ejer5() {
		Ejer5LBL.text = "";
		string palabra = Ejer5TXT.text;
		while (!string.IsNullOrEmpty(palabra)) {
			Ejer5LBL.text += palabra + "\n";
			palabra = palabra.Substring(0, palabra.Length - 1);
		}
	}
}
