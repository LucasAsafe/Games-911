using UnityEngine;
using System.Collections;

public class ShootMove : MonoBehaviour {
	public float bulletSpeed;

	// Use this for initialization
	void Start ()
	{

		bulletSpeed = 10 * Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () 
	{

		transform.Translate(0.2f,-bulletSpeed,0);
		Destroy(this.gameObject, 	 1);

	}
}
