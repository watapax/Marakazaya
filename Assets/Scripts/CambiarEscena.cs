using UnityEngine;
using System.Collections;

public class CambiarEscena : MonoBehaviour {


	public void Cambiar(int indice)
	{
		Application.LoadLevel(indice);
	}



}
