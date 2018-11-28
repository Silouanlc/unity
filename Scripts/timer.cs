using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {


	public float timeLeft = 5.0f ;
	//voir si probleme int
    void Update () {
	
		timeLeft -= Time.deltaTime;
		
		if (timeLeft <= 0.0f);
		}


	void OnGUI () {
		GUI.color = Color.red;
		GUI.Label(new Rect(10,10,100,20),"Score: " +timeLeft);

	
	}
}