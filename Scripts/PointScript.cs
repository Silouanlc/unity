using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PointScript : MonoBehaviour {

	public timer timerScript;
	public int timeLeft;
	void Start(){
		timerScript = GetComponent<timer> (); //Marche si et seulement si le script est sur le même GameObject que le script Timer
	}

	void OnTriggerEnter2D(Collider2D other)
	{

	}
	
	void OnTriggerExit2D(Collider2D other)
	{
	
		timerScript.timeLeft += 4;

	}
	
	void OnTriggerStay2D(Collider2D other)
	{
		
	}
}