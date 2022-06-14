using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		EscribirCadenaEnConsola(RetornaElMayorNumero(1, 2, 3));
    }

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			EscribirHolaMundoEnConsola();
		}
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			EscribirCadenaEnConsola("Aca tenes tu argumento");
		}
		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			Debug.Log(RetornaRandomEntre(1, 100));
		}
		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			Debug.Log(RetornaElMayorNumero(1, 5, 10));
		}
	}

	public void DestruirObjeto()
	{
		Destroy(gameObject); 
	}

	void EscribirHolaMundoEnConsola()
	{
		Debug.Log("Hola Mundo!");
	}

	void EscribirCadenaEnConsola(string cadena)
	{
		Debug.Log(cadena);
	}

	string RetornaFausto()
	{
		return "Fausto";
	}
	
	int RetornaRandomEntre(int n1, int n2)
	{
		if (n1 >= 0 && n1 > 0)
		{ 
		return Random.Range(n1,n2);
		}
		else
		{
			return -1;
		}
	}

	string RetornaElMayorNumero (int n1, int n2, int n3)
	{
		if (n1 > n2 && n1 > n3)
		{
			string s1 = n1.ToString();
			return s1;
		}
		else if (n2 > n1 && n2 > n3)
		{
			string s2 = n2.ToString();
			return s2;
		}
		else if (n3 > n1 && n3 > n2)
		{
			string s3 = n3.ToString();
			return s3;
		}
		return "-1";
	}
}
