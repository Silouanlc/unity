using UnityEngine;
using System.Collections;

public class fo : MonoBehaviour {
	public float speed = 10.0f;
	
	void FixedUpdate()
	{
		GetComponent<Rigidbody2D>().AddForce(transform.right *speed);
	}
}