using UnityEngine;
using System.Collections;

public class RotationBehavior : MonoBehaviour {
	private Vector3 gira;


	// Use this for initialization
	void Start () {
		gira = new Vector3 (0f, 0f, -0.7f);
	}
	
	// Update is called once per frame
	void Update () 
	{	
		transform.Rotate (gira);
	}
}
