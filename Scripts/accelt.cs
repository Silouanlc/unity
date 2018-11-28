using UnityEngine;
using System.Collections;

public class accelt : MonoBehaviour {
	public float speed = 10.0f;
	public float timeLeft = 0.0f ;
	//voir si probleme int
	void Update () {
		
		timeLeft += Time.deltaTime;
		GetComponent<Rigidbody2D>().AddForce(transform.right *speed);
	
		


		if (timeLeft >= 5.0f)
		{
			speed = speed +1;
			timeLeft -= 5.0f;
		}


	}
	
	
	void OnGUI () {
		GUI.color = Color.blue;
		GUI.Label(new Rect(10,20,100,20),"Timer: " +timeLeft);
		
		
	}
}