using UnityEngine;
using System.Collections;

public class playerlives : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll){
		if(coll.gameObject.tag=="Cercle")
		{
			Destroy(gameObject);
		}
	}
}