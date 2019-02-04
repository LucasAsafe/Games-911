using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpawnShoots : MonoBehaviour {


	public int quantidadedepessoasarremessadas;
	public GameObject tiro;
	// Use this for initialization
	void Start ()
	{
		quantidadedepessoasarremessadas = 0;

	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetButtonDown("Fire2"))
		{
			Instantiate(tiro,transform.position,Quaternion.identity);
			quantidadedepessoasarremessadas += 1;
		}
		if (quantidadedepessoasarremessadas == 20)
		{


			Application.LoadLevel(1);
		}


	}

}
